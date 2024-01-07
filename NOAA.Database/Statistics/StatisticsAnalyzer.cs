using NOAA.Models.StatisticAttributes;
using System.Reflection;

namespace NOAA.Database.Statistics
{
    public abstract class StatisticsAnalyzer
    {
        protected IEnumerable<PropertyInfo> GetStatisticsProperties<T>()
        {
            return typeof(T).GetProperties().Where(property => Attribute.IsDefined(property, typeof(StatisticsAttribute)));
        }

        public abstract Dictionary<string, double> GetStatistics<T>(IEnumerable<T> modelSet);
    }
}
