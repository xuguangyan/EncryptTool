using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using EncryptTool.Common;
using System.Security.Cryptography;

namespace EncryptTool
{
    public partial class MainForm : Form
    {
        //ini配置结点名
        private string iniSession = "DS_EncryptTool";

        private CipherMode cipherMode1 = CipherMode.ECB;
        private CipherMode cipherMode2 = CipherMode.ECB;

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbPaddingMode.SelectedIndex = 1;
            cmbPaddingMode2.SelectedIndex = 1;
        }

        public MainForm()
        {
            InitializeComponent();

            Win32Utility.SetHintText(txtFileCode, "文件Hash值将显示在这里");
            Win32Utility.SetHintText(txtRandCode1, "普通密码");
            Win32Utility.SetHintText(txtRandCode2, "强度密码");
            Win32Utility.SetHintText(txtRandCode3, "随机字母");
            Win32Utility.SetHintText(txtRandCode4, "随机数字");
            Win32Utility.SetHintText(txtRandCode5, "随机ASCII码");

            cmbBoxCharset.SelectedIndex = 0;

            //读取配置文件
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string strFileName = path + "Config.ini";
            IniFiles ini = new IniFiles(strFileName);
            txtPrivateKey.Text = ini.ReadString(iniSession, "privateKey", "");
            txtPublicKey.Text = ini.ReadString(iniSession, "publicKey", "");
            txtPlaintext.Text = ini.ReadString(iniSession, "plaintext", "");
            txtCiphertext.Text = ini.ReadString(iniSession, "ciphertext", "");
            txtName.Text = ini.ReadString(iniSession, "txtName", "");
            txtSigature.Text = ini.ReadString(iniSession, "txtSigature", "");
            txtFileCode.Text = ini.ReadString(iniSession, "fileCode", "");
            cmbBoxCharset.Text = ini.ReadString(iniSession, "charset", "");

            txtPlaintext2.Text = ini.ReadString(iniSession, "plaintext2", "");
            txtCiphertext2.Text = ini.ReadString(iniSession, "ciphertext2", "");
            txtPlaintext3.Text = ini.ReadString(iniSession, "plaintext3", "");
            txtCiphertext3.Text = ini.ReadString(iniSession, "ciphertext3", "");
            txtPlaintext4.Text = ini.ReadString(iniSession, "plaintext4", "");
            txtCiphertext4.Text = ini.ReadString(iniSession, "ciphertext4", "");
            txtPlaintext5.Text = ini.ReadString(iniSession, "plaintext5", "");
            txtCiphertext5.Text = ini.ReadString(iniSession, "ciphertext5", "");
            txtPlaintext6.Text = ini.ReadString(iniSession, "plaintext6", "");
            txtCiphertext6.Text = ini.ReadString(iniSession, "ciphertext6", "");

            txtDesKey.Text = ini.ReadString(iniSession, "desKey", "");
            txtMd5Key.Text = ini.ReadString(iniSession, "md5Key", "");
            txtAesKey.Text = ini.ReadString(iniSession, "aesKey", "");
            txtNum.Text = ini.ReadInteger(iniSession, "txtNum", 6).ToString();
            txtRandCode1.Text = ini.ReadString(iniSession, "randCode1", "");
            txtRandCode2.Text = ini.ReadString(iniSession, "randCode2", "");
            txtRandCode3.Text = ini.ReadString(iniSession, "randCode3", "");
            txtRandCode4.Text = ini.ReadString(iniSession, "randCode4", "");
            txtRandCode5.Text = ini.ReadString(iniSession, "randCode5", "");
        }

        #region RSA加密算法
        

        //生成RSA密钥对
        private void btnGetKey_Click(object sender, EventArgs e)
        {
            string[] sKeys = RSACrypt.GenerateKeys();
            txtPrivateKey.Text = sKeys[0];
            txtPublicKey.Text = sKeys[1];
        }

        //RSA加密
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            txtCiphertext.Text = RSACrypt.EncryptString(txtPlaintext.Text, txtPublicKey.Text);
        }
        //RSA解密
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            txtPlaintext.Text = RSACrypt.DecryptString(txtCiphertext.Text, txtPrivateKey.Text);
        }

        //RSA生成签名
        private void btnGetSign_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            string hashCode="";
            HashCode.GetHash(txtName.Text, ref hashCode);
            txtSigature.Text = RSACrypt.GetSign(hashCode, txtPrivateKey.Text);
        }
        //RSA验证签名
        private void btnVerifySign_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            string hashCode = "";
            HashCode.GetHash(txtName.Text, ref hashCode);
            bool bVerify = RSACrypt.VerifySign(hashCode, txtSigature.Text, txtPublicKey.Text);
            if (bVerify)
            {
                MessageBox.Show("验证通过！");
            }
            else
            {
                MessageBox.Show("验证失败！");
            }
        }

        #endregion

        #region 文件加密（RSA）
        
        //文件加密
        private void btnFileEncode_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            DialogResult dlgResult = openFileDlg.ShowDialog();
            if (DialogResult.OK == dlgResult)
            {
                string srcFile = openFileDlg.FileName;
                string destFile = srcFile + ".m";
                FileCrypt.EncryptOther(srcFile, destFile, txtPublicKey.Text);
                dlgResult = MessageBox.Show("加密成功！是否立即打开密文：" + openFileDlg.SafeFileName + ".m？", "提示", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dlgResult)
                {
                    Process.Start("explorer", "/select, " + destFile);
                }
            }
        }
        //文件解密
        private void btnFileDecode_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            if (txtPrivateKey.Text.Trim() == "" || txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成RSA密钥对！");
                return;
            }
            DialogResult dlgResult = openFileDlg.ShowDialog();
            if (DialogResult.OK == dlgResult)
            {
                string srcFile = openFileDlg.FileName;
                int pos = srcFile.Replace("/", "\\").LastIndexOf("\\");
                string path = srcFile.Substring(0, pos + 1);
                string name = srcFile.Substring(pos + 1);
                string destFile = path + "复本 " + name.Replace(".m", "");
                FileCrypt.DecryptOther(srcFile, destFile, txtPrivateKey.Text);
                dlgResult = MessageBox.Show("解密成功！是否立即打开明文：复本 " + name.Replace(".m", "") + "？", "提示", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dlgResult)
                {
                    Process.Start("explorer", "/select, " + destFile);
                }
            }
        }

        #endregion

        #region DES加密算法
        
        //DES加密
        private void btnEncrypt2_Click(object sender, EventArgs e)
        {
            if (txtDesKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成DESKey密钥！");
                return;
            }
            if (txtDesKey.Text.Length != 8)
            {
                MessageBox.Show("DESKey密钥长度为8位！");
                return;
            }
            if (chkBoxIsIV.Enabled && chkBoxIsIV.Checked && !checkIV(txtIV.Text))
            {
                MessageBox.Show("DES加密向量为8个字节（格式：8个可显ASCII或0x开头的16个HEX符）！");
                return;
            }
            string ivStr = chkBoxIsIV.Enabled && chkBoxIsIV.Checked ? txtIV.Text : "";
            PaddingMode paddingMode1 = cmbPaddingMode.SelectedIndex <= 0 ? PaddingMode.PKCS7 : (PaddingMode)(cmbPaddingMode.SelectedIndex + 1);
            txtCiphertext2.Text = DESCrypt.Encrypt(txtDesKey.Text, txtPlaintext2.Text, ivStr, cipherMode1, paddingMode1);
        }

        //检验向量长度
        private bool checkIV(string iv, int len = 8)
        {
            if (iv.Length == len)
            {
                return true;
            }
            else if (iv.Length == len*2+2 && iv.StartsWith("0x"))
            {
                return true;
            }
            return false;
        }

        //DES解密
        private void btnDecrypt2_Click(object sender, EventArgs e)
        {
            if (txtDesKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成DESKey密钥！");
                return;
            }
            if (txtDesKey.Text.Length != 8)
            {
                MessageBox.Show("DESKey密钥长度为8位！");
                return;
            }
            if (chkBoxIsIV.Enabled && chkBoxIsIV.Checked && !checkIV(txtIV.Text))
            {
                MessageBox.Show("DES加密向量为8个字节（格式：8个可显ASCII或0x开头的16个HEX符）！");
                return;
            }
            string ivStr = chkBoxIsIV.Enabled && chkBoxIsIV.Checked ? txtIV.Text : "";
            PaddingMode paddingMode1 = cmbPaddingMode.SelectedIndex <= 0 ? PaddingMode.PKCS7 : (PaddingMode)(cmbPaddingMode.SelectedIndex + 1);
            txtPlaintext2.Text = DESCrypt.Decrypt(txtDesKey.Text, txtCiphertext2.Text, ivStr, cipherMode1,paddingMode1);
        }

        //获取随机DESKey
        private void btnGetDESKey_Click(object sender, EventArgs e)
        {
            if (txtMd5Key.Text.Length <= 0)
            {
                MessageBox.Show("请输出DesKey");
            }
            txtDesKey.Text = OtherCrypt.GetMd5(txtMd5Key.Text).Substring(0, 8);
        }

        #endregion

        #region AES加密算法
        
        //AES加密
        private void btnEncrypt3_Click(object sender, EventArgs e)
        {
            if (txtAesKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成AESKey密钥！");
                return;
            }
            if (chkBoxIsIV2.Enabled && chkBoxIsIV2.Checked && !checkIV(txtIV2.Text,16))
            {
                MessageBox.Show("AES加密向量为16个字节（格式：16个可显ASCII或0x开头的32个HEX符）！");
                return;
            }
            string ivStr = chkBoxIsIV2.Enabled && chkBoxIsIV2.Checked ? txtIV2.Text : "";
            PaddingMode paddingMode2 = cmbPaddingMode2.SelectedIndex <= 0 ? PaddingMode.PKCS7 : (PaddingMode)(cmbPaddingMode2.SelectedIndex+1);
            txtCiphertext3.Text = AESCrypt.Encrypt(txtAesKey.Text, txtPlaintext3.Text, ivStr, cipherMode2, paddingMode2);
        }
        //AES解密
        private void btnDecrypt3_Click(object sender, EventArgs e)
        {
            if (txtAesKey.Text.Trim() == "")
            {
                MessageBox.Show("请先生成AESKey密钥！");
                return;
            }
            if (chkBoxIsIV2.Enabled && chkBoxIsIV2.Checked && !checkIV(txtIV2.Text,16))
            {
                MessageBox.Show("AES加密向量为16个字节（格式：16个可显ASCII或0x开头的32个HEX符）！");
                return;
            }
            string ivStr = chkBoxIsIV2.Enabled && chkBoxIsIV2.Checked ? txtIV2.Text : "";
            PaddingMode paddingMode2 = cmbPaddingMode2.SelectedIndex <= 0 ? PaddingMode.PKCS7 : (PaddingMode)(cmbPaddingMode2.SelectedIndex + 1);
            txtPlaintext3.Text = AESCrypt.Decrypt(txtAesKey.Text, txtCiphertext3.Text, ivStr, cipherMode2, paddingMode2);
        }

        #endregion

        #region 其他加密算法

        //SHA1加密算法
        private void btnEncrypt4_Click(object sender, EventArgs e)
        {
            txtCiphertext4.Text = OtherCrypt.Get_SHA1(txtPlaintext4.Text);
        }

        //MD5加密算法
        private void btnEncrypt5_Click(object sender, EventArgs e)
        {
            txtCiphertext5.Text = OtherCrypt.GetMd5(txtPlaintext5.Text);
        }

        #endregion

        #region 获取文件hash值

        //获取文件hash值
        private void btnGetHash_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDlg.ShowDialog();
            if (DialogResult.OK == dlgResult)
            {
                FileStream fs = new FileStream(openFileDlg.FileName, FileMode.Open);
                string hashCode = "";
                HashCode.GetHash(fs, ref hashCode);
                if (txtFileCode.Text.Equals(hashCode))
                {
                    MessageBox.Show("生成成功，且与前一个文件Hash值匹配！");
                }
                txtFileCode.Text = hashCode;
            }
        }

        #endregion

        #region 右键功能菜单
        
        //呈现菜单
        private void ctxMenuStrip_Opened(object sender, EventArgs e)
        {
            //获取文档框并设置焦点
            TextBox txtBox = ((TextBox)ctxMenuStrip.SourceControl);
            txtBox.Focus();

            //获取文档框中的文本和选中文本
            string selectText = txtBox.SelectedText;
            string currentText = txtBox.Text;

            if (currentText != "")
            {
                menuItemSelAll.Enabled = true;
            }
            else
            {
                menuItemSelAll.Enabled = false;
            }

            //没有选择文本时，禁用复制、大小写转换菜单
            if (selectText != "")
            {
                menuItemCut.Enabled = true;
                menuItemCopy.Enabled = true;
                menuItemLower.Enabled = true;
                menuItemUpper.Enabled = true;
                menuItemDelete.Enabled = true;
            }
            else
            {
                menuItemCut.Enabled = false;
                menuItemCopy.Enabled = false;
                menuItemLower.Enabled = false;
                menuItemUpper.Enabled = false;
                menuItemDelete.Enabled = false;
            }

            //剪切板没有文本内容时，粘贴菜单禁用
            if (Clipboard.ContainsText())
            {
                menuItemPaste.Enabled = true;
            }
            else 
            {
                menuItemPaste.Enabled = false;
            }
        }

        //全选
        private void menuItemSelAll_Click(object sender, EventArgs e)
        {
            TextBox txtBox = ((TextBox)ctxMenuStrip.SourceControl);
            string text = txtBox.Text;
            txtBox.SelectionStart = 0;
            txtBox.SelectionLength = text.Length;
        }

        //剪切
        private void menuItemCut_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)ctxMenuStrip.SourceControl;
            Clipboard.SetText(txtBox.SelectedText);

            int index = txtBox.SelectionStart;  //记录操作前的光标位置
            string text = txtBox.Text;
            text = text.Remove(txtBox.SelectionStart, txtBox.SelectionLength);
            txtBox.Text = text;
            //重设光标位置
            txtBox.SelectionStart = index;
        }

        //复制
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            TextBox txtBox = ((TextBox)ctxMenuStrip.SourceControl);
            string selectText = txtBox.SelectedText;
            if (selectText != "")
            {
                Clipboard.SetText(selectText);
            }
        }

        //粘贴
        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TextBox txtBox = (TextBox)ctxMenuStrip.SourceControl;
                int index = txtBox.SelectionStart;  //记录操作前的光标位置
                string text = txtBox.Text;
                //删除选中的文本
                text = text.Remove(txtBox.SelectionStart, txtBox.SelectionLength);
                //替换文字
                string repText = Clipboard.GetText();
                //在当前光标输入点插入剪切板内容
                text = text.Insert(txtBox.SelectionStart, repText);
                txtBox.Text = text;
                //重设光标位置
                txtBox.SelectionStart = index + repText.Length;
            }
        }

        //删除
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)ctxMenuStrip.SourceControl;

            int index = txtBox.SelectionStart;  //记录操作前的光标位置
            string text = txtBox.Text;
            text = text.Remove(txtBox.SelectionStart, txtBox.SelectionLength);
            txtBox.Text = text;
            //重设光标位置
            txtBox.SelectionStart = index;
        }

        //转换小写
        private void menuItemLower_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)ctxMenuStrip.SourceControl;
            int index = txtBox.SelectionStart;  //记录操作前的光标位置
            string text = txtBox.Text;
            //删除选中的文本
            text = text.Remove(txtBox.SelectionStart, txtBox.SelectionLength);
            //替换文字
            string repText = txtBox.SelectedText.ToLower();
            //在当前光标输入点插入剪切板内容
            text = text.Insert(txtBox.SelectionStart, repText);
            txtBox.Text = text;
            //重设光标位置
            txtBox.SelectionStart = index;
            txtBox.SelectionLength = repText.Length;
        }

        //转换大写
        private void menuItemUpper_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)ctxMenuStrip.SourceControl;
            int index = txtBox.SelectionStart;  //记录操作前的光标位置
            string text = txtBox.Text;
            //删除选中的文本
            text = text.Remove(txtBox.SelectionStart, txtBox.SelectionLength);
            //替换文字
            string repText = txtBox.SelectedText.ToUpper();
            //在当前光标输入点插入剪切板内容
            text = text.Insert(txtBox.SelectionStart, repText);
            txtBox.Text = text;
            //重设光标位置
            txtBox.SelectionStart = index;
            txtBox.SelectionLength = repText.Length;
        }

        #endregion

        #region 随机生成工具
        
        private void btnRandCode_Click(object sender, EventArgs e)
        {
            int len =Convert.ToInt32(txtNum.Text);
            txtRandCode1.Text = RandUtils.getRandPassword(len);
            txtRandCode2.Text = RandUtils.getRandHardPassword(len);
            txtRandCode3.Text = RandUtils.getRandLetter(len);
            txtRandCode4.Text = RandUtils.getRandNumCode(len);
            txtRandCode5.Text = RandUtils.getRandASCIICode(len);
        }

        #endregion

        #region Base64编码解码

        /*
         * Base64是网络上最常见的用于传输8Bit字节代码的编码方式之一，可用于在HTTP环境下传递较长的标识信息
         * Base64要求把每三个8Bit的字节转换为四个6Bit的字节（3*8 = 4*6 = 24），然后把6Bit再添两位高位0，组成四个8Bit的字节，
         * 也就是说，转换后的字符串理论上将要比原来的长1/3。码表：A-Za-z0-9+/ （末尾用0-2个=号补齐字节为4的倍数）
         */

        //代码页	名称	显示名称
        //---------------------------------
        //65001	    utf-8	Unicode (UTF-8)
        //936		gb2312	简体中文 (GB2312)
        //950		big5	繁体中文 (Big5)
        //20127     us-ascii  US-ASCII
        private void btnEncrypt6_Click(object sender, EventArgs e)
        {
            string charset = cmbBoxCharset.Items[cmbBoxCharset.SelectedIndex].ToString();
            txtCiphertext6.Text = Convert.ToBase64String(Encoding.GetEncoding(charset).GetBytes(txtPlaintext6.Text));
        }

        private void btnDecrypt6_Click(object sender, EventArgs e)
        {
            string charset = cmbBoxCharset.Items[cmbBoxCharset.SelectedIndex].ToString();
            txtPlaintext6.Text = Encoding.GetEncoding(charset).GetString(Convert.FromBase64String(txtCiphertext6.Text));
        }
        #endregion

        #region 暴力破解DES密钥

        private void btnCrackDES_Click(object sender, EventArgs e)
        {
            CrackForm crackForm = new CrackForm();
            crackForm.Show();
        }

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            //写入配置文件
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string strFileName = path + "Config.ini";
            IniFiles ini = new IniFiles(strFileName);

            ini.WriteString(iniSession, "privateKey", txtPrivateKey.Text);
            ini.WriteString(iniSession, "publicKey", txtPublicKey.Text);
            ini.WriteString(iniSession, "plaintext", txtPlaintext.Text);
            ini.WriteString(iniSession, "ciphertext", txtCiphertext.Text);
            ini.WriteString(iniSession, "txtName", txtName.Text);
            ini.WriteString(iniSession, "txtSigature", txtSigature.Text);
            ini.WriteString(iniSession, "fileCode", txtFileCode.Text);
            ini.WriteString(iniSession, "charset", cmbBoxCharset.Text);

            ini.WriteString(iniSession, "plaintext2", txtPlaintext2.Text);
            ini.WriteString(iniSession, "ciphertext2", txtCiphertext2.Text);
            ini.WriteString(iniSession, "plaintext3", txtPlaintext3.Text);
            ini.WriteString(iniSession, "ciphertext3", txtCiphertext3.Text);
            ini.WriteString(iniSession, "plaintext4", txtPlaintext4.Text);
            ini.WriteString(iniSession, "ciphertext4", txtCiphertext4.Text);
            ini.WriteString(iniSession, "plaintext5", txtPlaintext5.Text);
            ini.WriteString(iniSession, "ciphertext5", txtCiphertext5.Text);
            ini.WriteString(iniSession, "plaintext6", txtPlaintext6.Text);
            ini.WriteString(iniSession, "ciphertext6", txtCiphertext6.Text);

            ini.WriteString(iniSession, "desKey", txtDesKey.Text);
            ini.WriteString(iniSession, "md5Key", txtMd5Key.Text);
            ini.WriteString(iniSession, "aesKey", txtAesKey.Text);
            ini.WriteInteger(iniSession, "txtNum", int.Parse(txtNum.Text));
            ini.WriteString(iniSession, "randCode1", txtRandCode1.Text);
            ini.WriteString(iniSession, "randCode2", txtRandCode2.Text);
            ini.WriteString(iniSession, "randCode3", txtRandCode3.Text);
            ini.WriteString(iniSession, "randCode4", txtRandCode4.Text);
            ini.WriteString(iniSession, "randCode5", txtRandCode5.Text);
        }

        #region 加密模式选择

        private void rdBtnECB_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV.Enabled = false;
            txtIV.Enabled = false;
            cipherMode1 = CipherMode.ECB;
        }

        private void rdBtnCBC_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV.Enabled = true;
            txtIV.Enabled = true;
            cipherMode1 = CipherMode.CBC;
        }

        private void rdBtnCFB_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV.Enabled = true;
            txtIV.Enabled = true;
            cipherMode1 = CipherMode.CFB;
        }

        private void rdBtnECB2_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV2.Enabled = false;
            txtIV2.Enabled = false;
            cipherMode2 = CipherMode.ECB;
        }

        private void rdBtnCBC2_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV2.Enabled = true;
            txtIV2.Enabled = true;
            cipherMode2 = CipherMode.CBC;
        }

        private void rdBtnCFB2_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxIsIV2.Enabled = true;
            txtIV2.Enabled = true;
            cipherMode2 = CipherMode.CFB;
        }

        #endregion

    }
}
