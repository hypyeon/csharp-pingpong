namespace PingPongGenerator.Models 
{
  public class PingPong 
  {
    public int[] PingPongArray { get; }
    public PingPong(int num)
    {
      PingPongArray = new int[num];
      for (int i = 0; i < num; i++)
      {
        PingPongArray[i] = i + 1;
      }
    }
  }
}