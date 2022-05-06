using System;
using System.Collections.Generic;
using static Search;
using static Simple;
using static Config;
using static Guess;
using static p;

class Play
{
  public static void session()
  {
    Config s = new Config(); // s = settings
    p.rint("Enter amount of blanks: ");
    int blanks = Convert.ToInt32(Console.ReadLine());
    string guess = ""; string wrong_persist = "";
    List<string> matches = new List<string>();
    //////
    for(int i = 0; i < blanks; i++) {guess += s.getW();}
    guess = "y..t.";
    p.rint(guess);
    do
    {
      matches = Guess.guessWord(guess, s);
      p.rint(matches);
      char next = Guess.nextChar(guess,wrong_persist,s);
      p.rint(next);
      break;
    }
    while(matches.Count != 1);
    Simple.exit($"The word is {matches[0]}");
  }
}