using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NOAA.Models;

namespace NOAA.Database
{
    public class Context : DbContext
    {
        private readonly string _path;

        public Context(string path) 
        {
            if (String.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path), "Database path is empty");

            _path = path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sb = new SqliteConnectionStringBuilder() { DataSource = _path };

            optionsBuilder.UseSqlite(sb.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoulderKIndex1m>().ToTable("BoulderKIndex1m");
            modelBuilder.Entity<ElectronFluenceForecast>().ToTable("ElectronFluenceForecast");
            modelBuilder.Entity<EnlilTimeSeries>().ToTable("EnlilTimeSeries");
            modelBuilder.Entity<F107CmFlux>().ToTable("F107CmFlux");
            modelBuilder.Entity<IcaoSpaceWeatherAdvisories>().ToTable("IcaoSpaceWeatherAdvisories");
            modelBuilder.Entity<PlanetaryKIndex1m>().ToTable("PlanetaryKIndex1m");
            modelBuilder.Entity<PredictedF107cmFlux>().ToTable("PredictedF107cmFlux");
            modelBuilder.Entity<PredictedFredericksburgAIndex>().ToTable("PredictedFredericksburgAIndex");
            modelBuilder.Entity<PredictedMonthlySunspotNumber>().ToTable("PredictedMonthlySunspotNumber");
            modelBuilder.Entity<SolarProbabilities>().ToTable("SolarProbabilities");
            modelBuilder.Entity<SunspotReport>().ToTable("SunspotReport");
        }

        public DbSet<BoulderKIndex1m> BoulderKIndex1m { get; set; }
        public DbSet<ElectronFluenceForecast> ElectronFluenceForecast { get; set; }
        public DbSet<EnlilTimeSeries> EnlilTimeSeries { get; set; }
        public DbSet<F107CmFlux> F107CmFlux { get; set; }
        public DbSet<IcaoSpaceWeatherAdvisories> IcaoSpaceWeatherAdvisories { get; set; }
        public DbSet<PlanetaryKIndex1m> PlanetaryKIndex1m { get; set; }
        public DbSet<PredictedF107cmFlux> PredictedF107cmFlux { get; set; }
        public DbSet<PredictedFredericksburgAIndex> PredictedFredericksburgAIndex { get; set; }
        public DbSet<PredictedMonthlySunspotNumber> PredictedMonthlySunspotNumber { get; set; }
        public DbSet<SolarProbabilities> SolarProbabilities { get; set; }
        public DbSet<SunspotReport> SunspotReport { get; set; }
    }
}
