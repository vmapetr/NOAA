using System.Reflection;

namespace NOAA.Database.Statistics
{
    public class StatisticsAverageAnalyzer : StatisticsAnalyzer
    {
        public override Dictionary<string, double> GetStatistics<T>(IEnumerable<T> modelSet)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            var modelProps = GetStatisticsProperties<T>();

            foreach (PropertyInfo property in modelProps)
            {
                result.Add(property.Name, 0.0);
            }

            // add null value handling
            foreach (T modelElem in modelSet)
            {
                foreach (var propName in modelProps.Select(p => p.Name))
                {
                    double value = Convert.ToDouble(modelElem!.GetType().GetProperty(propName)!.GetValue(modelElem));
                    result[propName] += value;
                }
            }

            foreach (var item in result.Keys)
            {
                result[item] /= modelSet.Count();
            }

            return result;
        }
    }
}
