using System.IO;
using FileHelpers;

namespace ChartSite.Data.FileLoader
{
    public class FileRepository
    {
        private readonly string _sourceFolder;

        public FileRepository(string sourceFolder)
        {
            _sourceFolder = sourceFolder;
        }

        public T[] LoadFile<T>(string filename) where T : class
        {
            var engine = new FileHelperEngine<T>();
            var result = engine.ReadFile(Path.Combine(_sourceFolder, filename));
            return result;
        }
    }
}