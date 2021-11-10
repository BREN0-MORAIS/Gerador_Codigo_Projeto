using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace View
{
    public  class GenerateFileExportText
    {
        private static string _path;

        #region Método responsável por [EXPORTAR OS ARQUIVOS E FORMATA-LO]
        public static  void GenerateFile<T>(IList<T> query)
        {
            var lista = GetFormatTxt(query);

            if (lista is null) return;

            using (var result = new SaveFileDialog())
            {
                result.Filter = "Arquivo Texto (*.txt)|*.txt|Arquivo CSV (*.csv)|*.csv";
                result.FilterIndex = 2;
                result.Title = "Salvar um arquivo texto";
                result.RestoreDirectory = true;
                if (result.ShowDialog() == DialogResult.OK)
                {
                    _path = result.FileName;
                    if (SaveToFile(lista))
                        MessageBox.Show("Arquivo gerado com sucesso!!!", "Geração de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Atenção, ocorreu um erro ao tentar gerar o arquivo.", "Geração de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Método responsável por [RETORNAR OS DADOS FORMATADOS PARA GERAÇÃO DO TXT]
        private static IList<string> GetFormatTxt<T>(IList<T> list)
        {
            var lista = list;
            IList<string> listTxt = new List<string>();
            string header = string.Empty;
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (i == props.Count - 1)
                    header += prop.Name;
                else
                    header += prop.Name + ";";
            }
            listTxt.Add(header);

            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                string body = string.Empty;
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;

                    if (i == values.Length - 1)
                        body += props[i].GetValue(item).ToString().Replace(",", ".");
                    else
                        body += props[i].GetValue(item).ToString().Replace(",", ".") + ";";
                }
                listTxt.Add(body);
            }
            return listTxt;
        }
        #endregion

        #region Método para Salvar as informação no Arquivo
        private static bool SaveToFile(IList<string> editor)
        {
            try
            {
                //Salva as informações no arquivo informado.
                using (var fs = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.Write))
                using (var sw = new StreamWriter(fs))
                {
                    foreach (var item in editor)
                    {
                        sw.WriteLine(item);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Método responsável por [RETORNAR LISTA DE CAMINHO DE UM ARQUIVO]
        public static  FileInfo[] GetFilesDirectory(string path,string extension)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //### Preenche o FileCollection com uma lista de objetos FileInfo
           return directoryInfo.GetFiles(extension, SearchOption.AllDirectories);
        }
        #endregion
    }
}
