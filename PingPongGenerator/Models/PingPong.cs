namespace PingPongGenerator.Models 
{
  public class PingPong 
  {
    public int value { get; }
    public PingPong(int num)
    {
      value = num;
    }
    public int[] GenerateArray()
    {
      int[] result = new int[value];
      for (int i = 0; i < value; i++)
      {
        result[i] = i + 1;
      }
      return result;
    }
  }
}