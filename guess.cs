using System.IO;
using static Config;
using static p;
using System.Collections.Generic;

class Guess
{
  public static char nextChar(string word, string not, Config settings)
  { /* Takes all the characters that aren't in the
    word, adds them to what are already in the word,
    and then removes those characters from a char[]
    which orders characters in a wordlist from most 
    to least frequent. */
    char retChar = 't';
    not += settings.getn();
    p.rint(not);
    p.rint(Simple.find(word[0],not));
    for(int i = 0; i < word.Length; i++)
    {
      if(word[i] == settings.getW()){continue;}
      if(Simple.find(word[i],not) == -1){not += word[i];}
    }
    p.rint(not);
    return retChar;
  }
  
  public static List<string> guessWord(string guess, Config settings)
  { /* Searches a wordlist for a guess, accepting 
    case insensitivity, ability to ignore words with 
    certain characters, and use wildcards. */
    List<string> matches = new List<string>();
    string[] words = Search.splitWordlist(settings.getw());
    string not = settings.getn();
    foreach(string word in words)
    {
      if (word.Length != guess.Length) {continue;}
      bool goodWord = true;
      for(int i = 0; i < not.Length; i++)
      {
        int index = Simple.find(not[i],word);
        if(index != -1){goodWord = false; break;}
      }
      for(int i = 0; i < guess.Length; i++)
      {
        if(guess[i] == settings.getW()){continue;}
        if(guess[i] != word[i]){goodWord = false;break;}
      }
      if(goodWord == false){continue;}
      matches.Add(word);
    }
    return matches;
  }
}