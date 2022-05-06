class Config
{
  string n = "az"; // Chars not in word
  bool l = true; // Lowercase all
  string w = "wordlist.txt"; // Wordlist
  string c = "abcdefghijklmnopqrstuvwxyz"; // Charlist
  char W = '.'; // Wildcard

  public string getn(){return n;}
  public bool   getl(){return l;}
  public string getw(){return w;}
  public string getc(){return c;}
  public char   getW(){return W;}

  public void setn(string i){n=i;}
}