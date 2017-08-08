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
    public void CountsTo_CountsToNumber_ListOfObject()
    {
      //Arrange
      List<object> expected = new List<object> {1, 2};

      //Act
      PingPongGenerator pingpong = new PingPongGenerator(2);
      List<object> actual = pingpong.CountsTo();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
      // CollectionAssert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void CountsTo_ThreeToPing_ListOfObject()
    {
      //Arrange
      List<object> expected = new List<object> {1, 2, "ping"};

      //Act
      PingPongGenerator pingpong = new PingPongGenerator(3);
      List<object> actual = pingpong.CountsTo();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountsTo_FiveToPong_ListOfObject()
    {
      //Arrange
      List<object> expected = new List<object> {1, 2, "ping", 4, "pong"};

      //Act
      PingPongGenerator pingpong = new PingPongGenerator(5);
      List<object> actual = pingpong.CountsTo();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountsTo_FifteenToPingPong_ListOfObject()
    {
      //Arrange
      List<object> expected = new List<object> {1, 2, "ping", 4, "pong", "ping", 7, 8, "ping", "pong", 11, "ping", 13, 14, "ping-pong"};

      //Act
      PingPongGenerator pingpong = new PingPongGenerator(15);
      List<object> actual = pingpong.CountsTo();
      // for (int i = 0; i < result.Count; i++)
      // {
      //   Console.WriteLine("Output: " + result[i]);
      // }
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    public void Dispose()
    {
      PingPongGenerator.ClearAll();
    }
  }
}
