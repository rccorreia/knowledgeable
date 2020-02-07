using System;
using System.Threading.Tasks;
using knowledgeable.Tools;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace knowledgeable
{
    public static class knowledgeable
    {
        [FunctionName("knowledgeable")]
        public static async Task RunAsync([TimerTrigger("0 45 0/8 * * *")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation(
                $"Timer trigger executada as: {DataHoraFormatoBrasileiro.RetornaDataAtual()}");
        }
    }
}
