namespace ZchatServer
{
    partial class CreateServerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipFvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portFvalue = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADDRESS";
            // 
            // ipFvalue
            // 
            this.ipFvalue.Location = new System.Drawing.Point(119, 34);
            this.ipFvalue.Name = "ipFvalue";
            this.ipFvalue.Size = new System.Drawing.Size(125, 27);
            this.ipFvalue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // portFvalue
            // 
            this.portFvalue.Location = new System.Drawing.Point(119, 87);
            this.portFvalue.Name = "portFvalue";
            this.portFvalue.Size = new System.Drawing.Size(125, 27);
            this.portFvalue.TabIndex = 3;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(156, 157);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(88, 29);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Create TCP server";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.portFvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipFvalue);
            this.Controls.Add(this.label1);
            this.Name = "CreateServerForm";
            this.Text = "CreateServerForm";
            this.Load += new System.EventHandler(this.CreateServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ipFvalue;
        private Label label2;
        private TextBox portFvalue;
        private Button CreateBtn;
        private Button button1;
    }
}