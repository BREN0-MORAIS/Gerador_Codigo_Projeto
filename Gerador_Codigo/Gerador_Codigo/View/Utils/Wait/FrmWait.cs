using System.Windows.Forms;

namespace View
{
    public partial class FrmWait : Form, ISplash
    {
        public FrmWait()
        {
            InitializeComponent();
        }

        public void ShowInfo(SplashInfo tipo, params object[] args)
        {
            switch (tipo)
            {
                case SplashInfo.Message:
                    lblMessage.Text = args[0].ToString();
                    break;

                case SplashInfo.Error:
                    break;

                case SplashInfo.Progress:
                    break;

                default:
                    throw new System.ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }
        }
    }
}
