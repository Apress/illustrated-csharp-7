using System;

class Animal { public int NumberOfLegs = 4; }

class Dog : Animal { }

class Program
{
   delegate void Action1<in T>(T a);

   static void ActOnAnimal(Animal a)
   {
      Console.WriteLine(a.NumberOfLegs);
   }

   static void Main()
   {
      Action1<Animal> act1 = ActOnAnimal;
      Action1<Dog> dog1 = act1;
      dog1(new Dog());
   }
}