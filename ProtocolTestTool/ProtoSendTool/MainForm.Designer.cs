namespace ProtoSendTool
{
    partial class MainForm
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
            this.GetProto = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProtocolSelect = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisConnectBtn = new System.Windows.Forms.Button();
            this.ReconnectLoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetProto
            // 
            this.GetProto.Location = new System.Drawing.Point(392, 65);
            this.GetProto.Name = "GetProto";
            this.GetProto.Size = new System.Drawing.Size(107, 28);
            this.GetProto.TabIndex = 0;
            this.GetProto.Text = "生成发送协议";
            this.GetProto.UseVisualStyleBackColor = true;
            this.GetProto.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(392, 108);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(107, 29);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "发送";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(520, 11);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainTextBox.Size = new System.Drawing.Size(694, 423);
            this.MainTextBox.TabIndex = 2;
            this.MainTextBox.WordWrap = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(19, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(356, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "数据类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "变量名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "值";
            this.Column3.Name = "Column3";
            // 
            // ProtocolSelect
            // 
            this.ProtocolSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProtocolSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProtocolSelect.FormattingEnabled = true;
            this.ProtocolSelect.Location = new System.Drawing.Point(76, 39);
            this.ProtocolSelect.Name = "ProtocolSelect";
            this.ProtocolSelect.Size = new System.Drawing.Size(299, 20);
            this.ProtocolSelect.TabIndex = 5;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(293, 11);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 21);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(76, 12);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(193, 21);
            this.UsernameInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "输入账号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "清空窗口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "协议名称";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(396, 241);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(103, 33);
            this.ConnectBtn.TabIndex = 12;
            this.ConnectBtn.Text = "连接GateServer";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisConnectBtn
            // 
            this.DisConnectBtn.Location = new System.Drawing.Point(396, 280);
            this.DisConnectBtn.Name = "DisConnectBtn";
            this.DisConnectBtn.Size = new System.Drawing.Size(103, 32);
            this.DisConnectBtn.TabIndex = 13;
            this.DisConnectBtn.Text = "断开Server";
            this.DisConnectBtn.UseVisualStyleBackColor = true;
            this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
            // 
            // ReconnectLoginBtn
            // 
            this.ReconnectLoginBtn.Location = new System.Drawing.Point(392, 9);
            this.ReconnectLoginBtn.Name = "ReconnectLoginBtn";
            this.ReconnectLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.ReconnectLoginBtn.TabIndex = 0;
            this.ReconnectLoginBtn.Text = "断线重连";
            this.ReconnectLoginBtn.Click += new System.EventHandler(this.ReconnectLoginBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 448);
            this.Controls.Add(this.ReconnectLoginBtn);
            this.Controls.Add(this.DisConnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ProtocolSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.GetProto);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetProto;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox ProtocolSelect;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisConnectBtn;
        private System.Windows.Forms.Button ReconnectLoginBtn;
    }
}

