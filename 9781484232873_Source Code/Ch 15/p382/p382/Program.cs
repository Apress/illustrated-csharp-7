using System;

public class IncrementerEventArgs : EventArgs   // Custom class derived from EventArgs
{
   public int IterationCount { get; set; }      // Stores an integer
}

class Incrementer
{
   public event EventHandler<IncrementerEventArgs> CountedADozen;

   public void DoCount()
   {
      IncrementerEventArgs args = new IncrementerEventArgs();
      for ( int i = 1; i < 100; i++ )
         if ( i % 12 == 0 && CountedADozen != null )
         {
            args.IterationCount = i;
            CountedADozen( this, args );
         }
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
   void IncrementDozensCount( object source, IncrementerEventArgs e )
   {
      Console.WriteLine( $"Incremented at iteration: { e.IterationCount } in { source.ToString() }" );
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
      Console.WriteLine( $"Number of dozens = { dozensCounter.DozensCount }" );
   }
}