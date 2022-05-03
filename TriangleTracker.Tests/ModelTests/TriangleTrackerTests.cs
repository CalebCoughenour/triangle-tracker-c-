using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_ChecksAllThreeSides_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_ChecksAllThreeSides_False()
    {
      Triangle testTriangle = new Triangle(2, 2, 5);
      Assert.AreEqual(false, testTriangle.IsTriangle());
    }
    [TestMethod]
    public void IsScalene_ChecksAllThreeSides_True()
    {
      Triangle testTriangle = new Triangle(2, 3, 5);
      Assert.AreEqual(true, testTriangle.IsScalene());
    }
    [TestMethod]
    public void IsScalene_ChecksAllThreeSides_False()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual(false, testTriangle.IsScalene());
    }
    [TestMethod]
    public void IsEquilateral_ChecksAllThreeSides_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual(true, testTriangle.IsEquilateral());
    }
    [TestMethod]
    public void IsEquilateral_ChecksAllThreeSides_False()
    {
      Triangle testTriangle = new Triangle(1, 2, 2);
      Assert.AreEqual(false, testTriangle.IsEquilateral());
    }
    [TestMethod]
    public void TriangleChecker_ChecksTypeNotTriangle_String()
    {
      Triangle testTriangle = new Triangle(2, 2, 5);
      Assert.AreEqual("This is not a triangle", testTriangle.TriangleChecker());
    }
    [TestMethod]
    public void TriangleChecker_ChecksTypeScalene_String()
    {
      Triangle testTriangle = new Triangle(2, 3, 5);
      Assert.AreEqual("This is a Scalene Triangle", testTriangle.TriangleChecker());
    }
    [TestMethod]
    public void TriangleChecker_ChecksTypeEquilateral_String()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual("This is an Equilateral Triangle", testTriangle.TriangleChecker());
    }
    [TestMethod]
    public void TriangleChecker_ChecksTypeIsosceles_String()
    {
      Triangle testTriangle = new Triangle(2, 3, 2);
      Assert.AreEqual("This is an Isosceles Triangle", testTriangle.TriangleChecker());
    }
  }
}