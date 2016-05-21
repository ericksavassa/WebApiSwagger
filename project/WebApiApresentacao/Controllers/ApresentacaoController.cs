using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApresentacao.Models;

namespace WebApiApresentacao.Controllers

{
    /// <summary>
    /// Controller Apresentacao
    /// </summary>
    public class ApresentacaoController : ApiController
    {
        /// <summary>
        /// Get all
        /// </summary>
        /// <remarks>Get all classes</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>All classes</returns>
        [ResponseType(typeof(ApresentacaoModel[]))]
        public IHttpActionResult Get()
        {
            var retorno = new ApresentacaoModel[] { new ApresentacaoModel("1","value1"), new ApresentacaoModel("2","value2") };
            return ResponseMessage(Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno));
        }

        /// <summary>
        /// Get a class
        /// </summary>
        /// <remarks>Get a class by id</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Return a class</returns>
        [ResponseType(typeof(ApresentacaoModel))]
        public IHttpActionResult Get(int id)
        {
            var retorno = new ApresentacaoModel(id.ToString(), string.Format("value{0}", id));
            return ResponseMessage(Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno));
        }

        /// <summary>
        /// Add new
        /// </summary>
        /// <remarks>Insert values</remarks>
        /// <response code="201">Created</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Return a the value added</returns>
        [ResponseType(typeof(ApresentacaoModel))]
        public IHttpActionResult Post(ApresentacaoModel value)
        {
            return ResponseMessage(Request.CreateResponse(System.Net.HttpStatusCode.OK, value));;
        }

        /// <summary>
        /// Update values
        /// </summary>
        /// <remarks>Alter values</remarks>
        /// <response code="202">Accepted</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Return a the value updated</returns>
        [ResponseType(typeof(ApresentacaoModel))]
        public IHttpActionResult Put(int id, ApresentacaoModel value)
        {
            return ResponseMessage(Request.CreateResponse(System.Net.HttpStatusCode.OK, value)); ;
        }

        /// <summary>
        /// Delete values
        /// </summary>
        /// <remarks>Delete values by id</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public void Delete(int id)
        {
        }
    }
}
