using EncryptTool.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EncryptTool
{
    public partial class CrackForm : Form
    {
        //ini配置结点名
        private string iniSession = "DS_EncryptTool";

        //总耗时（毫秒）
        private long milliseconds = 0;
        private int prgValue = 0;
        private Thread thrCrackDES;
        private string plaintext;
        private string ciphertext;
        private string cipherGen;
        private string desKey;
        private uint total = 0xffffffff; //4294967295;
        private uint counter = 0;
        private bool isPaused = false;
        private int threadNum = 1;

        public CrackForm()
        {
            InitializeComponent();

            //读取配置文件
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string strFileName = path + "Config.ini";
            IniFiles ini = new IniFiles(strFileName);
            //默认写日志
            ConfigHelper.WriteLog = true;

            txtPlaintext.Text = ini.ReadString(iniSession, "cf_plaintext", "");
            txtCiphertext.Text = ini.ReadString(iniSession, "cf_ciphertext", "");
            txtCipherGen.Text = ini.ReadString(iniSession, "cf_cipherGen", "");
            txtDesKey.Text = ini.ReadString(iniSession, "cf_desKey", "");
            txtThreadNum.Text = ini.ReadInteger(iniSession, "cf_threadNum", 1).ToString();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            plaintext = txtPlaintext.Text;
            ciphertext = txtCiphertext.Text;
            if (plaintext.Length <= 0 || ciphertext.Length <= 0)
            {
                MessageBox.Show("请填写完整样例数据！");
                return;
            }

            if (txtThreadNum.Text.Length <= 0)
            {
                MessageBox.Show("请填写开启线程的数量！");
                return;
            }

            try
            {
                threadNum = int.Parse(txtThreadNum.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("线程数量为整数且不超过10！");
                Console.WriteLine(ex.Message);
                return;
            }

            if (threadNum<=0 && threadNum > 10)
            {
                MessageBox.Show("线程数量为整数且不超过10！");
                return;
            }

            cmbBoxThread.Items.Clear();
            for (int i = 0; i < threadNum; i++)
            {
                cmbBoxThread.Items.Add("线程" + i);
            }

            //重新破解
            counter = 0;
            prgValue = 0;
            milliseconds = 0;
            lbCounter.Text = "0";
            timerCrackState.Start();
            thrCrackDES = new Thread(new ThreadStart(crackDES));
            thrCrackDES.Start();
            txtPlaintext.Enabled = false;
            txtCiphertext.Enabled = false;
            txtThreadNum.Enabled = false;
            btnCrack.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            LogHelper.Log(string.Format("开始新任务，明文样例：{0}，密文样例：{1}", plaintext, ciphertext));
        }

        private void crackDES()
        {
            do
            {
                if (counter > total)
                {
                    timerCrackState.Stop();
                    InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
                    InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);

                    MessageBox.Show("任务结束，未找到密钥！");
                    InvokeCtrl.UpdateCtrlEnabled(btnCrack, true);
                    InvokeCtrl.UpdateCtrlEnabled(btnPause, false);
                    InvokeCtrl.UpdateCtrlEnabled(btnStop, false);
                    InvokeCtrl.UpdateCtrlEnabled(txtPlaintext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtCiphertext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtThreadNum, true);
                    LogHelper.Log(string.Format("任务结束，用时[{0}]，未找到密钥！", InvokeCtrl.GetCtrlText(lbSeconds)));
                    break;
                }
                
                /*
                 * 1、假设密钥由md5生成（即字符范围[0-9A-F]），那么8位的密钥范围可以看作0x00000000-0xFFFFFFFF
                 * 2、假设md5生成字符统一大写或小写，那么需要考虑切换大小写再加密
                 * 2、假设加密向量与密钥相同（否则计算量超出本算法范围。。）
                 */
                desKey = counter.ToString("x8");

                counter++;
                prgValue = Convert.ToInt32(10000 * counter / total);
                //InvokeCtrl.UpdateCtrlText(lbCounter, counter.ToString());

                //InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
                cipherGen = DESCrypt.Encrypt(desKey, plaintext, desKey);
                //InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);

                if (cipherGen.Equals(ciphertext))
                {
                    timerCrackState.Stop();
                    InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
                    InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);

                    MessageBox.Show("恭喜你，找到密钥：" + cipherGen);
                    InvokeCtrl.UpdateCtrlEnabled(btnCrack, true);
                    InvokeCtrl.UpdateCtrlEnabled(btnPause, false);
                    InvokeCtrl.UpdateCtrlEnabled(btnStop, false);
                    InvokeCtrl.UpdateCtrlEnabled(txtPlaintext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtCiphertext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtThreadNum, true);
                    LogHelper.Log(string.Format("在进度[{0}]处，用时[{1}]，找到密钥：{2}", InvokeCtrl.GetCtrlText(prgBar1), InvokeCtrl.GetCtrlText(lbSeconds), cipherGen));
                    break;
                }

                string desKeyUpcase = desKey.ToUpper();
                if (desKeyUpcase.Equals(desKey))
                {
                    continue;
                }
                desKey = desKeyUpcase;

                //InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
                cipherGen = DESCrypt.Encrypt(desKey, plaintext, desKey);
                //InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);

                if (cipherGen.Equals(ciphertext))
                {
                    timerCrackState.Stop();
                    InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
                    InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);

                    MessageBox.Show("恭喜你，找到密钥：" + cipherGen);
                    InvokeCtrl.UpdateCtrlEnabled(btnCrack, true);
                    InvokeCtrl.UpdateCtrlEnabled(btnPause, false);
                    InvokeCtrl.UpdateCtrlEnabled(btnStop, false);
                    InvokeCtrl.UpdateCtrlEnabled(txtPlaintext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtCiphertext, true);
                    InvokeCtrl.UpdateCtrlEnabled(txtThreadNum, true);
                    LogHelper.Log(string.Format("在进度[{0}]处，用时[{1}]，找到密钥：{2}", InvokeCtrl.GetCtrlText(prgBar1), InvokeCtrl.GetCtrlText(lbSeconds), cipherGen));
                    break;
                }

            } while (true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                timerCrackState.Stop();
                if (thrCrackDES != null)
                {
                    thrCrackDES.Abort();
                }
                btnPause.Text = "继续";
            }
            else
            {
                timerCrackState.Start();
                thrCrackDES = new Thread(new ThreadStart(crackDES));
                thrCrackDES.Start();

                btnPause.Text = "暂停";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCrackState.Stop();
            if (thrCrackDES != null)
            {
                thrCrackDES.Abort();
            }
            isPaused = false;
            btnPause.Text = "暂停";

            txtPlaintext.Enabled = true;
            txtCiphertext.Enabled = true;
            txtThreadNum.Enabled = true;
            btnCrack.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            LogHelper.Log(string.Format("任务被强行结束"));
        }

        private string Hex2String(byte[] bytes)
        {
            StringBuilder hexBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                hexBuilder.Append(b.ToString("X"));
            }
            return hexBuilder.ToString();
        }

        private void CrackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //写入配置文件
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string strFileName = path + "Config.ini";
            IniFiles ini = new IniFiles(strFileName);

            ini.WriteString(iniSession, "cf_plaintext", txtPlaintext.Text);
            ini.WriteString(iniSession, "cf_ciphertext", txtCiphertext.Text);
            ini.WriteString(iniSession, "cf_cipherGen", txtCipherGen.Text);
            ini.WriteString(iniSession, "cf_desKey", txtDesKey.Text);
            ini.WriteString(iniSession, "cf_threadNum", txtThreadNum.Text);

            if (thrCrackDES != null)
            {
                thrCrackDES.Abort();
            }
        }
        /// <summary>
        /// 获取耗费时间
        /// </summary>
        /// <param name="milliseconds">毫秒数</param>
        /// <returns></returns>
        private string getUseTime(long milliseconds)
        {
            int hour = (int)Math.Floor(1.0 * milliseconds / 3600000);
            int minute = (int)Math.Floor(1.0 * (milliseconds - hour * 3600000) / 60000);
            int second = (int)Math.Floor(1.0 * (milliseconds - hour * 3600000 - minute * 60000) / 1000);
            int millisecond = (int)(milliseconds - hour * 3600000 - minute * 60000 - second * 1000);
            string strTime = string.Format("{0:D2}时 {1:D2}分 {2:D2}秒 {3:D1}", hour, minute, second, millisecond / 100);
            return strTime;
        }

        private void timerCrackState_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateState();
        }

        private void updateState()
        {
            milliseconds += 100;
            lbSeconds.Text = getUseTime(milliseconds);
            InvokeCtrl.UpdatePrgBarValue(prgBar1, prgValue, Color.FromKnownColor(KnownColor.Highlight), string.Format("{0}%", prgValue / 100));
            InvokeCtrl.UpdateCtrlText(lbCounter, counter.ToString());
            InvokeCtrl.UpdateCtrlText(txtDesKey, desKey);
            InvokeCtrl.UpdateCtrlText(txtCipherGen, cipherGen);
        }

    }
}
