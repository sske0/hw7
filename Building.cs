using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string address;
        
        public Building(string name, int area, int height)
        {
         this.name = name;
         this.area = area;
         this.height = height;    
        }
        public string GetVolume()
        {
            return $"building volume is {area * height} cubic meters";
        }
    }
}
