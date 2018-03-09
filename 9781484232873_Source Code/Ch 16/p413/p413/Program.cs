using System;

interface ILiveBirth // Declare interface.
{
   string BabyCalled();
}

class Animal { } // Base class Animal

class Cat : Animal, ILiveBirth // Declare class Cat.
{
   string ILiveBirth.BabyCalled()
   {
      return "kitten";
   }
}

class Dog : Animal, ILiveBirth // Declare class Dog.
{
   string ILiveBirth.BabyCalled()
   {
      return "puppy";
   }
}

class Bird : Animal // Declare class Bird.
{
}

class Program
{
   static void Main()
   {
      Animal[] animalArray = new Animal[3];        // Create Animal array.

      animalArray[0] = new Cat();                  // Insert Cat class object.
      animalArray[1] = new Bird();                 // Insert Bird class object.
      animalArray[2] = new Dog();                  // Insert Dog class object.

      foreach ( Animal a in animalArray )          // Cycle through array.
      {
         ILiveBirth b = a as ILiveBirth;           // if implements ILiveBirth...
         if ( b != null )
            Console.WriteLine( $"Baby is called: { b.BabyCalled() }" );
      }
   }
}