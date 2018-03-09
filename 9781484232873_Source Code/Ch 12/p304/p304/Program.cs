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
      TrafficLight t1 = TrafficLight.Green;
      TrafficLight t2 = TrafficLight.Yellow;
      TrafficLight t3 = TrafficLight.Red;

      Console.WriteLine($"{ t1 },\t{(int)t1 }");
      Console.WriteLine($"{ t2 },\t{(int)t2 }");
      Console.WriteLine($"{ t3 },\t{(int)t3 }\n");
   }
}

