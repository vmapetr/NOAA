using NOAA.Api;
using NOAA.Api.Models;
using NOAA.Database;

namespace NOAA.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new Context("C:\\Users\\petro\\Downloads\\noaadb.sqlite");

            context.Database.EnsureCreated();

            await DbUpdater.Update<SunspotReport>(context);

            //var model = await Request.GetModelAsync<OvationAuroraLatest>();
            //var model = await Request.GetOvationAuroraLatestModel();
            //var coordString = String.Join(", ", model.Coordinates!.Select(i => String.Join(":", i)));
            //Console.WriteLine($"{coordString}");

            //context.BoulderKIndex1m.AddRange(model.ToArray());

            //foreach (var item in model) { Console.WriteLine($"{item.ObservationTime} - {String.Join(", ", item.DataFormat)}"); }

            try
            {
                //context.SaveChanges();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
