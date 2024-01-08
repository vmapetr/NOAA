using System.Reflection;

namespace NOAA.Database.Statistics
{
    public class StatisticsRMSAnalyzer : StatisticsAnalyzer
    {
        public override Dictionary<string, double> GetStatistics<T>(IEnumerable<T> modelSet)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            Dictionary<string, double> sum = new Dictionary<string, double>();
            Dictionary<string, double> sqr = new Dictionary<string, double>();

            var modelProps = GetStatisticsProperties<T>();

            foreach (PropertyInfo property in modelProps)
            {
                result.Add(property.Name, 0.0);
                sum.Add(property.Name, 0.0);
                sqr.Add(property.Name, 0.0);
            }

            foreach (T modelElem in modelSet)
            {
                foreach (var propName in modelProps.Select(p => p.Name))
                {
                    double value = Convert.ToDouble(modelElem!.GetType().GetProperty(propName)!.GetValue(modelElem));
                    sqr[propName] += value * value;
                    sum[propName] += value;
                }
            }

            foreach (var item in sqr.Keys)
            {
                result[item] = Math.Sqrt((sqr[item] / modelSet.Count()) - Math.Pow(sum[item] / modelSet.Count(), 2));
            }

            return result;
        }
    }
}
