using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightCountries
{
    public class CountryName
    {
        public string Common { get; set; }
    }
    public class CountryResult
    {
        public CountryName Name { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public int Area { get; set; }
        public long Population { get; set; }
        public double[] LatLng { get; set; }
    }
}
