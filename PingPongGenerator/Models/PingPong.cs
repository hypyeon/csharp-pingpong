namespace PingPongGenerator.Models 
{
  public class PingPong 
  {
    public int value { get; }
    public PingPong(int num)
    {
      value = num;
    }
    public object[] GenerateArray()
    {
      object[] result = new object[value];
      for (int i = 0; i < value; i++)
      {
        result[i] = i + 1;
      }
      return result;
    }

    public object[] InsertString()
    {
      object[] result = GenerateArray();
      for (int i = 0; i < value; i ++)
      {
        if ((int)result[i] % 3 == 0 && (int)result[i] % 15 != 0)
        {
          result[i] = "ping";
        } 
        else if ((int)result[i] % 5 == 0 && (int)result[i] % 15 != 0)
        {
          result[i] = "pong";
        }
      }
      return result;
    }
  }
}