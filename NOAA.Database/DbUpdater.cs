using Microsoft.EntityFrameworkCore;
using NOAA.Api.Models;
using System.Reflection;
using NOAA.Api;

namespace NOAA.Database
{
    public class DbUpdater
    {
        public static async Task Update<T>(Context context) where T : class, INOAAModel, new()
        {
            DbSet<T>? contextProp = null;

            foreach (PropertyInfo prop in context.GetType().GetProperties()) 
            { 
                if (prop.PropertyType == typeof(DbSet<T>)) 
                {
                    contextProp = (DbSet<T>?)prop.GetValue(context);
                    break;
                }
            }

            if (contextProp == null)
            {
                throw new Exception("contextProp is null");
            }

            IEnumerable<T> remoteData = await Request.GetModelAsync<T>();

            if (contextProp.Count() == 0)
            {
                contextProp.AddRange(remoteData);
            }
            else
            {

            }

            context.SaveChanges();
        }
    }
}
