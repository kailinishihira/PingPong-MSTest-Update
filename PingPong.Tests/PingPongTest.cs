using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest : IDisposable
  {
    [TestMethod]
    public void CountsTo_CountToNumber_Object()
    {
      //Arrange
      List<object> fullCount = new List<object> {1, 2};
      PingPongGenerator pingpong = new PingPongGenerator(2);

      //Act
      List<object> result = pingpong.GetList();

      //Assert
      CollectionAssert.AreEqual(fullCount, result);
    }

    [TestMethod]
    public void CountsTo_ThreeToPing_Object()
    {
      //Arrange
      List<object> fullCount = new List<object> {1, 2, "ping"};
      PingPongGenerator pingpong = new PingPongGenerator(3);

      //Act
      List<object> result = pingpong.GetList();

      //Assert
      CollectionAssert.AreEqual(fullCount, result);
    }

    [TestMethod]
    public void CountsTo_FiveToPong_Object()
    {
      //Arrange
      List<object> fullCount = new List<object> {1, 2, "ping", 4, "pong"};
      PingPongGenerator pingpong = new PingPongGenerator(5);

      //Act
      List<object> result = pingpong.GetList();

      //Assert
      CollectionAssert.AreEqual(fullCount, result);
    }

    [TestMethod]
    public void CountsTo_FifteenToPingPong_Object()
    {
      //Arrange
      List<object> fullCount = new List<object> {1, 2, "ping", 4, "pong", "ping", 7, 8, "ping", "pong", 11, "ping", 13, 14, "ping-pong"};
      PingPongGenerator pingpong = new PingPongGenerator(15);

      //Act
      List<object> result = pingpong.GetList();
      for (int i = 0; i < result.Count; i++)
      {
        Console.WriteLine("Output: " + result[i]);
      }
      //Assert
      CollectionAssert.AreEqual(fullCount, result);
    }

    public void Dispose()
    {
      PingPongGenerator.ClearAll();
    }
  }
}
