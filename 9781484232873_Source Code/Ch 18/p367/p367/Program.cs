using System;

struct PieceOfData<T>                           // Generic struct
{
   public PieceOfData(T value) { _data = value; }
   private T _data;
   public  T Data
   {
      get { return _data; }
      set { _data = value; }
   }
}

class Program
{
   static void Main()
   {
      var intData = new PieceOfData<int>(10);
      var stringData = new PieceOfData<string>("Hi there.");

      Console.WriteLine($"intData    = { intData.Data }");
      Console.WriteLine($"stringData = { stringData.Data }");
   }
}