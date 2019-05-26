namespace EncryptTool
{
    partial class CrackForm
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
            this.btnCrack = new System.Windows.Forms.Button();
            this.txtDesKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipherGen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.timerCrackState = new System.Timers.Timer();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtThreadNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxThread = new System.Windows.Forms.ComboBox();
            this.prgBar1 = new EncryptTool.CustomProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerCrackState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrack
            // 
            this.btnCrack.Location = new System.Drawing.Point(14, 144);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(84, 34);
            this.btnCrack.TabIndex = 0;
            this.btnCrack.Text = "开始破解";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // txtDesKey
            // 
            this.txtDesKey.Location = new System.Drawing.Point(75, 87);
            this.txtDesKey.Name = "txtDesKey";
            this.txtDesKey.Size = new System.Drawing.Size(56, 21);
            this.txtDesKey.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "DESKey值：";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(226, 27);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(208, 45);
            this.txtCiphertext.TabIndex = 16;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(12, 27);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(208, 45);
            this.txtPlaintext.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "明文样例：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "密文样例：";
            // 
            // txtCipherGen
            // 
            this.txtCipherGen.Location = new System.Drawing.Point(226, 105);
            this.txtCipherGen.Multiline = true;
            this.txtCipherGen.Name = "txtCipherGen";
            this.txtCipherGen.Size = new System.Drawing.Size(208, 45);
            this.txtCipherGen.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "生成密文：";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(173, 143);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 34);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "||";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "用时：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "破解进度：";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(273, 162);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(113, 12);
            this.lbSeconds.TabIndex = 17;
            this.lbSeconds.Text = "00时 00分 00秒 000";
            // 
            // timerCrackState
            // 
            this.timerCrackState.SynchronizingObject = this;
            this.timerCrackState.Elapsed += new System.Timers.ElapsedEventHandler(this.timerCrackState_Elapsed);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(111, 143);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(47, 34);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtThreadNum
            // 
            this.txtThreadNum.Location = new System.Drawing.Point(192, 87);
            this.txtThreadNum.Name = "txtThreadNum";
            this.txtThreadNum.Size = new System.Drawing.Size(28, 21);
            this.txtThreadNum.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "线程数：";
            // 
            // cmbBoxThread
            // 
            this.cmbBoxThread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxThread.FormattingEnabled = true;
            this.cmbBoxThread.Items.AddRange(new object[] {
            "线程01",
            "线程02"});
            this.cmbBoxThread.Location = new System.Drawing.Point(357, 81);
            this.cmbBoxThread.Name = "cmbBoxThread";
            this.cmbBoxThread.Size = new System.Drawing.Size(77, 20);
            this.cmbBoxThread.TabIndex = 20;
            // 
            // prgBar1
            // 
            this.prgBar1.Location = new System.Drawing.Point(75, 184);
            this.prgBar1.Maximum = 10000;
            this.prgBar1.Name = "prgBar1";
            this.prgBar1.Size = new System.Drawing.Size(359, 23);
            this.prgBar1.TabIndex = 19;
            this.prgBar1.Text = "0%";
            this.prgBar1.TextColor = System.Drawing.Color.Black;
            this.prgBar1.TextFont = new System.Drawing.Font("宋体", 9F);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "尝试次数：";
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Location = new System.Drawing.Point(83, 120);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(11, 12);
            this.lbCounter.TabIndex = 17;
            this.lbCounter.Text = "0";
            // 
            // CrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 215);
            this.Controls.Add(this.cmbBoxThread);
            this.Controls.Add(this.prgBar1);
            this.Controls.Add(this.txtThreadNum);
            this.Controls.Add(this.txtDesKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCipherGen);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "暴力破解DES密钥";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrackForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.timerCrackState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.TextBox txtDesKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCipherGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSeconds;
        private System.Timers.Timer timerCrackState;
        private CustomProgressBar prgBar1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ComboBox cmbBoxThread;
        private System.Windows.Forms.TextBox txtThreadNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Label label9;
    }
}