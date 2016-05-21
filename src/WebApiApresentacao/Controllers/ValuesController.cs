using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiApresentacao.Controllers
{
    /// <summary>
    /// Values COntroller
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// GET api/values 
        /// </summary>
        /// <returns>values</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        /// <summary>
        /// GET api/values/5 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>value</returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="value">value</param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// PUT api/values/5 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="value">value</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// DELETE api/values/5
        /// </summary>
        /// <param name="id">id</param>
        public void Delete(int id)
        {
        }
    }
}
