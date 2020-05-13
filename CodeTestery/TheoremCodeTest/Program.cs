using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CodeTestery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        
        public static Dictionary<object, int> FrequencyCount(IEnumerable<object> data)
        {
            List<String> yeet = new List<string>();
            Dictionary<object, int> result = new Dictionary<object, int>();
            foreach (String what in yeet)
            {
                if (result.ContainsKey(what))
                {
                    int value = 0;
                    result.TryGetValue(what, out value);
                    result.Remove(what);
                    value++;

                }
            }
            return result;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
