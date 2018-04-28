using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace PreCompiledFunction
{
    public class TestFunction
    {
        [FunctionName("CoolStuff")]
        public static HttpResponseMessage CoolStuff(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "CoolStuff")] HttpRequestMessage req,
            ILogger log)
        {
            return req.CreateResponse(System.Net.HttpStatusCode.OK);
        }
    }
}
