using System.Web.Http;
using WebActivatorEx;
using WebApiApresentacao;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApiApresentacao
{
    /// <summary>
    /// SwaggerConfig
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// SwaggerConfig Register
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WebApiApresentacao");
                    c.IncludeXmlComments(ReturnXmlPath());
                }).EnableSwaggerUi("Help/{*assetPath}", c =>
                {
                    c.CustomAsset("ui", thisAssembly, "WebApiApresentacao.Help.index.html");
                });
        }

        /// <summary>
        /// Return Xml Path
        /// </summary>
        /// <returns></returns>
        private static string ReturnXmlPath()
        {
            return string.Format(@"{0}\bin\WebApiApresentacao.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
