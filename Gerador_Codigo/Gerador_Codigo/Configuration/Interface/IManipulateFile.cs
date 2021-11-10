using System.Collections.Generic;

namespace Gerador_Codigo.Configuration
{
    public interface IManipulateFile
    {
        string[] LoadFromFile(string path);
        void SaveToFile(string path, string[] editor);
        List<(string path, string extension)> GetPathFile(string path, string extension);
    }
}
