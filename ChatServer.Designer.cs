namespace ZchatServer
{
    partial class ChatServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatServer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.ServerInfo = new System.Windows.Forms.ListBox();
            this.CloseServerBtn = new System.Windows.Forms.Button();
            this.ConnectedIps = new System.Windows.Forms.ListBox();
            this.StatusMsg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToExistingServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.Chat = new System.Windows.Forms.ListBox();
            this.ibuttondelete = new System.Windows.Forms.Button();
            this.ibuttonsend = new System.Windows.Forms.Button();
            this.iprompt = new System.Windows.Forms.RichTextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.UserName);
            this.splitContainer1.Panel1.Controls.Add(this.ServerInfo);
            this.splitContainer1.Panel1.Controls.Add(this.CloseServerBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ConnectedIps);
            this.splitContainer1.Panel1.Controls.Add(this.StatusMsg);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.Chat);
            this.splitContainer1.Panel2.Controls.Add(this.ibuttondelete);
            this.splitContainer1.Panel2.Controls.Add(this.ibuttonsend);
            this.splitContainer1.Panel2.Controls.Add(this.iprompt);
            this.splitContainer1.Panel2.Controls.Add(this.btnMinimize);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 570);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(87, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Indigo;
            this.UserName.ForeColor = System.Drawing.Color.Lime;
            this.UserName.Location = new System.Drawing.Point(178, 523);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(110, 23);
            this.UserName.TabIndex = 11;
            // 
            // ServerInfo
            // 
            this.ServerInfo.BackColor = System.Drawing.Color.Indigo;
            this.ServerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerInfo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServerInfo.ForeColor = System.Drawing.Color.Lime;
            this.ServerInfo.FormattingEnabled = true;
            this.ServerInfo.ItemHeight = 19;
            this.ServerInfo.Location = new System.Drawing.Point(94, 148);
            this.ServerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerInfo.Name = "ServerInfo";
            this.ServerInfo.Size = new System.Drawing.Size(310, 97);
            this.ServerInfo.TabIndex = 10;
            // 
            // CloseServerBtn
            // 
            this.CloseServerBtn.BackColor = System.Drawing.Color.Indigo;
            this.CloseServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseServerBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseServerBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseServerBtn.Location = new System.Drawing.Point(94, 256);
            this.CloseServerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseServerBtn.Name = "CloseServerBtn";
            this.CloseServerBtn.Size = new System.Drawing.Size(310, 28);
            this.CloseServerBtn.TabIndex = 9;
            this.CloseServerBtn.Text = "Close Server";
            this.CloseServerBtn.UseVisualStyleBackColor = false;
            this.CloseServerBtn.Visible = false;
            this.CloseServerBtn.Click += new System.EventHandler(this.CloseServerBtn_Click);
            // 
            // ConnectedIps
            // 
            this.ConnectedIps.BackColor = System.Drawing.Color.Indigo;
            this.ConnectedIps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectedIps.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectedIps.ForeColor = System.Drawing.Color.Lime;
            this.ConnectedIps.FormattingEnabled = true;
            this.ConnectedIps.ItemHeight = 23;
            this.ConnectedIps.Location = new System.Drawing.Point(36, 311);
            this.ConnectedIps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectedIps.Name = "ConnectedIps";
            this.ConnectedIps.Size = new System.Drawing.Size(407, 117);
            this.ConnectedIps.TabIndex = 8;
            // 
            // StatusMsg
            // 
            this.StatusMsg.BackColor = System.Drawing.Color.Black;
            this.StatusMsg.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusMsg.ForeColor = System.Drawing.Color.Red;
            this.StatusMsg.Location = new System.Drawing.Point(105, 108);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(287, 38);
            this.StatusMsg.TabIndex = 7;
            this.StatusMsg.Text = "Server disconnected";
            this.StatusMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(386, 496);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 47);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connected IPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ink Free", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(2, 36);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(105, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(481, 261);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZiroxChat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(485, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 32);
            this.toolStripMenuItem1.Text = "Server config";
            this.toolStripMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem1_MouseDown);
            this.toolStripMenuItem1.MouseHover += new System.EventHandler(this.toolStripMenuItem1_MouseHover);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Indigo;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewServerToolStripMenuItem,
            this.connectToExistingServerToolStripMenuItem});
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 32);
            this.toolStripMenuItem2.Text = "Connect";
            // 
            // createNewServerToolStripMenuItem
            // 
            this.createNewServerToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.createNewServerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.createNewServerToolStripMenuItem.Name = "createNewServerToolStripMenuItem";
            this.createNewServerToolStripMenuItem.Size = new System.Drawing.Size(396, 32);
            this.createNewServerToolStripMenuItem.Text = "Create new server";
            this.createNewServerToolStripMenuItem.Click += new System.EventHandler(this.createNewServerToolStripMenuItem_Click);
            // 
            // connectToExistingServerToolStripMenuItem
            // 
            this.connectToExistingServerToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.connectToExistingServerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.connectToExistingServerToolStripMenuItem.Name = "connectToExistingServerToolStripMenuItem";
            this.connectToExistingServerToolStripMenuItem.Size = new System.Drawing.Size(396, 32);
            this.connectToExistingServerToolStripMenuItem.Text = "Connect to existing server";
            this.connectToExistingServerToolStripMenuItem.Click += new System.EventHandler(this.connectToExistingServerToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(728, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Chat
            // 
            this.Chat.BackColor = System.Drawing.Color.Indigo;
            this.Chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chat.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Chat.ForeColor = System.Drawing.Color.Lime;
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 35;
            this.Chat.Location = new System.Drawing.Point(3, 2);
            this.Chat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(719, 282);
            this.Chat.TabIndex = 8;
            // 
            // ibuttondelete
            // 
            this.ibuttondelete.BackColor = System.Drawing.Color.Indigo;
            this.ibuttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibuttondelete.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibuttondelete.ForeColor = System.Drawing.Color.Lime;
            this.ibuttondelete.Location = new System.Drawing.Point(403, 533);
            this.ibuttondelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibuttondelete.Name = "ibuttondelete";
            this.ibuttondelete.Size = new System.Drawing.Size(144, 26);
            this.ibuttondelete.TabIndex = 7;
            this.ibuttondelete.Text = "Clean";
            this.ibuttondelete.UseVisualStyleBackColor = false;
            this.ibuttondelete.Click += new System.EventHandler(this.ibuttondelete_Click);
            // 
            // ibuttonsend
            // 
            this.ibuttonsend.BackColor = System.Drawing.Color.Purple;
            this.ibuttonsend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibuttonsend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibuttonsend.ForeColor = System.Drawing.Color.Lime;
            this.ibuttonsend.Location = new System.Drawing.Point(553, 533);
            this.ibuttonsend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibuttonsend.Name = "ibuttonsend";
            this.ibuttonsend.Size = new System.Drawing.Size(155, 26);
            this.ibuttonsend.TabIndex = 6;
            this.ibuttonsend.Text = "Send";
            this.ibuttonsend.UseVisualStyleBackColor = false;
            this.ibuttonsend.Click += new System.EventHandler(this.ibuttonsend_Click);
            // 
            // iprompt
            // 
            this.iprompt.BackColor = System.Drawing.Color.Black;
            this.iprompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iprompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iprompt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iprompt.ForeColor = System.Drawing.Color.MediumBlue;
            this.iprompt.Location = new System.Drawing.Point(3, 302);
            this.iprompt.Margin = new System.Windows.Forms.Padding(4);
            this.iprompt.Name = "iprompt";
            this.iprompt.Size = new System.Drawing.Size(714, 265);
            this.iprompt.TabIndex = 5;
            this.iprompt.Text = "Escribe algo...";
            this.iprompt.Click += new System.EventHandler(this.iprompt_Click);
            this.iprompt.TextChanged += new System.EventHandler(this.iprompt_TextChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.Lime;
            this.btnMinimize.Location = new System.Drawing.Point(726, 25);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(19, 26);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1250, 570);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChatServer";
            this.Text = "Chat server";
            this.Load += new System.EventHandler(this.ChatServer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label1;
        private Button ibuttondelete;
        private Button ibuttonsend;
        private RichTextBox iprompt;
        private Label label2;
        private ToolStripMenuItem createNewServerToolStripMenuItem;
        private ToolStripMenuItem connectToExistingServerToolStripMenuItem;
        private Label StatusMsg;
        private Panel panel2;
        private ListBox ConnectedIps;
        private Button CloseServerBtn;
        private ListBox ServerInfo;
        private ListBox Chat;
        private Label label3;
        private TextBox UserName;
        private Button btnClose;
        private Button btnMinimize;
    }
}