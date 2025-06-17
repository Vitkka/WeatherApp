using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather2.Model
{
    public class SiberianCities
    {
        public List<City> Cities { get; set; }

        public SiberianCities() 
        { 
        Cities = new List<City> {
            new City { Name = "Новосибирск", Latitude = 55.02, Longitude = 82.92 },
        new City { Name = "Красноярск", Latitude = 56.01, Longitude = 92.88 },
        new City { Name = "Иркутск", Latitude = 52.29, Longitude = 104.28 },
        new City { Name = "Чита", Latitude = 52.03, Longitude = 113.45 },
        new City { Name = "Братск", Latitude = 56.15, Longitude = 101.63 },
        new City { Name = "Ачинск", Latitude = 56.26, Longitude = 90.48 },
        new City { Name = "Абакан", Latitude = 53.72, Longitude = 91.45 },
        new City { Name = "Улан-Удэ", Latitude = 51.83, Longitude = 107.58 },
        new City { Name = "Бийск", Latitude = 52.53, Longitude = 85.21 },
        new City { Name = "Рубцовск", Latitude = 51.50, Longitude = 81.22 },
        };
        }
    }
}
