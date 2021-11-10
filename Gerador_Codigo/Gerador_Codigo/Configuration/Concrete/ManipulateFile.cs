
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Gerador_Codigo.Configuration
{
    public class ManipulateFile : IManipulateFile
    {
        #region Método responsável por [RETORNAR UMA LISTA DE TUPLE COM NOME E LOCAL DO ARQUIVO]
        public List<(string path, string extension)> GetPathFile(string path, string extension)
        {
            //Cria uma tupla para retornar o nome e o caminho do arquivo.
            var listTuple = new List<(string, string)>();

            listTuple.Clear();

            //Percorre o diretório informado e captura os arquivos de acordo com a extensão.
            foreach (string foundFile in Directory.GetFiles(path,extension.ToLower(),SearchOption.AllDirectories))
            {
                //Captura o nome do arquivo.
                string fileName = System.IO.Path.GetFileName(foundFile.ToUpper().Replace(extension.ToLower(), "").ToLower()) ;
            
                //Captura o caminho do arquivo
                string pathFile = foundFile;

                //Salva as informações na tupla e retorna.
                listTuple.Add((fileName, pathFile));
            }

            return listTuple;
        }
        #endregion

        #region Método para Carregar as informação do Arquivo
        public string[] LoadFromFile(string path)
        {

            //Lê as informações de arquivo texto e retorna o texto.
            string[] _editor ;
            using (var fs = new FileStream(path, FileMode.Open))
            using (var sr = new StreamReader(fs))
            {
                int i = 0;
                _editor = null;
                while (sr.Peek() >= 0)
                {
                    _editor[i] = sr.ReadLine();
                    i++;
                }
            }
            return _editor;
        }
        #endregion

        #region Método para Salvar as informação no Arquivo
        public void SaveToFile(string path, string[] editor)
        {
            //Salva as informações no arquivo informado.
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (var sw = new StreamWriter(fs))
            {
                int i = 0;
                while (i < editor.Count())
                {
                    sw.WriteLine(editor[i]);
                    i++;
                }
            }
        }
        #endregion
    
    }
}
