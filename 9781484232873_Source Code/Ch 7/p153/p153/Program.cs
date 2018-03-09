using System;

class Class1
{
   int Id;
   string Name;

   public Class1()              { Id = 28; Name  = "Nemo"; }      // Constructor 0
   public Class1( int val )     { Id = val; Name = "Nemo"; }      // Constructor 1
   public Class1( String name ) { Name = name; }                  // Constructor 2

   public void SoundOff()
   {
      Console.WriteLine( $"Name { Name }, Id { Id }" );
   }
}

class Program
{
   static void Main()
   {
      Class1 a = new Class1(),         // Call constructor 0.
             b = new Class1( 7 ),      // Call constructor 1.
             c = new Class1( "Bill" ); // Call constructor 2.

      a.SoundOff();
      b.SoundOff();
      c.SoundOff();
   }
}