// using System;

namespace Tracker
{
  public class Triangle
  {
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public bool IsTriangle()
    {
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2))) 
      {
        return false;
      }
      return true;
    }
    public bool IsScalene()
    {
      if ((Side1 != Side3) && (Side2 != Side3) && (Side1 != Side2))
      {
        return true;
      }
      return false; 
    }

    public bool IsEquilateral()
    {
      if ((Side1 == Side2) && (Side2 == Side3) && (Side1 == Side3))
      {
        return true;
      }
      return false;
    }

    public string TriangleChecker()
    {
      if (!IsTriangle())
      {
        return "This is not a triangle";
      }
      else if (IsScalene())
      {
        return "This is a Scalene Triangle";
      }
      else if (IsEquilateral())
      {
        return "This is an Equilateral Triangle";
      }
      return "This is an Isosceles Triangle";
    }
  }
}
