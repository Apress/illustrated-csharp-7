using System;
using System.Threading.Tasks;

class Program
{
   static void Main()
   {
      string[] squares = new string[]
               { "We", "hold", "these", "truths", "to", "be", "self-evident",
                    "that", "all", "men", "are", "created", "equal"};

      Parallel.ForEach( squares, s => Console.WriteLine( string.Format( $"\"{ s }\" has { s.Length } letters" ) ) );
   }
}
