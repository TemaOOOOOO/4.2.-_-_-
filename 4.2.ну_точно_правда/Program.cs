using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Waste> wasteList = new List<Waste>
        {
            new Plastic(2.5),
            new Metal(2.0),
            new Paper(1.0),
            new Glass(1.5),
            new Organic(0.3)
        };

        TrashStation station = new TrashStation();

        foreach (Waste waste in wasteList)
        {
            station.AddWaste(waste);
        }

        Console.WriteLine("Original list:");
        station.Print();

        Console.WriteLine("\nSorted by size:");
        station.OrderBySize().Print();

        Console.WriteLine("\nSorted by type:");
        station.OrderByType().Print();

        Console.WriteLine("\nFiltered by size (>1.4):");
        station.SortBySize(1.4).Print();
    }
}