using System;
using System.Collections.Generic;
using System.Text;

namespace Cyaim.Weather.Models
{
    public class MapModel
    {
        public string msg { get; set; }
        public int code { get; set; }
        public object[][] data { get; set; }
    }
}
