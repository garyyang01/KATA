using System;
public class Kata
{
  public static int DeadAntCount(string ants)
  {
    if (ants==null)return 0;
    ants=ants.Replace("ant"," ");
    int[]ant=new int[]{0,0,0};
    for(int i=0;i<ants.Length;i++)
    {
      switch(ants[i])
      {
        case 'a':ant[0]++;break;
        case 'n':ant[1]++;break;
        case 't':ant[2]++;break;
        default: break;
      }
    }
    return Math.Max(Math.Max(ant[0],ant[1]),ant[2]);
  }
}