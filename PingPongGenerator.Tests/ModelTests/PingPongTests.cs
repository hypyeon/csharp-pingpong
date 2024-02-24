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
      object[] array = newPingPong.GenerateArray();
      CollectionAssert.AreEqual(new object[] {1, 2, 3, 4, 5}, array);
    }

    [TestMethod]
    public void InsertString_ReplacesThreeByStringPing()
    {
      PingPong newPingPong = new PingPong(3);
      object[] pingInserted = newPingPong.InsertString();
      CollectionAssert.AreEqual(new object[] {1, 2, "ping"}, pingInserted);
    }

    [TestMethod]
    public void InsertString_ReplacesFiveByStringPong()
    {
      PingPong newPingPong = new PingPong(5);
      object[] pingInserted = newPingPong.InsertString();
      CollectionAssert.AreEqual(new object[] {1, 2, "ping", 4, "pong"}, pingInserted);
    }
  }
}