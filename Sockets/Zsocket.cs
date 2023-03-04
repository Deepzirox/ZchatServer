using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZchatServer.Sockets {
    public class Zsocket
    {
       
        // cancellation token to break the loop inside the tcp listener
        public CancellationTokenSource? Token;

        // a list of the current clients connected to the listener
        public ConcurrentBag<TcpClient>? _clients;
        

        private TcpListener? _listener;
        private TcpClient adminSocket;
        public TcpClient AdminSocket
        {
            get
            {
                if (adminSocket != null)
                {
                    return adminSocket;
                }

                return null;
            }
            private set { }
        }

        // represent Port and Ip used by the the listener
        private int ServerPort { get; set; }
        public int Port { get { return ServerPort; } set { ServerPort = value; } }
        private string ServerIp { get; set; }
        public string Ip { get { return ServerIp; } set { ServerIp = value; } }

        // the instance of zsockets accept a connection string -> ip:port
        public Zsocket(string connection_string)
        {
            List<string> conn_args = connection_string.Split(':').ToList();
            this.ServerIp = conn_args[0];
            this.ServerPort = int.Parse(conn_args[1]);
            this._clients = new();
            this.Token = new CancellationTokenSource();

        }

        public void CloseListener()
        {
            if (this._listener != null)
            {
                this._listener.Stop();
            }
        }

        // method to cancel the loop of the current listener
        public void CancelToken() {
            if (this.Token != null)
                this.Token.Cancel();
        }

        // close all the current connections of the listener
        public void CloseAllConnections()
        {
            if (this._clients != null)
                foreach (var client in this._clients)
                    client.Close();
        }


        public void CleanUp()
        {
            this.CancelToken();
            this.CloseListener();
            this.CloseAllConnections();
        }


        // create basic tcp server
        public TcpListener CreateTcpListener()
        {
            Console.WriteLine(this.ServerIp);
            // parsing my own ipAdress using type safe memory checking
            ReadOnlySpan<char> ipBytes = new(this.ServerIp.ToCharArray());
            IPAddress ipAddress = IPAddress.Parse(ipBytes);
            
            // creating listener
            this._listener = new TcpListener(ipAddress, this.ServerPort);
            if (this._listener == null) {
                throw new Exception("Listener cannot be created");
            }
            this._listener.Start();
            Console.WriteLine("Server is listening");
            // pushing the HOST socket
            TcpClient AdminClient = new TcpClient(this.ServerIp, this.ServerPort);
            this._clients.Add(AdminClient);
            this.adminSocket = AdminClient;
            return _listener;
        }



        // send message to all connected clients
        public void BroadCast(string message) {
            if (this._clients != null)
                foreach (var client in this._clients)
                {
                    if (client.Connected)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes(message);
                        client.GetStream().Write(msg, 0, msg.Length);
                    }
                }
        }

        public void ReadNewData(BindingList<string> chat, Form parentForm)
        {
            if (this.Token == null)
                return;

            var client = this.adminSocket;

            if (client.Connected)
            {
                byte[] msg = new byte[1024];
                client.GetStream().Read(msg, 0, msg.Length);
                string newData = Encoding.ASCII.GetString(msg);
                parentForm.Invoke(new Action(() => chat.Add(newData)));
            }
        }
        

        // start listener loop to listen incoming clients connection
        public async void WaitClients(BindingList<string> ipBinds, BindingList<string> chat, Form parentForm)
        {
            if (this.Token == null)
                throw new Exception("Cancelation Token has not been created");

            if (this._listener == null)
                throw new Exception("No listener server started");

            if (this._clients == null)
                throw new Exception("this._clients cannot be NULL");

            int num = 0;
             
           
            
            await Task.Run(() => {
                while(!this.Token.IsCancellationRequested)
                {
                    try
                    {
                        
                        TcpClient client = this._listener.AcceptTcpClient();
                        this._clients.Add(client);

                        

                        var ipAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                        var port = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();

                        var newClientString = $"Client {num} with IP {ipAddress}:{port} connected";
                        parentForm.Invoke(new Action(() => ipBinds.Add(newClientString)));
                        
                        num++;

                    } catch
                    {
                        parentForm.Invoke(new Action(() => MessageBox.Show("Server stopped listening")));
                        break;
                    }
                    
                }
            }, this.Token.Token);
            
        }
    }
}