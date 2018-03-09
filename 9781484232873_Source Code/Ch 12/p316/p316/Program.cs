using System;

enum TrafficLight
{
   Green,
   Yellow,
   Red
}

class Program
{
   static void Main()
   {
      Console.WriteLine("Second member of TrafficLight is {0}\n", Enum.GetName(typeof(TrafficLight), 1));
      foreach (var name in Enum.GetNames(typeof(TrafficLight)))
         Console.WriteLine(name);
   }
}

