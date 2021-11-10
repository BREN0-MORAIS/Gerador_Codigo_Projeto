namespace Gerador_Codigo.Configuration
{
    public interface IXmlOperation
    {
        bool SaveSetting(string pstrKey, string pstrValue);
        string loadFromConfig(string strKey);
    }
}
