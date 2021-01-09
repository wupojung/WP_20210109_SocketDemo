namespace Server
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
            this.cbbIP = new System.Windows.Forms.ComboBox();
            this.labIP = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbIP
            // 
            this.cbbIP.FormattingEnabled = true;
            this.cbbIP.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cbbIP.Location = new System.Drawing.Point(99, 37);
            this.cbbIP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbbIP.Name = "cbbIP";
            this.cbbIP.Size = new System.Drawing.Size(189, 35);
            this.cbbIP.TabIndex = 2;
            this.cbbIP.Text = "127.0.0.1";
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Location = new System.Drawing.Point(21, 40);
            this.labIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(31, 27);
            this.labIP.TabIndex = 3;
            this.labIP.Text = "IP";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbMsg.Location = new System.Drawing.Point(12, 169);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(732, 314);
            this.rtbMsg.TabIndex = 4;
            this.rtbMsg.Text = "";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(99, 90);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(85, 35);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "8885";
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(21, 93);
            this.labPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(67, 27);
            this.labPort.TabIndex = 6;
            this.labPort.Text = "PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(307, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 83);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "啟動";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbbIP);
            this.gbInfo.Controls.Add(this.btnConnect);
            this.gbInfo.Controls.Add(this.labIP);
            this.gbInfo.Controls.Add(this.tbPort);
            this.gbInfo.Controls.Add(this.labPort);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(474, 140);
            this.gbInfo.TabIndex = 8;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "連線資訊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 504);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.rtbMsg);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbIP;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbInfo;
    }
}

