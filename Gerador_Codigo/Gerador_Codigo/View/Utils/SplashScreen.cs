public sealed partial class SplashScreen
{
    private void SplashScreenWCO_Load(object sender, System.EventArgs e)
	{
        
       // PicLogo.Image = ImageLib.Properties.Resources.SplashLogin;
        PicLogo.Refresh();
    }
	public SplashScreen()
	{
       InitializeComponent();
    }

    private void PicLogo_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
        this.Close();
    }

 }
