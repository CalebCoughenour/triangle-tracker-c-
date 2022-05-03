using System;
using System.Collections.Generic;
using Tracker;

public class Program {
  public static void Main() {
    Console.WriteLine("Please Enter Triangle Side 1");
    int Side1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please Enter Triangle Side 2");
    int Side2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please Enter Triangle Side 3");
    int Side3 = Convert.ToInt32(Console.ReadLine());
    Triangle newTriangle = new Triangle(Side1, Side2, Side3);
    Console.WriteLine(newTriangle.TriangleChecker());
  }
}