using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp.Entities
{
    class Container : I_item
    {
        public string Label { get; set; }
        public double WeightEmpty { get; set; }
        public int MaxNumberOfItems { get; set; }

        public static double TotalWeight = 0;

        public static int noOfItems = 0;

        public List<Package> Packages = new List<Package>();
        public Container(string Label, double WeightEmpty, int NumberOfItems)
        {
            this.Label = Label;
            this.WeightEmpty = WeightEmpty;
            this.MaxNumberOfItems = NumberOfItems;
        }
        public void AddOnEmptySpot(Package package)
        {
            if (noOfItems< MaxNumberOfItems)
            {
                Packages.Add(package);
                TotalWeight += package.Weight;
                noOfItems++;
            }
        }
        public void AddOnSelectedPosition(Package package,int position)
        {
            if (Packages[position] == null && position <= MaxNumberOfItems)
            {
                Packages[position] = package;
                TotalWeight += package.Weight;
            }
        }
        public void RemoveItem(int position)
        {
            Packages.RemoveAt(position);
            TotalWeight -= Packages[position].Weight;
        }
        public List<Package> GetAllPackages()
        {
            return Packages;
        }
        public string GetName()
        {
            return Label;
        }
        public double GetWeight()
        {
            return TotalWeight+WeightEmpty;
        }
    }
}
