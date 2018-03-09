using static System.Console;

public abstract class Investment
{
   public string Name { get; set; }
   public double MinPurchaseAmt { get; set; }
}

public class Stock : Investment { }

public class Bond : Investment { }

public class BankAccount : Investment { }

public class RealEstate : Investment { }

class Program
{
   static void Main()
   {
      var myStock = new Stock() { Name = "Tesla", MinPurchaseAmt = 1000 };
      var myBond  = new Bond()  { Name = "California Municipal", MinPurchaseAmt = 500 };
      var myBankAccount  = new BankAccount() { Name = "ABC Bank", MinPurchaseAmt = 10 };
      var myBankAccount2 = new BankAccount() { Name = "XYZ Bank", MinPurchaseAmt = 20 };
      var myRealEstate   = new RealEstate()  { Name = "My Vacation Home", MinPurchaseAmt = 100_000 };

      CheckInvestmentType( myStock );
      CheckInvestmentType( myBond );
      CheckInvestmentType( myBankAccount );
      CheckInvestmentType( myBankAccount2 );
      myBankAccount2 = null;
      CheckInvestmentType( myBankAccount2 );
      CheckInvestmentType( myRealEstate );
   }

   public static void CheckInvestmentType( Investment investment )
   {
      switch ( investment )
      {
         case Stock stock:
            WriteLine( $"This investment is a stock named {stock.Name}" );
            break;

         case Bond bond:
            WriteLine( $"This investment is a bond named {bond.Name}" );
            break;

         case BankAccount bankAccount when bankAccount.Name.Contains( "ABC" ):
            WriteLine( $"This investment is my ABC Bank account" );
            break;

         case BankAccount bankAccount:
            WriteLine( $"This investment is any bank account other than ABC Bank" );
            break;

         case null:
            WriteLine( "For whatever reason, this investment is null. " );
            break;

         default:
            WriteLine( "The default case will always be evaluated last. " );
            WriteLine( "Even if its position is not last." );
            break;
      }
   }
}