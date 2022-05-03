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
  }
}