using System;

[AttributeUsage( AttributeTargets.Class )]
public sealed class ReviewCommentAttribute : System.Attribute
{
   public string Description { get; set; }
   public string VersionNumber { get; set; }
   public string ReviewerID { get; set; }
   public ReviewCommentAttribute( string desc, string ver )
   {
      Description = desc;
      VersionNumber = ver;
   }
}

[ReviewComment( "Check it out", "2.4" )]
class MyClass
{
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();   // Create an instance of the class.
      Type t = mc.GetType();        // Get the Type object from the instance.
      bool isDefined =              // Check the Type for the attribute.
         t.IsDefined( typeof( ReviewCommentAttribute ), false );

      if ( isDefined )
         Console.WriteLine( $"ReviewComment is applied to type { t.Name }" );
   }
}
