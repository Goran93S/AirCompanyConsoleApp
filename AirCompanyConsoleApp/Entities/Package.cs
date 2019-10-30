using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp.Entities
{
    class Package : I_item
    {
        public string Label { get; set; }
        public double Weight { get; set; }

        public Package(string Label, double Weight)
        {
            this.Label = Label;
            this.Weight = Weight;
        }

        public string GetName()
        {
            return Label;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public override string ToString()
        {
            return GetName() + " " + GetWeight().ToString(); 
        }
    }
}
