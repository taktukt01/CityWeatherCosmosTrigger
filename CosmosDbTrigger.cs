using System;
using System.Collections.Generic;
using CityWeatherSender;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CityWeatherCosmosTrigger
{
    public static class CosmosDbTrigger
    {
        [FunctionName(nameof(CosmosDbTrigger))]
        public static void Run([CosmosDBTrigger(
            databaseName: "WeatherInfo",
            containerName: "CityWeather",
            Connection = "CosmosDbConnectionString",
            CreateLeaseContainerIfNotExists = true)]IReadOnlyList<WeatherInfo> input,
            ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Document", input);
            }
        }
    }

}
