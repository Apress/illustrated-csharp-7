using System;

class Publisher
{
   public event EventHandler SimpleEvent;
   public void RaiseTheEvent() { SimpleEvent( this, null ); }
}

class Subscriber
{
   public void MethodA( object o, EventArgs e ) { Console.WriteLine( "AAA" ); }
   public void MethodB( object o, EventArgs e ) { Console.WriteLine( "BBB" ); }
}

class Program
{
   static void Main()
   {
      Publisher  p = new Publisher();
      Subscriber s = new Subscriber();

      p.SimpleEvent += s.MethodA;
      p.SimpleEvent += s.MethodB;
      p.RaiseTheEvent();

      Console.WriteLine( "\r\nRemove MethodB" );
      p.SimpleEvent -= s.MethodB;
      p.RaiseTheEvent();
   }
}
