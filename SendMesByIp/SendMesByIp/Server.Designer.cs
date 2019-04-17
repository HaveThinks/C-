namespace SendMesByIp
{
    partial class Server
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServerConn = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(104, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(128, 21);
            this.txtIP.TabIndex = 0;
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(309, 43);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(141, 21);
            this.txtPORT.TabIndex = 1;
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(104, 353);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(260, 21);
            this.txtSendMsg.TabIndex = 3;
            this.txtSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendMsg_KeyDown);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(64, 46);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(17, 12);
            this.IP.TabIndex = 4;
            this.IP.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口号";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(104, 139);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(346, 159);
            this.txtMsg.TabIndex = 6;
            this.txtMsg.Text = "";
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "消息框";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnServerConn
            // 
            this.btnServerConn.Location = new System.Drawing.Point(309, 71);
            this.btnServerConn.Name = "btnServerConn";
            this.btnServerConn.Size = new System.Drawing.Size(75, 23);
            this.btnServerConn.TabIndex = 8;
            this.btnServerConn.Text = "启动服务";
            this.btnServerConn.UseVisualStyleBackColor = true;
            this.btnServerConn.Click += new System.EventHandler(this.btnServerConn_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(375, 351);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 9;
            this.btnSendMsg.Text = "发送信息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "打开客户端";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 316);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 21;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnServerConn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.txtPORT);
            this.Controls.Add(this.txtIP);
            this.Name = "Server";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServerConn;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
    }
}

