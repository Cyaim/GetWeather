using System;
using System.Collections.Generic;
using System.Text;

namespace Cyaim.Weather.Models
{

    public class ProvinceModel
    {
        public ProvinceItemModel[] ProvinceItems { get; set; }
    }

    public struct ProvinceItemModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

}
