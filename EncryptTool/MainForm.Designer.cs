namespace EncryptTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileCode = new System.Windows.Forms.TextBox();
            this.ctxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLower = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnGetHash = new System.Windows.Forms.Button();
            this.btnFileDecode = new System.Windows.Forms.Button();
            this.btnFileEncode = new System.Windows.Forms.Button();
            this.btnVerifySign = new System.Windows.Forms.Button();
            this.btnGetSign = new System.Windows.Forms.Button();
            this.txtSigature = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetKey = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPaddingMode = new System.Windows.Forms.ComboBox();
            this.rdBtnCFB = new System.Windows.Forms.RadioButton();
            this.rdBtnCBC = new System.Windows.Forms.RadioButton();
            this.rdBtnECB = new System.Windows.Forms.RadioButton();
            this.btnGetDESKey = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtMd5Key = new System.Windows.Forms.TextBox();
            this.txtDesKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypt2 = new System.Windows.Forms.Button();
            this.btnEncrypt2 = new System.Windows.Forms.Button();
            this.txtCiphertext2 = new System.Windows.Forms.TextBox();
            this.txtPlaintext2 = new System.Windows.Forms.TextBox();
            this.chkBoxIsIV = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPaddingMode2 = new System.Windows.Forms.ComboBox();
            this.txtAesKey = new System.Windows.Forms.TextBox();
            this.rdBtnCFB2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdBtnCBC2 = new System.Windows.Forms.RadioButton();
            this.btnDecrypt3 = new System.Windows.Forms.Button();
            this.rdBtnECB2 = new System.Windows.Forms.RadioButton();
            this.btnEncrypt3 = new System.Windows.Forms.Button();
            this.txtCiphertext3 = new System.Windows.Forms.TextBox();
            this.txtIV2 = new System.Windows.Forms.TextBox();
            this.txtPlaintext3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkBoxIsIV2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCiphertext5 = new System.Windows.Forms.TextBox();
            this.txtPlaintext5 = new System.Windows.Forms.TextBox();
            this.btnEncrypt5 = new System.Windows.Forms.Button();
            this.btnEncrypt4 = new System.Windows.Forms.Button();
            this.txtCiphertext4 = new System.Windows.Forms.TextBox();
            this.txtPlaintext4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbBoxCharset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecrypt6 = new System.Windows.Forms.Button();
            this.btnEncrypt6 = new System.Windows.Forms.Button();
            this.txtCiphertext6 = new System.Windows.Forms.TextBox();
            this.txtPlaintext6 = new System.Windows.Forms.TextBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFiledlg = new System.Windows.Forms.SaveFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtRandCode5 = new System.Windows.Forms.TextBox();
            this.txtRandCode4 = new System.Windows.Forms.TextBox();
            this.txtRandCode3 = new System.Windows.Forms.TextBox();
            this.txtRandCode2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRandCode = new System.Windows.Forms.Button();
            this.txtRandCode1 = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCrackDES = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ctxMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileCode);
            this.groupBox1.Controls.Add(this.btnGetHash);
            this.groupBox1.Controls.Add(this.btnFileDecode);
            this.groupBox1.Controls.Add(this.btnFileEncode);
            this.groupBox1.Controls.Add(this.btnVerifySign);
            this.groupBox1.Controls.Add(this.btnGetSign);
            this.groupBox1.Controls.Add(this.txtSigature);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.txtCiphertext);
            this.groupBox1.Controls.Add(this.txtPlaintext);
            this.groupBox1.Controls.Add(this.txtPublicKey);
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA加密算法";
            // 
            // txtFileCode
            // 
            this.txtFileCode.ContextMenuStrip = this.ctxMenuStrip;
            this.txtFileCode.Location = new System.Drawing.Point(310, 250);
            this.txtFileCode.Name = "txtFileCode";
            this.txtFileCode.Size = new System.Drawing.Size(189, 21);
            this.txtFileCode.TabIndex = 18;
            // 
            // ctxMenuStrip
            // 
            this.ctxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelAll,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemPaste,
            this.menuItemDelete,
            this.toolStripSeparator1,
            this.menuItemLower,
            this.menuItemUpper,
            this.stripTextBox});
            this.ctxMenuStrip.Name = "ctxMenuStrip";
            this.ctxMenuStrip.Size = new System.Drawing.Size(161, 182);
            this.ctxMenuStrip.Opened += new System.EventHandler(this.ctxMenuStrip_Opened);
            // 
            // menuItemSelAll
            // 
            this.menuItemSelAll.Name = "menuItemSelAll";
            this.menuItemSelAll.Size = new System.Drawing.Size(160, 22);
            this.menuItemSelAll.Text = "全选(&A)";
            this.menuItemSelAll.Click += new System.EventHandler(this.menuItemSelAll_Click);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.Size = new System.Drawing.Size(160, 22);
            this.menuItemCut.Text = "剪切(&T)";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.Size = new System.Drawing.Size(160, 22);
            this.menuItemCopy.Text = "复制(&C)";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.Size = new System.Drawing.Size(160, 22);
            this.menuItemPaste.Text = "粘贴(&P)";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(160, 22);
            this.menuItemDelete.Text = "删除(&D)";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // menuItemLower
            // 
            this.menuItemLower.Name = "menuItemLower";
            this.menuItemLower.Size = new System.Drawing.Size(160, 22);
            this.menuItemLower.Text = "转为小写(&L)";
            this.menuItemLower.Click += new System.EventHandler(this.menuItemLower_Click);
            // 
            // menuItemUpper
            // 
            this.menuItemUpper.Name = "menuItemUpper";
            this.menuItemUpper.Size = new System.Drawing.Size(160, 22);
            this.menuItemUpper.Text = "转为大写(&U)";
            this.menuItemUpper.Click += new System.EventHandler(this.menuItemUpper_Click);
            // 
            // stripTextBox
            // 
            this.stripTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.stripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stripTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stripTextBox.Name = "stripTextBox";
            this.stripTextBox.ReadOnly = true;
            this.stripTextBox.Size = new System.Drawing.Size(100, 16);
            this.stripTextBox.Text = "[大圣制作@2013]";
            // 
            // btnGetHash
            // 
            this.btnGetHash.Location = new System.Drawing.Point(203, 244);
            this.btnGetHash.Name = "btnGetHash";
            this.btnGetHash.Size = new System.Drawing.Size(90, 30);
            this.btnGetHash.TabIndex = 17;
            this.btnGetHash.Text = "文件Hash值..";
            this.btnGetHash.UseVisualStyleBackColor = true;
            this.btnGetHash.Click += new System.EventHandler(this.btnGetHash_Click);
            // 
            // btnFileDecode
            // 
            this.btnFileDecode.Location = new System.Drawing.Point(106, 244);
            this.btnFileDecode.Name = "btnFileDecode";
            this.btnFileDecode.Size = new System.Drawing.Size(85, 30);
            this.btnFileDecode.TabIndex = 16;
            this.btnFileDecode.Text = "文件解密..";
            this.btnFileDecode.UseVisualStyleBackColor = true;
            this.btnFileDecode.Click += new System.EventHandler(this.btnFileDecode_Click);
            // 
            // btnFileEncode
            // 
            this.btnFileEncode.Location = new System.Drawing.Point(15, 244);
            this.btnFileEncode.Name = "btnFileEncode";
            this.btnFileEncode.Size = new System.Drawing.Size(85, 30);
            this.btnFileEncode.TabIndex = 15;
            this.btnFileEncode.Text = "文件加密..";
            this.btnFileEncode.UseVisualStyleBackColor = true;
            this.btnFileEncode.Click += new System.EventHandler(this.btnFileEncode_Click);
            // 
            // btnVerifySign
            // 
            this.btnVerifySign.Location = new System.Drawing.Point(219, 206);
            this.btnVerifySign.Name = "btnVerifySign";
            this.btnVerifySign.Size = new System.Drawing.Size(75, 32);
            this.btnVerifySign.TabIndex = 12;
            this.btnVerifySign.Text = "<< 验 证";
            this.btnVerifySign.UseVisualStyleBackColor = true;
            this.btnVerifySign.Click += new System.EventHandler(this.btnVerifySign_Click);
            // 
            // btnGetSign
            // 
            this.btnGetSign.Location = new System.Drawing.Point(219, 163);
            this.btnGetSign.Name = "btnGetSign";
            this.btnGetSign.Size = new System.Drawing.Size(75, 37);
            this.btnGetSign.TabIndex = 11;
            this.btnGetSign.Text = "签 名 >>";
            this.btnGetSign.UseVisualStyleBackColor = true;
            this.btnGetSign.Click += new System.EventHandler(this.btnGetSign_Click);
            // 
            // txtSigature
            // 
            this.txtSigature.ContextMenuStrip = this.ctxMenuStrip;
            this.txtSigature.Location = new System.Drawing.Point(311, 165);
            this.txtSigature.Multiline = true;
            this.txtSigature.Name = "txtSigature";
            this.txtSigature.Size = new System.Drawing.Size(189, 73);
            this.txtSigature.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.ContextMenuStrip = this.ctxMenuStrip;
            this.txtName.Location = new System.Drawing.Point(16, 165);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 73);
            this.txtName.TabIndex = 9;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(218, 124);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 32);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "<< 解 密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(218, 81);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 37);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "加 密 >>";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext.Location = new System.Drawing.Point(310, 83);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(189, 73);
            this.txtCiphertext.TabIndex = 6;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext.Location = new System.Drawing.Point(15, 83);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(189, 73);
            this.txtPlaintext.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPublicKey.Location = new System.Drawing.Point(162, 46);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(337, 21);
            this.txtPublicKey.TabIndex = 4;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPrivateKey.Location = new System.Drawing.Point(162, 20);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(337, 21);
            this.txtPrivateKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "公钥：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "私钥：";
            // 
            // btnGetKey
            // 
            this.btnGetKey.Location = new System.Drawing.Point(15, 15);
            this.btnGetKey.Name = "btnGetKey";
            this.btnGetKey.Size = new System.Drawing.Size(85, 57);
            this.btnGetKey.TabIndex = 0;
            this.btnGetKey.Text = "生成公/私钥";
            this.btnGetKey.UseVisualStyleBackColor = true;
            this.btnGetKey.Click += new System.EventHandler(this.btnGetKey_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPaddingMode);
            this.groupBox2.Controls.Add(this.rdBtnCFB);
            this.groupBox2.Controls.Add(this.rdBtnCBC);
            this.groupBox2.Controls.Add(this.rdBtnECB);
            this.groupBox2.Controls.Add(this.btnGetDESKey);
            this.groupBox2.Controls.Add(this.txtIV);
            this.groupBox2.Controls.Add(this.txtMd5Key);
            this.groupBox2.Controls.Add(this.txtDesKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDecrypt2);
            this.groupBox2.Controls.Add(this.btnEncrypt2);
            this.groupBox2.Controls.Add(this.txtCiphertext2);
            this.groupBox2.Controls.Add(this.txtPlaintext2);
            this.groupBox2.Controls.Add(this.chkBoxIsIV);
            this.groupBox2.Location = new System.Drawing.Point(540, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DES加密算法";
            // 
            // cmbPaddingMode
            // 
            this.cmbPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaddingMode.FormattingEnabled = true;
            this.cmbPaddingMode.Items.AddRange(new object[] {
            "==填充模式==",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.cmbPaddingMode.Location = new System.Drawing.Point(408, 50);
            this.cmbPaddingMode.Name = "cmbPaddingMode";
            this.cmbPaddingMode.Size = new System.Drawing.Size(90, 20);
            this.cmbPaddingMode.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cmbPaddingMode, "默认为PKCS7，可对应java中PKCS5");
            // 
            // rdBtnCFB
            // 
            this.rdBtnCFB.AutoSize = true;
            this.rdBtnCFB.Location = new System.Drawing.Point(361, 52);
            this.rdBtnCFB.Name = "rdBtnCFB";
            this.rdBtnCFB.Size = new System.Drawing.Size(41, 16);
            this.rdBtnCFB.TabIndex = 22;
            this.rdBtnCFB.Text = "CFB";
            this.rdBtnCFB.UseVisualStyleBackColor = true;
            this.rdBtnCFB.CheckedChanged += new System.EventHandler(this.rdBtnCFB_CheckedChanged);
            // 
            // rdBtnCBC
            // 
            this.rdBtnCBC.AutoSize = true;
            this.rdBtnCBC.Location = new System.Drawing.Point(315, 52);
            this.rdBtnCBC.Name = "rdBtnCBC";
            this.rdBtnCBC.Size = new System.Drawing.Size(41, 16);
            this.rdBtnCBC.TabIndex = 22;
            this.rdBtnCBC.Text = "CBC";
            this.rdBtnCBC.UseVisualStyleBackColor = true;
            this.rdBtnCBC.CheckedChanged += new System.EventHandler(this.rdBtnCBC_CheckedChanged);
            // 
            // rdBtnECB
            // 
            this.rdBtnECB.AutoSize = true;
            this.rdBtnECB.Checked = true;
            this.rdBtnECB.Location = new System.Drawing.Point(269, 52);
            this.rdBtnECB.Name = "rdBtnECB";
            this.rdBtnECB.Size = new System.Drawing.Size(41, 16);
            this.rdBtnECB.TabIndex = 22;
            this.rdBtnECB.TabStop = true;
            this.rdBtnECB.Text = "ECB";
            this.toolTip1.SetToolTip(this.rdBtnECB, "ECB模块不需要加密向量");
            this.rdBtnECB.UseVisualStyleBackColor = true;
            this.rdBtnECB.CheckedChanged += new System.EventHandler(this.rdBtnECB_CheckedChanged);
            // 
            // btnGetDESKey
            // 
            this.btnGetDESKey.Location = new System.Drawing.Point(219, 20);
            this.btnGetDESKey.Name = "btnGetDESKey";
            this.btnGetDESKey.Size = new System.Drawing.Size(136, 23);
            this.btnGetDESKey.TabIndex = 20;
            this.btnGetDESKey.Text = "<== 由md5生成取前8位";
            this.btnGetDESKey.UseVisualStyleBackColor = true;
            this.btnGetDESKey.Click += new System.EventHandler(this.btnGetDESKey_Click);
            // 
            // txtIV
            // 
            this.txtIV.Enabled = false;
            this.txtIV.Location = new System.Drawing.Point(86, 49);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(105, 21);
            this.txtIV.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtIV, "长度8个字节，格式：8个可显ASCII或0x开头的16个HEX符");
            // 
            // txtMd5Key
            // 
            this.txtMd5Key.Location = new System.Drawing.Point(361, 20);
            this.txtMd5Key.Name = "txtMd5Key";
            this.txtMd5Key.Size = new System.Drawing.Size(138, 21);
            this.txtMd5Key.TabIndex = 14;
            // 
            // txtDesKey
            // 
            this.txtDesKey.ContextMenuStrip = this.ctxMenuStrip;
            this.txtDesKey.Location = new System.Drawing.Point(86, 20);
            this.txtDesKey.Name = "txtDesKey";
            this.txtDesKey.Size = new System.Drawing.Size(105, 21);
            this.txtDesKey.TabIndex = 14;
            this.txtDesKey.Text = "TV93bFZN";
            this.toolTip1.SetToolTip(this.txtDesKey, "ASCII码8位");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "加密模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "DESKey值：";
            // 
            // btnDecrypt2
            // 
            this.btnDecrypt2.Location = new System.Drawing.Point(218, 100);
            this.btnDecrypt2.Name = "btnDecrypt2";
            this.btnDecrypt2.Size = new System.Drawing.Size(75, 28);
            this.btnDecrypt2.TabIndex = 12;
            this.btnDecrypt2.Text = "<< 解 密";
            this.btnDecrypt2.UseVisualStyleBackColor = true;
            this.btnDecrypt2.Click += new System.EventHandler(this.btnDecrypt2_Click);
            // 
            // btnEncrypt2
            // 
            this.btnEncrypt2.Location = new System.Drawing.Point(218, 73);
            this.btnEncrypt2.Name = "btnEncrypt2";
            this.btnEncrypt2.Size = new System.Drawing.Size(75, 28);
            this.btnEncrypt2.TabIndex = 11;
            this.btnEncrypt2.Text = "加 密 >>";
            this.btnEncrypt2.UseVisualStyleBackColor = true;
            this.btnEncrypt2.Click += new System.EventHandler(this.btnEncrypt2_Click);
            // 
            // txtCiphertext2
            // 
            this.txtCiphertext2.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext2.Location = new System.Drawing.Point(311, 74);
            this.txtCiphertext2.Multiline = true;
            this.txtCiphertext2.Name = "txtCiphertext2";
            this.txtCiphertext2.Size = new System.Drawing.Size(189, 55);
            this.txtCiphertext2.TabIndex = 10;
            // 
            // txtPlaintext2
            // 
            this.txtPlaintext2.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext2.Location = new System.Drawing.Point(15, 74);
            this.txtPlaintext2.Multiline = true;
            this.txtPlaintext2.Name = "txtPlaintext2";
            this.txtPlaintext2.Size = new System.Drawing.Size(189, 55);
            this.txtPlaintext2.TabIndex = 9;
            // 
            // chkBoxIsIV
            // 
            this.chkBoxIsIV.AutoSize = true;
            this.chkBoxIsIV.Enabled = false;
            this.chkBoxIsIV.Location = new System.Drawing.Point(8, 53);
            this.chkBoxIsIV.Name = "chkBoxIsIV";
            this.chkBoxIsIV.Size = new System.Drawing.Size(84, 16);
            this.chkBoxIsIV.TabIndex = 21;
            this.chkBoxIsIV.Text = "加密向量：";
            this.chkBoxIsIV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPaddingMode2);
            this.groupBox3.Controls.Add(this.txtAesKey);
            this.groupBox3.Controls.Add(this.rdBtnCFB2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rdBtnCBC2);
            this.groupBox3.Controls.Add(this.btnDecrypt3);
            this.groupBox3.Controls.Add(this.rdBtnECB2);
            this.groupBox3.Controls.Add(this.btnEncrypt3);
            this.groupBox3.Controls.Add(this.txtCiphertext3);
            this.groupBox3.Controls.Add(this.txtIV2);
            this.groupBox3.Controls.Add(this.txtPlaintext3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.chkBoxIsIV2);
            this.groupBox3.Location = new System.Drawing.Point(540, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AES加密算法";
            // 
            // cmbPaddingMode2
            // 
            this.cmbPaddingMode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaddingMode2.FormattingEnabled = true;
            this.cmbPaddingMode2.Items.AddRange(new object[] {
            "==填充模式==",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.cmbPaddingMode2.Location = new System.Drawing.Point(408, 45);
            this.cmbPaddingMode2.Name = "cmbPaddingMode2";
            this.cmbPaddingMode2.Size = new System.Drawing.Size(90, 20);
            this.cmbPaddingMode2.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cmbPaddingMode2, "默认为PKCS7，可对应java中PKCS5");
            // 
            // txtAesKey
            // 
            this.txtAesKey.ContextMenuStrip = this.ctxMenuStrip;
            this.txtAesKey.Location = new System.Drawing.Point(124, 20);
            this.txtAesKey.Name = "txtAesKey";
            this.txtAesKey.Size = new System.Drawing.Size(370, 21);
            this.txtAesKey.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtAesKey, "经过md5一次后的才是真正的key");
            // 
            // rdBtnCFB2
            // 
            this.rdBtnCFB2.AutoSize = true;
            this.rdBtnCFB2.Location = new System.Drawing.Point(361, 47);
            this.rdBtnCFB2.Name = "rdBtnCFB2";
            this.rdBtnCFB2.Size = new System.Drawing.Size(41, 16);
            this.rdBtnCFB2.TabIndex = 22;
            this.rdBtnCFB2.Text = "CFB";
            this.rdBtnCFB2.UseVisualStyleBackColor = true;
            this.rdBtnCFB2.CheckedChanged += new System.EventHandler(this.rdBtnCFB2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "AESKey值(密钥)：";
            // 
            // rdBtnCBC2
            // 
            this.rdBtnCBC2.AutoSize = true;
            this.rdBtnCBC2.Location = new System.Drawing.Point(315, 47);
            this.rdBtnCBC2.Name = "rdBtnCBC2";
            this.rdBtnCBC2.Size = new System.Drawing.Size(41, 16);
            this.rdBtnCBC2.TabIndex = 22;
            this.rdBtnCBC2.Text = "CBC";
            this.rdBtnCBC2.UseVisualStyleBackColor = true;
            this.rdBtnCBC2.CheckedChanged += new System.EventHandler(this.rdBtnCBC2_CheckedChanged);
            // 
            // btnDecrypt3
            // 
            this.btnDecrypt3.Location = new System.Drawing.Point(218, 98);
            this.btnDecrypt3.Name = "btnDecrypt3";
            this.btnDecrypt3.Size = new System.Drawing.Size(75, 28);
            this.btnDecrypt3.TabIndex = 16;
            this.btnDecrypt3.Text = "<< 解 密";
            this.btnDecrypt3.UseVisualStyleBackColor = true;
            this.btnDecrypt3.Click += new System.EventHandler(this.btnDecrypt3_Click);
            // 
            // rdBtnECB2
            // 
            this.rdBtnECB2.AutoSize = true;
            this.rdBtnECB2.Checked = true;
            this.rdBtnECB2.Location = new System.Drawing.Point(269, 47);
            this.rdBtnECB2.Name = "rdBtnECB2";
            this.rdBtnECB2.Size = new System.Drawing.Size(41, 16);
            this.rdBtnECB2.TabIndex = 22;
            this.rdBtnECB2.TabStop = true;
            this.rdBtnECB2.Text = "ECB";
            this.toolTip1.SetToolTip(this.rdBtnECB2, "ECB模块不需要加密向量");
            this.rdBtnECB2.UseVisualStyleBackColor = true;
            this.rdBtnECB2.CheckedChanged += new System.EventHandler(this.rdBtnECB2_CheckedChanged);
            // 
            // btnEncrypt3
            // 
            this.btnEncrypt3.Location = new System.Drawing.Point(218, 71);
            this.btnEncrypt3.Name = "btnEncrypt3";
            this.btnEncrypt3.Size = new System.Drawing.Size(75, 28);
            this.btnEncrypt3.TabIndex = 15;
            this.btnEncrypt3.Text = "加 密 >>";
            this.btnEncrypt3.UseVisualStyleBackColor = true;
            this.btnEncrypt3.Click += new System.EventHandler(this.btnEncrypt3_Click);
            // 
            // txtCiphertext3
            // 
            this.txtCiphertext3.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext3.Location = new System.Drawing.Point(310, 71);
            this.txtCiphertext3.Multiline = true;
            this.txtCiphertext3.Name = "txtCiphertext3";
            this.txtCiphertext3.Size = new System.Drawing.Size(189, 55);
            this.txtCiphertext3.TabIndex = 14;
            // 
            // txtIV2
            // 
            this.txtIV2.Enabled = false;
            this.txtIV2.Location = new System.Drawing.Point(86, 45);
            this.txtIV2.Name = "txtIV2";
            this.txtIV2.Size = new System.Drawing.Size(105, 21);
            this.txtIV2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtIV2, "长度16个字节，格式：16个可显ASCII或0x开头的32个HEX符");
            // 
            // txtPlaintext3
            // 
            this.txtPlaintext3.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext3.Location = new System.Drawing.Point(15, 71);
            this.txtPlaintext3.Multiline = true;
            this.txtPlaintext3.Name = "txtPlaintext3";
            this.txtPlaintext3.Size = new System.Drawing.Size(189, 55);
            this.txtPlaintext3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "加密模式：";
            // 
            // chkBoxIsIV2
            // 
            this.chkBoxIsIV2.AutoSize = true;
            this.chkBoxIsIV2.Enabled = false;
            this.chkBoxIsIV2.Location = new System.Drawing.Point(8, 50);
            this.chkBoxIsIV2.Name = "chkBoxIsIV2";
            this.chkBoxIsIV2.Size = new System.Drawing.Size(84, 16);
            this.chkBoxIsIV2.TabIndex = 22;
            this.chkBoxIsIV2.Text = "加密向量：";
            this.chkBoxIsIV2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCiphertext5);
            this.groupBox4.Controls.Add(this.txtPlaintext5);
            this.groupBox4.Controls.Add(this.btnEncrypt5);
            this.groupBox4.Controls.Add(this.btnEncrypt4);
            this.groupBox4.Controls.Add(this.txtCiphertext4);
            this.groupBox4.Controls.Add(this.txtPlaintext4);
            this.groupBox4.Location = new System.Drawing.Point(540, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "其他加密算法";
            // 
            // txtCiphertext5
            // 
            this.txtCiphertext5.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext5.Location = new System.Drawing.Point(311, 47);
            this.txtCiphertext5.Name = "txtCiphertext5";
            this.txtCiphertext5.Size = new System.Drawing.Size(189, 21);
            this.txtCiphertext5.TabIndex = 18;
            // 
            // txtPlaintext5
            // 
            this.txtPlaintext5.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext5.Location = new System.Drawing.Point(15, 47);
            this.txtPlaintext5.Name = "txtPlaintext5";
            this.txtPlaintext5.Size = new System.Drawing.Size(189, 21);
            this.txtPlaintext5.TabIndex = 17;
            // 
            // btnEncrypt5
            // 
            this.btnEncrypt5.Location = new System.Drawing.Point(219, 43);
            this.btnEncrypt5.Name = "btnEncrypt5";
            this.btnEncrypt5.Size = new System.Drawing.Size(75, 30);
            this.btnEncrypt5.TabIndex = 16;
            this.btnEncrypt5.Text = "MD5加密 >>";
            this.btnEncrypt5.UseVisualStyleBackColor = true;
            this.btnEncrypt5.Click += new System.EventHandler(this.btnEncrypt5_Click);
            // 
            // btnEncrypt4
            // 
            this.btnEncrypt4.Location = new System.Drawing.Point(219, 13);
            this.btnEncrypt4.Name = "btnEncrypt4";
            this.btnEncrypt4.Size = new System.Drawing.Size(75, 30);
            this.btnEncrypt4.TabIndex = 15;
            this.btnEncrypt4.Text = "SHA1加密>>";
            this.btnEncrypt4.UseVisualStyleBackColor = true;
            this.btnEncrypt4.Click += new System.EventHandler(this.btnEncrypt4_Click);
            // 
            // txtCiphertext4
            // 
            this.txtCiphertext4.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext4.Location = new System.Drawing.Point(311, 19);
            this.txtCiphertext4.Name = "txtCiphertext4";
            this.txtCiphertext4.Size = new System.Drawing.Size(189, 21);
            this.txtCiphertext4.TabIndex = 14;
            // 
            // txtPlaintext4
            // 
            this.txtPlaintext4.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext4.Location = new System.Drawing.Point(16, 19);
            this.txtPlaintext4.Name = "txtPlaintext4";
            this.txtPlaintext4.Size = new System.Drawing.Size(189, 21);
            this.txtPlaintext4.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbBoxCharset);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnDecrypt6);
            this.groupBox5.Controls.Add(this.btnEncrypt6);
            this.groupBox5.Controls.Add(this.txtCiphertext6);
            this.groupBox5.Controls.Add(this.txtPlaintext6);
            this.groupBox5.Location = new System.Drawing.Point(12, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 76);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Base64编码转换";
            // 
            // cmbBoxCharset
            // 
            this.cmbBoxCharset.FormattingEnabled = true;
            this.cmbBoxCharset.Items.AddRange(new object[] {
            "utf-8",
            "gb2312",
            "big5",
            "us-ascii"});
            this.cmbBoxCharset.Location = new System.Drawing.Point(236, 14);
            this.cmbBoxCharset.Name = "cmbBoxCharset";
            this.cmbBoxCharset.Size = new System.Drawing.Size(69, 20);
            this.cmbBoxCharset.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "选用编码：";
            // 
            // btnDecrypt6
            // 
            this.btnDecrypt6.Location = new System.Drawing.Point(178, 38);
            this.btnDecrypt6.Name = "btnDecrypt6";
            this.btnDecrypt6.Size = new System.Drawing.Size(65, 30);
            this.btnDecrypt6.TabIndex = 20;
            this.btnDecrypt6.Text = "<< 解码";
            this.btnDecrypt6.UseVisualStyleBackColor = true;
            this.btnDecrypt6.Click += new System.EventHandler(this.btnDecrypt6_Click);
            // 
            // btnEncrypt6
            // 
            this.btnEncrypt6.Location = new System.Drawing.Point(245, 38);
            this.btnEncrypt6.Name = "btnEncrypt6";
            this.btnEncrypt6.Size = new System.Drawing.Size(63, 30);
            this.btnEncrypt6.TabIndex = 19;
            this.btnEncrypt6.Text = "编码 >>";
            this.btnEncrypt6.UseVisualStyleBackColor = true;
            this.btnEncrypt6.Click += new System.EventHandler(this.btnEncrypt6_Click);
            // 
            // txtCiphertext6
            // 
            this.txtCiphertext6.ContextMenuStrip = this.ctxMenuStrip;
            this.txtCiphertext6.Location = new System.Drawing.Point(311, 14);
            this.txtCiphertext6.Multiline = true;
            this.txtCiphertext6.Name = "txtCiphertext6";
            this.txtCiphertext6.Size = new System.Drawing.Size(189, 54);
            this.txtCiphertext6.TabIndex = 18;
            // 
            // txtPlaintext6
            // 
            this.txtPlaintext6.ContextMenuStrip = this.ctxMenuStrip;
            this.txtPlaintext6.Location = new System.Drawing.Point(16, 14);
            this.txtPlaintext6.Multiline = true;
            this.txtPlaintext6.Name = "txtPlaintext6";
            this.txtPlaintext6.Size = new System.Drawing.Size(160, 54);
            this.txtPlaintext6.TabIndex = 17;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtRandCode5);
            this.groupBox6.Controls.Add(this.txtRandCode4);
            this.groupBox6.Controls.Add(this.txtRandCode3);
            this.groupBox6.Controls.Add(this.txtRandCode2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.btnRandCode);
            this.groupBox6.Controls.Add(this.txtRandCode1);
            this.groupBox6.Controls.Add(this.txtNum);
            this.groupBox6.Location = new System.Drawing.Point(12, 384);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(647, 57);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "随机生成工具";
            // 
            // txtRandCode5
            // 
            this.txtRandCode5.ContextMenuStrip = this.ctxMenuStrip;
            this.txtRandCode5.Location = new System.Drawing.Point(551, 24);
            this.txtRandCode5.Name = "txtRandCode5";
            this.txtRandCode5.Size = new System.Drawing.Size(81, 21);
            this.txtRandCode5.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtRandCode5, "随机ASCII码（95个可显字符）");
            // 
            // txtRandCode4
            // 
            this.txtRandCode4.ContextMenuStrip = this.ctxMenuStrip;
            this.txtRandCode4.Location = new System.Drawing.Point(464, 24);
            this.txtRandCode4.Name = "txtRandCode4";
            this.txtRandCode4.Size = new System.Drawing.Size(81, 21);
            this.txtRandCode4.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtRandCode4, "随机数字");
            // 
            // txtRandCode3
            // 
            this.txtRandCode3.ContextMenuStrip = this.ctxMenuStrip;
            this.txtRandCode3.Location = new System.Drawing.Point(377, 24);
            this.txtRandCode3.Name = "txtRandCode3";
            this.txtRandCode3.Size = new System.Drawing.Size(81, 21);
            this.txtRandCode3.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtRandCode3, "随机字母（含大小写）");
            // 
            // txtRandCode2
            // 
            this.txtRandCode2.ContextMenuStrip = this.ctxMenuStrip;
            this.txtRandCode2.Location = new System.Drawing.Point(290, 24);
            this.txtRandCode2.Name = "txtRandCode2";
            this.txtRandCode2.Size = new System.Drawing.Size(81, 21);
            this.txtRandCode2.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtRandCode2, "强度密码（必含字母数字特殊符,长度6位以上）");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "随机代码：";
            // 
            // btnRandCode
            // 
            this.btnRandCode.Location = new System.Drawing.Point(133, 18);
            this.btnRandCode.Name = "btnRandCode";
            this.btnRandCode.Size = new System.Drawing.Size(54, 30);
            this.btnRandCode.TabIndex = 15;
            this.btnRandCode.Text = "生成>>";
            this.btnRandCode.UseVisualStyleBackColor = true;
            this.btnRandCode.Click += new System.EventHandler(this.btnRandCode_Click);
            // 
            // txtRandCode1
            // 
            this.txtRandCode1.ContextMenuStrip = this.ctxMenuStrip;
            this.txtRandCode1.Location = new System.Drawing.Point(203, 24);
            this.txtRandCode1.Name = "txtRandCode1";
            this.txtRandCode1.Size = new System.Drawing.Size(81, 21);
            this.txtRandCode1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtRandCode1, "普通密码码（含字母数字特殊符）");
            // 
            // txtNum
            // 
            this.txtNum.ContextMenuStrip = this.ctxMenuStrip;
            this.txtNum.Location = new System.Drawing.Point(77, 24);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(23, 21);
            this.txtNum.TabIndex = 13;
            this.txtNum.Text = "6";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCrackDES);
            this.groupBox7.Location = new System.Drawing.Point(665, 384);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(391, 57);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "其他工具";
            // 
            // btnCrackDES
            // 
            this.btnCrackDES.Location = new System.Drawing.Point(15, 19);
            this.btnCrackDES.Name = "btnCrackDES";
            this.btnCrackDES.Size = new System.Drawing.Size(120, 30);
            this.btnCrackDES.TabIndex = 16;
            this.btnCrackDES.Text = "暴力破解DES密钥";
            this.btnCrackDES.UseVisualStyleBackColor = true;
            this.btnCrackDES.Click += new System.EventHandler(this.btnCrackDES_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 453);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密工具集合(大圣制作)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctxMenuStrip.ResumeLayout(false);
            this.ctxMenuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDecrypt2;
        private System.Windows.Forms.Button btnEncrypt2;
        private System.Windows.Forms.TextBox txtCiphertext2;
        private System.Windows.Forms.TextBox txtPlaintext2;
        private System.Windows.Forms.TextBox txtDesKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDecrypt3;
        private System.Windows.Forms.Button btnEncrypt3;
        private System.Windows.Forms.TextBox txtCiphertext3;
        private System.Windows.Forms.TextBox txtPlaintext3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEncrypt5;
        private System.Windows.Forms.Button btnEncrypt4;
        private System.Windows.Forms.TextBox txtCiphertext4;
        private System.Windows.Forms.TextBox txtPlaintext4;
        private System.Windows.Forms.Button btnVerifySign;
        private System.Windows.Forms.Button btnGetSign;
        private System.Windows.Forms.TextBox txtSigature;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button btnFileDecode;
        private System.Windows.Forms.Button btnFileEncode;
        private System.Windows.Forms.SaveFileDialog saveFiledlg;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemLower;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpper;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripTextBox stripTextBox;
        private System.Windows.Forms.TextBox txtCiphertext5;
        private System.Windows.Forms.TextBox txtPlaintext5;
        private System.Windows.Forms.TextBox txtAesKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetDESKey;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRandCode;
        private System.Windows.Forms.TextBox txtRandCode1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtRandCode5;
        private System.Windows.Forms.TextBox txtRandCode4;
        private System.Windows.Forms.TextBox txtRandCode3;
        private System.Windows.Forms.TextBox txtRandCode2;
        private System.Windows.Forms.TextBox txtFileCode;
        private System.Windows.Forms.Button btnGetHash;
        private System.Windows.Forms.Button btnDecrypt6;
        private System.Windows.Forms.Button btnEncrypt6;
        private System.Windows.Forms.TextBox txtCiphertext6;
        private System.Windows.Forms.TextBox txtPlaintext6;
        private System.Windows.Forms.TextBox txtMd5Key;
        private System.Windows.Forms.CheckBox chkBoxIsIV;
        private System.Windows.Forms.CheckBox chkBoxIsIV2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnCrackDES;
        private System.Windows.Forms.ComboBox cmbBoxCharset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdBtnCFB;
        private System.Windows.Forms.RadioButton rdBtnCBC;
        private System.Windows.Forms.RadioButton rdBtnECB;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBtnCFB2;
        private System.Windows.Forms.RadioButton rdBtnCBC2;
        private System.Windows.Forms.RadioButton rdBtnECB2;
        private System.Windows.Forms.TextBox txtIV2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPaddingMode;
        private System.Windows.Forms.ComboBox cmbPaddingMode2;
    }
}

