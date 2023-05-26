using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace LearnListsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> marathons = new List<double>

        {
        144.07,
        143.12,
        146.73,
        146.33
        };
            //Use GetRange() to get the first three elements in the marathons list.
            List<double> topMarathons = marathons.GetRange(0, 3);
            //Loop through the topMarathons list and print each value to the console.
            foreach (double count in topMarathons)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("Good by!!");
        
        List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
        Random rand = new Random();

        Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
      // First loop
      for (int i = 0; i<runners.Count; i++)
      {
        Console.WriteLine($"{i+1}: {runners[i]}");
      }

    Console.WriteLine("\nPrinting runner bibs...");
      
      // Second loop
     
foreach(string run in runners)
{
     string name = run.ToUpper();
    int id = rand.Next(100, 1000);
    Console.WriteLine($"{id} - {name}");
}
    }
  }
}