using CsvHelper;
using InvoiceGenerationBO;
using InvoiceGenerationDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace InvoiceGenerationBAL
{
    public class Import : IImport
    {

        private IDataRepository _dataRepository;

        public Import(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        private readonly string ImportFullPath = ConfigurationManager.AppSettings["ImportFilePath"].ToString();

        public object GLImport(string FileName)
        {
            return 0;
        }

        public object P2Import(string FileName)
        {
            object obj = null;
            using (var reader = new StreamReader(ImportFullPath + FileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<P2SourceMap>();
                List<P2Source> p2Sources = csv.GetRecords<P2Source>().ToList();
                obj = _dataRepository.BulkInsert<P2Source>(p2Sources, "usp_InsertP2Source");
            }
            return obj;
        }

        public object P3Import(string FileName)
        {
            return 0;
        }
    }
}
