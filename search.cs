using System;
using static Simple;
using static Config;
using System.IO;

class Search
{
  public static string[] splitWordlist(string wl)
  {
    string file = File.ReadAllText(wl);
    string[] splitFile = file.Split("\n");
    return splitFile;
  }
  
  public static string[] match(string word,string charlist, string wordlist, char wildchar)
  {
    string[] matches = {};
    for(int i = 0; i < word.Length; i++)
    {
      if(Simple.find(word[i],charlist) != -1)
      {
        Console.WriteLine("Found "+word[i]+" in "+charlist);
      }
    }
    return matches;
  }
}