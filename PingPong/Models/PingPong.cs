using System.Collections.Generic;
using System;

namespace PingPong.Models
{
  public static class PingPongs
  // does this need to be model?
  {
    public static bool CheckPing(int num)
    {
      return num % 3 == 0;
    }

    public static bool CheckPong(int num)
    {
      return num % 5 == 0;
    }

    public static bool CheckPingPong(int num)
    {
      return num % 15 == 0;
    }

    public static List<string> GetRange(int num)
    {
      List<string> output = new List<string>();
      for (int i = 1; i <= num; i++) {
        output.Add(i.ToString());
      }
      return output;
    }

    public static List<string> GetPingPong(List<string> numbers)
    {
      for(int i = 0; i < numbers.Count; i++)
      {
        if (CheckPingPong(Int32.Parse(numbers[i])))
        {
          numbers[i] = "Ping-Pong";
        }
        else if (CheckPong(Int32.Parse(numbers[i])))
        {
          numbers[i] = "Pong";
        }
        else if (CheckPing(Int32.Parse(numbers[i])))
        {
          numbers[i] = "Ping";
        }
      }

      return numbers;
    }
  }
}
