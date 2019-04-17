namespace SendMesByIp
{
    partial class Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.txtCMsg = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(370, 380);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "发送信息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Location = new System.Drawing.Point(304, 100);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(75, 23);
            this.btnBeginListen.TabIndex = 17;
            this.btnBeginListen.Text = "连接到服务端";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "消息框";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(99, 168);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(346, 159);
            this.txtMsg.TabIndex = 15;
            this.txtMsg.Text = "";
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "端口号";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(59, 75);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(17, 12);
            this.IP.TabIndex = 13;
            this.IP.Text = "IP";
            // 
            // txtCMsg
            // 
            this.txtCMsg.Location = new System.Drawing.Point(99, 382);
            this.txtCMsg.Name = "txtCMsg";
            this.txtCMsg.Size = new System.Drawing.Size(260, 21);
            this.txtCMsg.TabIndex = 12;
            this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(304, 72);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(141, 21);
            this.txtPort.TabIndex = 11;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(99, 72);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(128, 21);
            this.txtIP.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "名称";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBeginListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.txtCMsg);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Name = "Client";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.TextBox txtCMsg;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
    }
}