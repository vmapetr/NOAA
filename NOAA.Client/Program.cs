using NOAA.Api;
using NOAA.Models;
using NOAA.Database;
using NOAA.Database.Statistics;

namespace NOAA.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new Context("C:\\Users\\petro\\Downloads\\noaadb.sqlite");

            context.Database.EnsureCreated();

            //await DbUpdater.Update<BoulderKIndex1m>(context);

            IEnumerable<PredictedF107cmFlux> remoteData = await Request.GetModelAsync<PredictedF107cmFlux>();

            StatisticsAnalyzer analyzer = new StatisticsAverageAnalyzer();

            var avg = analyzer.GetStatistics(remoteData);
            
            Console.WriteLine(String.Join("\n", avg.Select(i => $"{i.Key} = {i.Value}")));
        }
    }
}
