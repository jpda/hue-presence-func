using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace hue_presence_func
{
    public static class LocalHueHubSubscriber
    {
        [FunctionName("LocalHueHubSubscriber")]
        public static void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
