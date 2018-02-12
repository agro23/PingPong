namespace PongPong
{
  public class PingPong.Model
  // does this need to be model?
  {
    public static bool IsLeapYear(int year)
    {
      if (year % 100 == 0 && year % 400 != 0) {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }
  }
}
