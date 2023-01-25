using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    public class Animal
    {
        public string name;
        public string breed;
        public byte age;
        public string color;

        public string GetDetails()
        {
            return $"name: {name}\n breed:{breed}\n age:{age}";
        }
    }
}
