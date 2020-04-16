using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SheepSmartCardSampleCs
{

    public partial class Form1 : Form
    {
        [DllImport("SheepSmartCard64.dll", EntryPoint = "GetSmartCardUID")]
        extern static int GetSmartCardUID64(byte[] SCardIDm);

        [DllImport("SheepSmartCard32.dll", EntryPoint = "GetSmartCardUID")]
        extern static int GetSmartCardUID32(byte[] SCardIDm);

        public Form1()
        {
            InitializeComponent();
        }

        delegate int CallDllDelegate(byte[] SCardIDm);

        private void btnReadIDm_Click(object sender, EventArgs e)
        {
            CallDllDelegate GetSmartCardIDm;
            if (Environment.Is64BitProcess)
            {
                GetSmartCardIDm = GetSmartCardUID64;
            }
            else
            {
                GetSmartCardIDm = GetSmartCardUID32;
            }

            this.txtSCardIDm.Text = "";
            this.txtErrMsg.Text = "";

            var bRecvBuffer = new byte[128];
            var ret = GetSmartCardIDm(bRecvBuffer);
            var idm = Encoding.ASCII.GetString(bRecvBuffer).TrimEnd('\0');

            switch (ret)
            {
                case 0:
                    this.txtSCardIDm.Text = idm;
                    break;
                case 100:
                    this.txtErrMsg.Text = "No card detected, or the card is unreadable.";
                    break;
                case 200:
                    this.txtErrMsg.Text = "A smart card reader is not detected." + Environment.NewLine
                        + "Please confirm it is connected to this pc.";
                    break;
                case 300:
                    this.txtErrMsg.Text = "The smart card service is not running" + Environment.NewLine
                        + "or it is not installed.";
                    break;
                case 400:
                    this.txtErrMsg.Text = "Failed to get the card UID.";
                    break;
                default:
                    this.txtErrMsg.Text = "An unexpected error has occurred";
                    break;
            }

        }
    }
}
