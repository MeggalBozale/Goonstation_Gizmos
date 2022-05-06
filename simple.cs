using System;
//using Environment;

class Simple
{
  public static void exit(string reason)
  {
    Console.WriteLine(reason);
    Environment.Exit(0);
  }
  public static int find(string item,string[] list)
  { // Find a string in a string array
    for(int i = 0; i < list.Length; i++)
    {if (list[i].Equals(item)){return i;}}
    return -1;
  }
  public static int find(char ch,string str)
  {
    for(int i = 0;i < str.Length;i++)
    {if(str[i].Equals(ch)){return i;}}
    return -1;
  }
}