using RawDealDb.Core.Interfaces.Service;
using RawDealDb.UI.Interfaces;

namespace RawDealDb.UI.Services
{
    public class FileService : IFileService
    {
        private string _rootPath;
        private readonly IFileServiceCore _fileServiceCore;
        public FileService(IFileServiceCore fileServiceCore)
        {
            _fileServiceCore = fileServiceCore;
            _rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "docs");
        }

        public string GetFile(string fileName)
        {
            var file = _fileServiceCore.GetFile(_rootPath, fileName);
            return file;
        }
    }
}
