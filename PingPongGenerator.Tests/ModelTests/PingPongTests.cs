using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator.Models;

namespace PingPongGenerator.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void PingPongConstructor_CreatesAnArrayOfNumbersFromOneToParenNum_PingPong()
    {
      PingPong newPingPong = new PingPong();
      Assert.AreEqual(typeof(PingPong), newPingPong.GetType());
    }
  }
}