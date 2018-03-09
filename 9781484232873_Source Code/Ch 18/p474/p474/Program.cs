using System;

class Animal
{
   public int NumberOfLegs = 4;
}

class Dog : Animal
{ }

class Program
{
   static void Main()
   {
      Animal a1 = new Animal();
      Animal a2 = new Dog();

      Console.WriteLine($"Number of dog legs: { a2.NumberOfLegs }");
   }
}