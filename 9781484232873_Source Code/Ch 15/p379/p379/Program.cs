using System;

delegate void Handler();

class Incrementer
{
   public event Handler CountedADozen;

   public void DoCount()
   {
      for ( int i = 1; i < 100; i++ )
         if ( i % 12 == 0 && CountedADozen != null )
            CountedADozen();
   }
}

class Dozens
{
   public int DozensCount { get; private set; }

   public Dozens( Incrementer incrementer )
   {
      DozensCount = 0;
      incrementer.CountedADozen += IncrementDozensCount;
   }

   void IncrementDozensCount()
   {
      DozensCount++;
   }
}

class Program
{
   static void Main()
   {
      Incrementer incrementer = new Incrementer();
      Dozens dozensCounter = new Dozens( incrementer );

      incrementer.DoCount();
      Console.WriteLine( "Number of dozens = {0}",
                              dozensCounter.DozensCount );
   }
}