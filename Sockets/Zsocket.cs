using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ZchatServer.Sockets {
    public class Zsocket
    {
        // cancellation token to break the loop inside the tcp listener
        public CancellationTokenSource? Token;

        // a list of the current clients connected to the listener
        public List<TcpClient>? _clients { get; set; }
        
        private TcpListener? _listener;

        // represent Port and Ip used by the the listener
        private int ServerPort { get; set; }
        private string ServerIp { get; set; }

        // the instance of zsockets accept a connection string -> ip:port
        public Zsocket(string connection_string)
        {
            List<string> conn_args = connection_string.Split(':').ToList();
            this.ServerIp = conn_args[0];
            this.ServerPort = int.Parse(conn_args[1]);
            this._clients = new();

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
            _listener.Start();
            Console.WriteLine("Server is listening");
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

        

        // close all the current connections of the listener
        public void CloseAllConnections() {
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

        // start listener loop to listen incoming clients connection
        public async void WaitClients(string message, BindingList<string> binding, Form parentForm)
        {

            if (this._listener == null)
                throw new Exception("No listener server started");

            if (this._clients == null)
                throw new Exception("this._clients cannot be NULL");

            int num = 0;
            this.Token = new CancellationTokenSource();
            await Task.Run(() => {
                while(true)
                {
                    if(this.Token.IsCancellationRequested)
                        break;
                    
                    try
                    {
                        TcpClient client = this._listener.AcceptTcpClient();
                        this._clients.Add(client);
                        // welcome message to all entering users
                        byte[] welcomeMessage = Encoding.ASCII.GetBytes(message);
                        client.GetStream().Write(welcomeMessage, 0, welcomeMessage.Length);
                        var ipAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                        var port = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();

                        var newClientString = $"Client {num} with IP {ipAddress}:{port} connected";
                        parentForm.Invoke(new Action(() => binding.Add(newClientString)));

                        Console.WriteLine($"Nuevo cliente conectado -> {ipAddress}:{port}");
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