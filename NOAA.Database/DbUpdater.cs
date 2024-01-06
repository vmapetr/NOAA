using Microsoft.EntityFrameworkCore;
using NOAA.Models;
using System.Reflection;
using NOAA.Api;

namespace NOAA.Database
{
    public class DbUpdater
    {
        public static async Task Update<T>(Context context) where T : class, INOAAModel, new()
        {
            DbSet<T>? dbSet = null;

            foreach (PropertyInfo prop in context.GetType().GetProperties()) 
            { 
                if (prop.PropertyType == typeof(DbSet<T>)) 
                {
                    dbSet = (DbSet<T>?)prop.GetValue(context);
                    break;
                }
            }

            if (dbSet == null)
            {
                throw new Exception("dbSet is null");
            }

            IEnumerable<T> remoteData = await Request.GetModelAsync<T>();

            if (dbSet.Count() == 0)
            {
                dbSet.AddRange(remoteData);
            }
            else
            {
                dbSet.AddRange(remoteData.Where(r => r.Timestamp > dbSet.Max(d => d.Timestamp)));
            }

            context.SaveChanges();
        }
    }
}
