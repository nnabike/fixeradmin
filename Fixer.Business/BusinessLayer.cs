using Fixer.Data;
using Fixer.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.Business
{
    public class BusinessLayer
    {
        DataLayer dataLayer = new DataLayer();
        public string GetTableData(string tableName)
        {
            var dataTable = dataLayer.GetTableData(tableName);
            return JsonConvert.SerializeObject(dataTable);
        }

        public string GetPagedData(RequestParams requestParams)
        {
            int nextPageNumber = Convert.ToInt32(requestParams.PageNumber);
            var dataTable = dataLayer.GetPagedData(requestParams.TableName, nextPageNumber);
            return JsonConvert.SerializeObject(dataTable);
        }

    }

   
}
