using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Finder.Classes
{
    public class Model
    {
        public string ModelName { get; set; }
        public string BodyType { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public string DriveType { get; set; }
        public double EngineVolume { get; set; }
        public int EnginePower { get; set; }
        public int Price { get; set; }
        public string GearBox { get; set; }
        public int NumberOfSeat { get; set; }
        public List<string> Colors { get; set; }
        public int BrandId { get; set; }

    }
}
