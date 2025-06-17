using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather2.Model
{
    public class DailyWeather
    {
        public DateTime Date { get; set; } 
        public string Description { get; set; } 
        public double Temperature { get; set; } 
        public double Humidity { get; set; } 
        public double WindSpeed { get; set; } 
    }
}
