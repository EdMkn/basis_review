using System.IO;

namespace _10_Fichiers
{
    public class FileManager
    {
        private readonly string _filePath;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteText(string content)
        {
            File.WriteAllText(_filePath, content);
        }

        public string ReadText()
        {
            return File.ReadAllText(_filePath);
        }
    }
}
