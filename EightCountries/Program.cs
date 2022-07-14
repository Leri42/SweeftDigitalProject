using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using EightCountries.Properties;
using System.IO;

namespace EightCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateCountryDataFiles();
            Console.WriteLine("Country files generation done");
            Console.ReadLine();
        }
        static async void GenerateCountryDataFiles()
        {
            try
            {
                HttpClient client = new HttpClient();
                string apiUrl = Settings.Default.ApiUrl;
                var responseMsg = await client.GetAsync(apiUrl);
                responseMsg.EnsureSuccessStatusCode();

                var responseResult = await responseMsg.Content.ReadAsStringAsync();
                var results = JArray.Parse(responseResult);
                //var allCountries = new List<CountryResult>();
                foreach(var res in results)
                {
                    var countryResult = res.ToObject<CountryResult>();
                    string fileName = Settings.Default.FileName +$"{countryResult.Name.Common}.txt"; // file name needs update 
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                    string[] lines = {
                        $"region : {countryResult.Region}",
                        $"subregion : {countryResult.SubRegion}",
                        $"latlng : {string.Join(", ",countryResult.LatLng)}",
                        $"area : {countryResult.Area}",
                        $"population : {countryResult.Population}"
                    };
                    File.WriteAllLines(fileName, lines);
                    //allCountries.Add(countryResult);
                }
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
