using Microsoft.Extensions.Configuration;
using RawDealDb.Core.Interfaces.DAL;
using RawDealDb.Core.Models;
using RawDealDb.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Infrastructure.Repositories
{
    public class SetsRepository : ISetsRepository
    {
        private readonly IConfiguration _configuration;
        public SetsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<T> GetAllSets<T>(string contextPath) where T : class
        {
            var setList = new List<T>();
            var folderLocation = _configuration["settings:setsDirectory"];
            var folderPath = Path.Combine(contextPath, folderLocation);
            var directories = Directory.GetDirectories(folderPath);
            foreach ( var directory in directories)
            {
                var setFile = Directory.GetFiles(directory);
                var set =  XMLParser.SerializeXml<T>("set", setFile);
                setList.Add(set);
            }

            return setList;
        }

        public T GetSetById<T>(string setId, string contextPath) where T : class
        {
            var folderLocation = _configuration.GetSection("setsDirectory").Value;
            var path = Path.Combine(contextPath,folderLocation, setId);
            var setFile = Directory.GetFiles(path);
            var set = XMLParser.SerializeXml<T>("set",setFile);
            return set;
        }
    }
}
