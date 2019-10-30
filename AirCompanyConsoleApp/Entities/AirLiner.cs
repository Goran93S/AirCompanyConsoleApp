using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp.Entities
{
    class AirLiner:Plane
    {
       
        public AirLiner(string Label, double MaxWeight, double WeightEmpty) : base(Label, MaxWeight, WeightEmpty)
        {
        }
        public override void AddOnEmptySpot(I_item Item)
        {
            double ComparableWeight = GetWeight() + Item.GetWeight();
             if ((Item.GetType() == typeof(Person) && ComparableWeight <= MaxWeight))
             {
                 Items.Add(Item);
                 TotalWeight += Item.GetWeight();
             }

           

        }
        public override void AddOnSelectedPosition(I_item Item, int position)
        {
            if ((Item.GetType() == typeof(Person) && TotalWeight + Item.GetWeight() <= MaxWeight) && Items[position] == null)
            {
                Items[position] = Item;
                TotalWeight += Item.GetWeight();
            }
        }
     
    }
}
