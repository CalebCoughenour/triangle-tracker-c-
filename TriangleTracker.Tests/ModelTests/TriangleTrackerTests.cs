using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_ChecksAllThreeSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }
  }
}