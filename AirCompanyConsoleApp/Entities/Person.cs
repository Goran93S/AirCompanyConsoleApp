using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp.Entities
{
    public class Person : I_item
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Person(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }

        public string GetName()
        {
            return Name;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public override string ToString()
        {
            return Name + ": " + Weight.ToString();
        }
    }
}
