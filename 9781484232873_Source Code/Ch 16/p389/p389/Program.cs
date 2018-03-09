using System;

interface IInfo
{
   string GetName();
   string GetAge();
}

class CA : IInfo
{
   public string Name;
   public int Age;
   public string GetName() { return Name; }
   public string GetAge() { return Age.ToString(); }
}

class CB : IInfo
{
   public string First;
   public string Last;
   public double PersonsAge;
   public string GetName() { return First + " " + Last; }
   public string GetAge() { return PersonsAge.ToString(); }
}

class Program
{
   static void PrintInfo( IInfo item )
   {
      Console.WriteLine( "Name: {0}, Age {1}", item.GetName(), item.GetAge() );
   }

   static void Main()
   {
      CA a = new CA() { Name = "John Doe", Age = 35 };
      CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };

      PrintInfo( a );
      PrintInfo( b );
   }
}
