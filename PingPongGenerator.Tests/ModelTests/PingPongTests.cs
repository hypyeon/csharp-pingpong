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
      int num = 8;
      PingPong newPingPong = new PingPong(num);
      int[] result = {1, 2, 3, 4, 5, 6, 7, 8};
      CollectionAssert.AreEqual(newPingPong.PingPongArray, result);
    }
  }
}