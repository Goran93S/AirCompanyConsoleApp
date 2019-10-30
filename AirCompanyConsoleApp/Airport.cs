using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp
{
    class Airport
    {
        public string Label { get; set; }

        public int NumberOfPlanes { get; set; }

        public List<Plane> planes = new List<Plane>();

        public Airport(string Label, int NumberOfPlanes)
        {
            this.Label = Label;
            this.NumberOfPlanes = NumberOfPlanes;
        }

        public void AddOnAirport(Plane _plane)
        {
            if (planes.Count + 1 <= NumberOfPlanes)
                planes.Add(_plane);
        }

        public void AirplaneFlies(Plane _plane)
        {
            Console.WriteLine();
            Console.WriteLine("Airplane(Max:"+_plane.MaxWeight+")" + _plane + " is flying");          
        }

        public void AirplaneLands(Plane _plane)
        {
            Console.WriteLine();
            Console.WriteLine("Airplane(Max:" + _plane.MaxWeight + ")" + _plane + " is landed");
        }

        public List<Plane> GetAllPlanes()
        {
            return planes;
        }
    }
}
