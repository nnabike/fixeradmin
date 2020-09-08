using Fixer.Business;
using Fixer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fixer.Api.Controllers
{
    [RoutePrefix("api/data")]
    public class dataController : ApiController
    {
        BusinessLayer businessLayer = new BusinessLayer();
       


        // GET: api/data/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(string id)
        {
            return businessLayer.GetTableData(id);
        }


        // GET: api/data/
        [HttpGet]
        [Route("GetPagedData")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string GetPagedData([FromUri]RequestParams id)
        {
            return businessLayer.GetPagedData(id);
        }
        // POST: api/data
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/data/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/data/5
        public void Delete(int id)
        {
        }
    }

  
}
