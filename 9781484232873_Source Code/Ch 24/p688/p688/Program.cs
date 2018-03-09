#define DemoVersionWithoutTimeLimit
using System;

class demo
{
   static void Main()
   {
      const int intExpireLength = 30;
      string strVersionDesc = null;
      int intExpireCount = 0;

#if DemoVersionWithTimeLimit
      intExpireCount = intExpireLength;
      strVersionDesc = "This version of Supergame Plus will expire in 30 days";

#elif DemoVersionWithoutTimeLimit
      strVersionDesc = "Demo Version of Supergame Plus";

#elif OEMVersion
      strVersionDesc = "Supergame Plus, distributed under license";

#else
      strVersionDesc = "The original Supergame Plus!!";
#endif
      Console.WriteLine( strVersionDesc );
   }
}