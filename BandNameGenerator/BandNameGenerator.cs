using System;
public class Kata
{
  public static string BandNameGenerator(string str)
  {
    if(string.IsNullOrEmpty(str))return "";
    // Happy coding
    if(str[0]==str[str.Length-1])
    {
      string last=(str.Remove(0,1)=="")?str:str.Remove(0,1);
      return ""+char.ToUpper(str[0])+str.Substring(1)+last;
    }
    else
    {
      return "The "+char.ToUpper(str[0])+str.Substring(1);
    }
  }
}