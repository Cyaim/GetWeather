using System;
using System.Collections.Generic;
using System.Text;

namespace Cyaim.Weather.Models
{

    public class CityModel
    {
        public CityItem[] CityItems { get; set; }
    }

    public struct CityItem
    {
        public string code { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string url { get; set; }
    }

}
