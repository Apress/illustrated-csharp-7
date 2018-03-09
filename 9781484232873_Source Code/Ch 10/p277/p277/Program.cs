using System;
using System.Collections.Generic;

public abstract class Shape { }

public class Square : Shape
{
   public double Side { get; set; }
}

public class Circle : Shape
{
   public double Radius { get; set; }
}

public class Triangle : Shape
{
   public double Height { get; set; }
}

class Program
{
   static void Main()
   {
      var shapes = new List<Shape>();

      shapes.Add(new Circle() { Radius = 7 });
      shapes.Add(new Square() { Side = 5 });
      shapes.Add(new Triangle() { Height = 4 });
      var nullSquare = (Square)null;
      shapes.Add(nullSquare);

      foreach (var shape in shapes)
      {
         switch (shape)                //Evaluate the type and/or value of variable shape.
         {
            case Circle circle:        //Equivalent to if(shape is Circle)
               Console.WriteLine($"This shape is a circle of radius { circle.Radius }");
               break;

            case Square square when square.Side > 10: //Matches only a subset of Squares
               Console.WriteLine($"This shape is a large square of side { square.Side }");
               break;

            case Square square:
               Console.WriteLine($"This shape is a square of side { square.Side }");
               break;

            case Triangle triangle:    // Equivalent to if(shape is Triangle)
               Console.WriteLine($"This shape is a triangle of side { triangle.Height }");
               break;

            // case Triangle triangle when triangle.Height < 5: //Compile error
               // Console.WriteLine($"This shape is a triangle of side { triangle.Height }");
               //break;

            case null:
               Console.WriteLine($"This shape could be a Square, Circle or a Triangle");
               break;

            default:
               throw new ArgumentException(
               message: "shape is not a recognized shape",
               paramName: nameof(shape));
         }
      }
   }
}