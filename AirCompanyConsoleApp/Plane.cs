using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp
{
    abstract class Plane
    {
        public static double TotalWeight = 0;
        public string Label { get; set; }
        public double MaxWeight { get; set; }
        public double WeightEmpty { get; set; }
      

        public List<I_item> Items = new List<I_item>(); 
        public Plane(string Label, double MaxWeight, double WeightEmpty)
        {            
            this.Label = Label;
            this.MaxWeight = MaxWeight;
            this.WeightEmpty = WeightEmpty;
        }

        public abstract void AddOnEmptySpot(I_item Item);

        public abstract void AddOnSelectedPosition(I_item Item, int position);
              
        public string GetName()
        {
            return Label;
        }

        public double GetWeight()
        {
            return TotalWeight + WeightEmpty;
        }

        public override string ToString()
        {
            return Label + " - Weight:" + GetWeight().ToString();
        }




    }
}
