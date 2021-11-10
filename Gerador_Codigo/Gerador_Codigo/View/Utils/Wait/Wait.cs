namespace View
{
    public static class Wait
    {
        public static void OpenLoad(SplashInfo info, string message)
        {
            SplashScreenManager.Show<FrmWait>();
            SplashScreenManager.Default.ShowInfo(info, message);
        }


        public static void CloseLoad()
        {
            SplashScreenManager.Close();
        }

        public static void OpenLoadSelect(SplashInfo info, string message)
        {
            SplashScreenManager.Show<FrmWaitSelect>();
            SplashScreenManager.Default.ShowInfo(info, message);
        }


        public static void CloseLoadSelect()
        {
            SplashScreenManager.Close();
        }
    }
}
