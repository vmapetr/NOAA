using NOAA.Api;
using NOAA.Models;
using NOAA.Database;

namespace NOAA.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new Context("C:\\Users\\petro\\Downloads\\noaadb.sqlite");

            context.Database.EnsureCreated();

            await DbUpdater.Update<BoulderKIndex1m>(context);
        }
    }
}
