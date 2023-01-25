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

        public string GetDetails()
        {
            return $"building volume is {area * height} cubic meters";
        }
    }
}
