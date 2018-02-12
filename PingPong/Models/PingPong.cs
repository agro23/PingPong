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
  }
}
