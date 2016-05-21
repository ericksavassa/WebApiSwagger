
using System.ComponentModel.DataAnnotations;
namespace WebApiApresentacao.Models
{
    /// <summary>
    /// Model Class
    /// </summary>
    public class ApresentacaoModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_id">Id</param>
        /// <param name="_value">Value</param>
        public ApresentacaoModel(string _id, string _value)
        {
            id = _id;
            value = _value;
        }

        /// <summary>
        /// Id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The value
        /// </summary>
        [Required]
        public string value { get; set; }
    }
}