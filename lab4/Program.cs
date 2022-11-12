using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
   abstract public class Shape
    {
      protected string name;
      protected int perimert;
      protected int area;
      public string Name {
        get { return name; }
        set { name = value; }
      }
      public abstract void Area();
      public abstract void Perimeter();
    }
    public class Circle : Shape
    {
      private int radius;
      public int Radius { get { return radius; } set { radius = value; } }
      public Circle (string name , int radius)
      {
        this.Name = name;
        this.Radius = radius;
      }
      public override void Perimeter()
      {
        perimert= 2*radius;
        Console.WriteLine("периметр = "+perimert+"п");
      }
      public override void Area()
      {
        area= radius*radius;
        Console.WriteLine("площа = "+area+"п");
      }
      public static bool operator >(Circle c1, Circle c2)
      {
        return c1.Radius > c2.Radius;
      }
      public static bool operator <(Circle c1, Circle c2)
      {
        return c1.Radius < c2.Radius;
       }
    }
    public class Square : Shape
    {
      private int side;
      public int Side { get { return side; } set { side = value; } }
      public Square(string name, int side)
      {
        this.Name = name;
        this.side = side;
      }
      public override void Perimeter()
      {
        perimert = 4 * side;
        Console.WriteLine("периметр = " + perimert );
      }
      public override void Area()
      {
        area = side*side;
        Console.WriteLine("площа = " + area );
      }
      public static bool operator >(Square s1,Square s2)
      {

        return s1.Side > s2.Side;
        
      }
      public static bool operator <(Square s1, Square s2)
      {
        return s1.Side < s2.Side;
        

      }
    }
    static void Main(string[] args)
        {
      Console.WriteLine("нажміть Enter");
      Console.ReadKey();

      Circle c = new Circle("Коло 1",4);
      Console.WriteLine(c.Name);
      Console.WriteLine("Радіус = " + c.Radius);
      c.Perimeter();
      c.Area();

      Console.WriteLine();

      Circle c1 = new Circle("Коло 2", 6);
      Console.WriteLine(c1.Name);
      Console.WriteLine("Радіус = "+c1.Radius);
      c1.Perimeter();
      c1.Area();

      Console.WriteLine();

      Square s = new Square("Квадрат 1", 8);
      Console.WriteLine(s.Name);
      Console.WriteLine("Сторона = " + s.Side);
      s.Perimeter();
      s.Area();

      Console.WriteLine();

      Square s1 = new Square("Квадрат 2", 5);
      Console.WriteLine(s1.Name);
      Console.WriteLine("Сторона = " + s1.Side);
      s1.Perimeter();
      s1.Area();

      Console.WriteLine();

      if (c > c1)
      {
        Console.WriteLine("Площа найбільшого кола");
        c.Area();
      }
      else
      {
        Console.WriteLine("Площа найбільшого кола");
        c1.Area();
      }

      Console.WriteLine();

      if (s > s1)
      {
        Console.WriteLine("Площа найбільшого квадрата");
        s.Area();
      }
      else
      {
        Console.WriteLine("Площа найбільшого квадрата");
        s1.Area();
      }

      Console.ReadKey();
        }
    }
}
