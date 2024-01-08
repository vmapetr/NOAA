using NOAA.Database;
using NOAA.Models;

namespace NOAA.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new Context("C:\\Users\\petro\\Downloads\\noaadb.sqlite");

            context.Database.EnsureCreated();

            await DbUpdater.Update<BoulderKIndex1m>(context);

            /*
            var remoteData = await Request.GetModelAsync<PredictedMonthlySunspotNumber>();

            StatisticsAnalyzer analyzer = new StatisticsRMSAnalyzer();

            var avg = analyzer.GetStatistics(remoteData);
            
            Console.WriteLine(String.Join("\n", avg.Select(i => $"{i.Key} = {i.Value}")));
            */
        }
    }
}
