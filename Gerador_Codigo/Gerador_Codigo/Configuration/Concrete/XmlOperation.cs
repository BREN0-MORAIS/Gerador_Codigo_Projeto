
using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Gerador_Codigo.Configuration
{
    public class XmlOperation : IXmlOperation
    {
        private XmlDocument _xmlDoc = new XmlDocument();
       // private string _arquivo = "GEOCID.exe";
        private string _arquivo = "Gerador de Codigo.exe";

        // Edielson - 16/03/2020
        #region Metodo para gravar no arquivo XML
        public bool SaveSetting(string pstrKey, string pstrValue)
        {
            System.Configuration.Configuration objConfigFile = ConfigurationManager.
                        OpenExeConfiguration(AppDomain.CurrentDomain.BaseDirectory + _arquivo);
            bool blnKeyExists = false;

            // Percorre os nós do xml e salva as informações na chave informada.
            foreach (string strKey in objConfigFile.AppSettings.Settings.AllKeys)
            {
                if (strKey == pstrKey)
                {
                    blnKeyExists = true;
                    objConfigFile.AppSettings.Settings[pstrKey].Value = pstrValue;
                    break;

                }
            }
            if (!blnKeyExists)
            {
                objConfigFile.AppSettings.Settings.Add(pstrKey, pstrValue);
            }
            //Salva as informações.
            objConfigFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return true;
        }
        #endregion

        // Edielson - 16/03/2020
        #region Metodo para carregar a informação contida em chave dentro de um arquivo XML
        public string loadFromConfig(string strKey)
        {
            _xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + _arquivo+ ".config");
            XmlNode appSettingsNode = _xmlDoc.SelectSingleNode("configuration/appSettings");
            string valueStr = "";

            //Percorre o xml e carrega as informações da chave informada.
            foreach (XmlNode node in appSettingsNode.ChildNodes)
            {
                if (node.Attributes["key"].Value == strKey)
                    valueStr = node.Attributes["value"].Value.ToString();
            }
            return valueStr;
        }
        #endregion
    }
}
