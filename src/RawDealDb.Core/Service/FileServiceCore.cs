using RawDealDb.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Service
{
    public class FileServiceCore : IFileServiceCore
    {
        private readonly IInfrastructureFileService _fileService;
        public FileServiceCore(IInfrastructureFileService fileService)
        {
            _fileService= fileService;
        }
        public string GetFile(string contextPath, string fileName)
        {
            var file = _fileService.GetFile(contextPath, fileName);
            return file;
        }
    }
}
