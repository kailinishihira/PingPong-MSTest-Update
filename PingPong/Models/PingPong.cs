using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _inputNumber;
    private static List<object> _counts = new List<object> {};

    public PingPongGenerator(int inputNumber)
    {
      _inputNumber = inputNumber;
      _counts = PingPongGenerator.CountsTo(inputNumber);
    }

    public int GetInputNumber()
    {
      return _inputNumber;
    }

    public void SetInputNumber(int newInputNumber)
    {
      _inputNumber = newInputNumber;
    }

    public List<object> GetList()
    {
      return _counts;
    }

    public static List<object> CountsTo(int index)
    {
      for (int i = 1; i <= index; i++)
      {
        if (i % 15 == 0)
        {
          _counts.Add("ping-pong");
        } else if (i % 3 == 0)
        {
          _counts.Add("ping");
        } else if (i % 5 == 0)
        {
          _counts.Add("pong");
        } else
        {
          _counts.Add(i);
        }
      }
      return _counts;
    }

    public static void ClearAll()
    {
      _counts.Clear();
    }

  }
}
