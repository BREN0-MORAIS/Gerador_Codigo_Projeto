namespace View
{
    public interface ISplash
    {
        void ShowInfo(SplashInfo tipo, params object[] args);
    }

    public enum SplashInfo
    {
        Message,
        Error,
        Progress
    }
}
