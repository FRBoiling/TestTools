namespace ProtocolSendTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNameInput = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetProto = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisConnectBtn = new System.Windows.Forms.Button();
            this.GenrateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "输入账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "协议名称";
            // 
            // AccountNameInput
            // 
            this.AccountNameInput.Location = new System.Drawing.Point(71, 6);
            this.AccountNameInput.Name = "AccountNameInput";
            this.AccountNameInput.Size = new System.Drawing.Size(193, 21);
            this.AccountNameInput.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 20);
            this.comboBox2.TabIndex = 13;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(288, 6);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 21);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(14, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(356, 475);
            this.dataGridView1.TabIndex = 15;
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
            // GetProto
            // 
            this.GetProto.Location = new System.Drawing.Point(388, 39);
            this.GetProto.Name = "GetProto";
            this.GetProto.Size = new System.Drawing.Size(107, 28);
            this.GetProto.TabIndex = 16;
            this.GetProto.Text = "生成发送协议";
            this.GetProto.UseVisualStyleBackColor = true;
            this.GetProto.Click += new System.EventHandler(this.GetProto_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(388, 89);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(107, 29);
            this.SendBtn.TabIndex = 17;
            this.SendBtn.Text = "发送";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(388, 214);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(103, 33);
            this.ConnectBtn.TabIndex = 18;
            this.ConnectBtn.Text = "连接Server";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisConnectBtn
            // 
            this.DisConnectBtn.Location = new System.Drawing.Point(388, 269);
            this.DisConnectBtn.Name = "DisConnectBtn";
            this.DisConnectBtn.Size = new System.Drawing.Size(103, 32);
            this.DisConnectBtn.TabIndex = 19;
            this.DisConnectBtn.Text = "断开Server";
            this.DisConnectBtn.UseVisualStyleBackColor = true;
            this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
            // 
            // GenrateBtn
            // 
            this.GenrateBtn.Location = new System.Drawing.Point(388, 363);
            this.GenrateBtn.Name = "GenrateBtn";
            this.GenrateBtn.Size = new System.Drawing.Size(103, 23);
            this.GenrateBtn.TabIndex = 20;
            this.GenrateBtn.Text = "生成代码";
            this.GenrateBtn.UseVisualStyleBackColor = true;
            this.GenrateBtn.Click += new System.EventHandler(this.GenrateBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "清空窗口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(514, 10);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainTextBox.Size = new System.Drawing.Size(464, 560);
            this.MainTextBox.TabIndex = 22;
            this.MainTextBox.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 576);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenrateBtn);
            this.Controls.Add(this.DisConnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.GetProto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.AccountNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountNameInput;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button GetProto;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisConnectBtn;
        private System.Windows.Forms.Button GenrateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MainTextBox;
    }
}

