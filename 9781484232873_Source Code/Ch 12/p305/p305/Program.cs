using System;

enum TrafficLight
{
   Green,
   Yellow,
   Red
}

class Program
{
   static void Main(string[] args)
   {
      TrafficLight t1 = TrafficLight.Red;       // Assign from member
      TrafficLight t2 = TrafficLight.Green;     // Assign from member
      TrafficLight t3 = t2;                     // Assign from variable

      Console.WriteLine(t1);
      Console.WriteLine(t2);
      Console.WriteLine(t3);
   }
}

