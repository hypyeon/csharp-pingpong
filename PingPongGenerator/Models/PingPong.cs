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
      object[] array = GenerateArray();
      for (int i = 2; i <= value; i += 3)
      {
        array[i] = "ping";
      }
      return array;
    }
  }
}