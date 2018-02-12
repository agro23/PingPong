using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void CheckPing_NumberDivisibleByThree_True()
    {
      Assert.AreEqual(true, PingPongs.CheckPing(9));
      Assert.AreEqual(true, PingPongs.CheckPing(12));
    }

    [TestMethod]
    public void CheckPing_NumberDivisibleByThree_False()
    {
      Assert.AreEqual(false, PingPongs.CheckPing(8));
      Assert.AreEqual(false, PingPongs.CheckPing(17));
    }

    [TestMethod]
    public void CheckPing_NumberDivisibleByFive_True()
    {
      Assert.AreEqual(true, PingPongs.CheckPong(10));
      Assert.AreEqual(true, PingPongs.CheckPong(15));
    }

    [TestMethod]
    public void CheckPing_NumberDivisibleByFive_False()
    {
      Assert.AreEqual(false, PingPongs.CheckPong(11));
      Assert.AreEqual(false, PingPongs.CheckPong(14));
    }

    [TestMethod]
    public void CheckPing_NumberDivisibleByThreeAndFive_True()
    {
      Assert.AreEqual(true, PingPongs.CheckPingPong(30));
      Assert.AreEqual(true, PingPongs.CheckPingPong(15));
    }

    [TestMethod]
    public void CheckPing_NumberDivisibleByThreeAndFive_False()
    {
      Assert.AreEqual(false, PingPongs.CheckPingPong(31));
      Assert.AreEqual(false, PingPongs.CheckPingPong(14));
    }
  }
}
