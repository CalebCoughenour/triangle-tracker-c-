<!-- 1. Should correctly collect 3 numbers as input from user -->
2. Should determine if 3 entered numbers create a triangle(any two sides added are greater than third side)
3. Should check if no sides are equal, if true return Scalene
4. Should check if all sides are equal, if true return Equilateral
5. If branch is run through with no checks, return Isosceles

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