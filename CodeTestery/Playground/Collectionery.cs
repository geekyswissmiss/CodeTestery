using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Playground
{
    public class Collectionery
    {
        static void Main(string[] args)
        {
            try
            {
                //find the key with 3, then grab the value?
                var keys = ConfigurationManager.AppSettings.AllKeys;
                var query = keys.Select(k => k).Where(k => k.Contains("3"));
                foreach (var key in query)
                {
                    Console.WriteLine(key);
                    Console.WriteLine(ConfigurationManager.AppSettings[key].ToString());
                }

                //var appSettings = ConfigurationManager.AppSettings;               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
