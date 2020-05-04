using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;

namespace TestSqlClientFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static string Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                var sqlCon = new SqlConnection("connectionstringdoesntmatter");
                sqlCon.Open();
                log.LogInformation("Opened Connection");
            }
            catch (System.Exception ex)
            {
               
                return ex.Message;
            }


            return "Successfully opened connection";
        }
    }
}
