using System;
using System.Collections.Generic;
class p
{
  public static void rint(int i,string nl = "\n")
  {Console.Write(i+nl);}
  public static void rint(string i,string nl = "\n")
  {Console.Write(i+nl);}
  public static void rint(bool i,string nl = "\n")
  {Console.Write(i+nl);}
  public static void rint(double i,string nl = "\n")
  {Console.Write(i+nl);}
  public static void rint(char i,string nl = "\n")
  {Console.Write(i+nl);}
  public static void rint(string[] i,string nl = "\n")
  {foreach(string j in i){Console.Write(j+nl);}}
  public static void rint(List<string> i,string nl = "\n")
  {foreach(string j in i){Console.Write(j+nl);}}
}