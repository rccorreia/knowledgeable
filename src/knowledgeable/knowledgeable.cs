using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace knowledgeable
{
    public static class knowledgeable
    {
        [FunctionName("knowledgeable")]
        public static async Task RunAsync([TimerTrigger("*/5 * * * * *")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.UtcNow}");
        }
    }
}
