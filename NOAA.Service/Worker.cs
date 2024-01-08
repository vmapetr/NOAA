using NOAA.Database;
using NOAA.Models;

namespace NOAA.Service;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    private async Task UpdateDatabase<T>() where T : class, INOAAModel, new()
    {
        try
        {
            using var context = new Context("C:\\Users\\petro\\Downloads\\noaadb.sqlite");

            context.Database.EnsureCreated();

            await DbUpdater.Update<T>(context);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error during {typeof(T).Name} model update. Exception: {ex.Message}. Inner exception: {ex.InnerException?.Message}");
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    { 
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }

            await UpdateDatabase<BoulderKIndex1m>();
            await UpdateDatabase<ElectronFluenceForecast>();
            await UpdateDatabase<EnlilTimeSeries>();
            await UpdateDatabase<F107CmFlux>();
            await UpdateDatabase<IcaoSpaceWeatherAdvisories>();
            await UpdateDatabase<PlanetaryKIndex1m>();
            await UpdateDatabase<PredictedF107cmFlux>();
            await UpdateDatabase<PredictedFredericksburgAIndex>();
            await UpdateDatabase<PredictedMonthlySunspotNumber>();
            await UpdateDatabase<SolarProbabilities>();
            await UpdateDatabase<SunspotReport>();

            await Task.Delay(TimeSpan.FromSeconds(600), stoppingToken);
        }
    }
}
