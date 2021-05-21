using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherDetails.Models
{
    public class WeatherDetails
    {
        public DateTime Date { get; set; }
        public string City { get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }
        public string Forcast { get; set; }
    }
}
