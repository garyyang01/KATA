using System;
public class Kata
{
  public static string AverageString(string str)
  {
    string[] dict=new string[]{"zero","one","two","three","four","five","six","seven","eight","nine"};
    if(str=="")return"n/a";
    string[] input=str.Split(" ");
    int ans=0;
    for(int i=0;i<input.Length;i++){
      if(Array.IndexOf(dict,input[i])<0)return "n/a";
      ans+=Array.IndexOf(dict,input[i]);
    }
    return dict[ans/input.Length];
  }
}