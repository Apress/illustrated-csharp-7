using System;

class Program
{
   static void Main( string[] args )
   {
      int latitude   = 43;
      int longitude  = 11;
      string north   = "N";
      string south   = "S";
      string east    = "E";

      Console.WriteLine( $"The city of Florence, Italy is located at latitude {latitude}{north} and longitude { longitude} { east}. By comparison, the city of Djibouti( in the country of Djibouti ) is located at latitude { longitude} { north} and longitude { latitude} { east}. The city of Moroni in the Comoros Islands is located at latitude { longitude} { south} and longitude { latitude} { east}." );
   }
}
