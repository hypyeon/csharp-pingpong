using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator.Models;

namespace PingPongGenerator.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void PingPongConstructor_GetsANumber_PingPong()
    {
      PingPong newPingPong = new PingPong(5);
      Assert.AreEqual(typeof(PingPong), newPingPong.GetType());
    }

    [TestMethod]
    public void GenerateArray_CreatesAnArrayOfNumbersFromOneToParenNum()
    {
      PingPong newPingPong = new PingPong(5);
      int[] array = newPingPong.GenerateArray();
      CollectionAssert.AreEqual(new int[] {1, 2, 3, 4, 5}, array);
    }
  }
}