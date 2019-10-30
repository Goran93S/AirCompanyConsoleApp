using AirCompanyConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David Jason", 85); //creating two Persons
            Person Angel = new Person("Angel Garcia", 78);

            Package pack01 = new Package("Box", 5);   //creating two Packages
            Package pack02 = new Package("Printers", 15);

            Container cont01 = new Container("Container 01", 25, 4); //creating Container

            Plane Airliner01 = new AirLiner("AirLiner 1", 2500, 300); // creating Plane type of Airliner
            Airliner01.AddOnEmptySpot(David);        // putting Persons in that Plane
            Airliner01.AddOnEmptySpot(Angel);

            Airport Nikola_Tesla = new Airport("Nikola Tesla", 15); //creating Airport
            Nikola_Tesla.AddOnAirport(Airliner01); // putting Plane on Airport

            foreach (var plane in Nikola_Tesla.GetAllPlanes()) // printing all items at Airport
            {
                Console.WriteLine(plane.GetName()+" - "+plane.WeightEmpty);
                foreach (var item in plane.Items)
                {
                    Console.WriteLine(item.GetName()+"-"+item.GetWeight());
                } 
                Console.WriteLine();
            }

            Nikola_Tesla.AirplaneFlies(Airliner01); //calling method for flying
            Nikola_Tesla.AirplaneLands(Airliner01); //calling method for landing


            cont01.AddOnEmptySpot(pack01); //putting two Packages in Container
            cont01.AddOnEmptySpot(pack02);

         
            Cargo cargoPlane = new Cargo("cargo01",2000,400); //creating Plane type of Cargo and putting Container in it
            cargoPlane.AddOnEmptySpot(cont01);
            

            foreach (var item in cargoPlane.Items)    //printing all items from Cargo Plane (Name - Weight)
            {
                Console.WriteLine(item.GetName()+"-"+item.GetWeight());
            }

        }
    }
}
