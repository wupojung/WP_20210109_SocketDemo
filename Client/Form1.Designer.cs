namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labIP = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbIP);
            this.gbInfo.Controls.Add(this.btnConnect);
            this.gbInfo.Controls.Add(this.labIP);
            this.gbInfo.Controls.Add(this.tbPort);
            this.gbInfo.Controls.Add(this.labPort);
            this.gbInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.gbInfo.Location = new System.Drawing.Point(15, 16);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gbInfo.Size = new System.Drawing.Size(522, 79);
            this.gbInfo.TabIndex = 9;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "連線資訊";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(423, 32);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 35);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "啟動";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Location = new System.Drawing.Point(18, 35);
            this.labIP.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(31, 27);
            this.labIP.TabIndex = 3;
            this.labIP.Text = "IP";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(339, 32);
            this.tbPort.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(72, 35);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "8885";
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(254, 35);
            this.labPort.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(67, 27);
            this.labPort.TabIndex = 6;
            this.labPort.Text = "PORT";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(67, 32);
            this.tbIP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(169, 35);
            this.tbIP.TabIndex = 8;
            this.tbIP.Text = "127.0.0.1";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(15, 109);
            this.rtbMsg.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(802, 381);
            this.rtbMsg.TabIndex = 10;
            this.rtbMsg.Text = "";
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(15, 504);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(705, 35);
            this.tbMsg.TabIndex = 9;
            this.tbMsg.Text = "hi";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(732, 504);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 35);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "送出";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 562);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnSend;
    }
}

