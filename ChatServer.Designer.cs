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
            this.CloseServerBtn = new System.Windows.Forms.Button();
            this.ConnectedIps = new System.Windows.Forms.ListBox();
            this.StatusMsg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToExistingServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imessagesfield = new System.Windows.Forms.RichTextBox();
            this.ibuttondelete = new System.Windows.Forms.Button();
            this.ibuttonsend = new System.Windows.Forms.Button();
            this.iprompt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.CloseServerBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ConnectedIps);
            this.splitContainer1.Panel1.Controls.Add(this.StatusMsg);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip3);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.ibuttondelete);
            this.splitContainer1.Panel2.Controls.Add(this.ibuttonsend);
            this.splitContainer1.Panel2.Controls.Add(this.iprompt);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 758);
            this.splitContainer1.SplitterDistance = 553;
            this.splitContainer1.TabIndex = 0;
            // 
            // CloseServerBtn
            // 
            this.CloseServerBtn.Location = new System.Drawing.Point(41, 259);
            this.CloseServerBtn.Name = "CloseServerBtn";
            this.CloseServerBtn.Size = new System.Drawing.Size(152, 29);
            this.CloseServerBtn.TabIndex = 9;
            this.CloseServerBtn.Text = "Close Server";
            this.CloseServerBtn.UseVisualStyleBackColor = true;
            this.CloseServerBtn.Visible = false;
            this.CloseServerBtn.Click += new System.EventHandler(this.CloseServerBtn_Click);
            // 
            // ConnectedIps
            // 
            this.ConnectedIps.BackColor = System.Drawing.Color.Indigo;
            this.ConnectedIps.ForeColor = System.Drawing.Color.Lime;
            this.ConnectedIps.FormattingEnabled = true;
            this.ConnectedIps.ItemHeight = 20;
            this.ConnectedIps.Location = new System.Drawing.Point(45, 462);
            this.ConnectedIps.Name = "ConnectedIps";
            this.ConnectedIps.Size = new System.Drawing.Size(465, 144);
            this.ConnectedIps.TabIndex = 8;
            // 
            // StatusMsg
            // 
            this.StatusMsg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusMsg.ForeColor = System.Drawing.Color.Red;
            this.StatusMsg.Location = new System.Drawing.Point(122, 185);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(328, 50);
            this.StatusMsg.TabIndex = 7;
            this.StatusMsg.Text = "Server disconnected";
            this.StatusMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(41, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 63);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(41, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connected IPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(83, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 99);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZiroxChat";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Red;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9});
            this.menuStrip3.Location = new System.Drawing.Point(0, 102);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(553, 51);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Cascadia Code", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(109, 47);
            this.toolStripMenuItem9.Text = "Info";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 51);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(553, 51);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Cascadia Code", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(185, 47);
            this.toolStripMenuItem5.Text = "Accounts";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(454, 48);
            this.toolStripMenuItem6.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(454, 48);
            this.toolStripMenuItem7.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(454, 48);
            this.toolStripMenuItem8.Text = "toolStripMenuItem4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 51);
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
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cascadia Code", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(280, 47);
            this.toolStripMenuItem1.Text = "Server config";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewServerToolStripMenuItem,
            this.connectToExistingServerToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(245, 48);
            this.toolStripMenuItem2.Text = "Connect";
            // 
            // createNewServerToolStripMenuItem
            // 
            this.createNewServerToolStripMenuItem.Name = "createNewServerToolStripMenuItem";
            this.createNewServerToolStripMenuItem.Size = new System.Drawing.Size(606, 48);
            this.createNewServerToolStripMenuItem.Text = "Create new server";
            this.createNewServerToolStripMenuItem.Click += new System.EventHandler(this.createNewServerToolStripMenuItem_Click);
            // 
            // connectToExistingServerToolStripMenuItem
            // 
            this.connectToExistingServerToolStripMenuItem.Name = "connectToExistingServerToolStripMenuItem";
            this.connectToExistingServerToolStripMenuItem.Size = new System.Drawing.Size(606, 48);
            this.connectToExistingServerToolStripMenuItem.Text = "Connect to existing server";
            this.connectToExistingServerToolStripMenuItem.Click += new System.EventHandler(this.connectToExistingServerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imessagesfield);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 440);
            this.panel1.TabIndex = 8;
            // 
            // imessagesfield
            // 
            this.imessagesfield.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imessagesfield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imessagesfield.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imessagesfield.ForeColor = System.Drawing.Color.Black;
            this.imessagesfield.Location = new System.Drawing.Point(0, 0);
            this.imessagesfield.Name = "imessagesfield";
            this.imessagesfield.ReadOnly = true;
            this.imessagesfield.Size = new System.Drawing.Size(816, 440);
            this.imessagesfield.TabIndex = 0;
            this.imessagesfield.Text = "Welcome to Zirox Chat.\n";
            // 
            // ibuttondelete
            // 
            this.ibuttondelete.BackColor = System.Drawing.Color.Black;
            this.ibuttondelete.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibuttondelete.ForeColor = System.Drawing.Color.Lime;
            this.ibuttondelete.Location = new System.Drawing.Point(485, 721);
            this.ibuttondelete.Name = "ibuttondelete";
            this.ibuttondelete.Size = new System.Drawing.Size(164, 34);
            this.ibuttondelete.TabIndex = 7;
            this.ibuttondelete.Text = "Clean";
            this.ibuttondelete.UseVisualStyleBackColor = false;
            this.ibuttondelete.Click += new System.EventHandler(this.ibuttondelete_Click);
            // 
            // ibuttonsend
            // 
            this.ibuttonsend.BackColor = System.Drawing.Color.Black;
            this.ibuttonsend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibuttonsend.ForeColor = System.Drawing.Color.Lime;
            this.ibuttonsend.Location = new System.Drawing.Point(645, 721);
            this.ibuttonsend.Name = "ibuttonsend";
            this.ibuttonsend.Size = new System.Drawing.Size(177, 34);
            this.ibuttonsend.TabIndex = 6;
            this.ibuttonsend.Text = "Send";
            this.ibuttonsend.UseVisualStyleBackColor = false;
            this.ibuttonsend.Click += new System.EventHandler(this.ibuttonsend_Click);
            // 
            // iprompt
            // 
            this.iprompt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iprompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iprompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iprompt.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iprompt.ForeColor = System.Drawing.Color.Black;
            this.iprompt.Location = new System.Drawing.Point(6, 451);
            this.iprompt.Margin = new System.Windows.Forms.Padding(5);
            this.iprompt.Name = "iprompt";
            this.iprompt.Size = new System.Drawing.Size(816, 302);
            this.iprompt.TabIndex = 5;
            this.iprompt.Text = "Escribe algo...";
            // 
            // ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 758);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChatServer";
            this.Text = "Chat server";
            this.Load += new System.EventHandler(this.ChatServer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem toolStripMenuItem9;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Label label1;
        private Button ibuttondelete;
        private Button ibuttonsend;
        private RichTextBox iprompt;
        private Panel panel1;
        private RichTextBox imessagesfield;
        private Label label2;
        private ToolStripMenuItem createNewServerToolStripMenuItem;
        private ToolStripMenuItem connectToExistingServerToolStripMenuItem;
        private Label StatusMsg;
        private Panel panel2;
        private ListBox ConnectedIps;
        private Button CloseServerBtn;
    }
}