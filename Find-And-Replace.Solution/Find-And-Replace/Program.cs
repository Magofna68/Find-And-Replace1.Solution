using FindAndReplaceSolution;
using System;
using static System.Console;
public class Program
{
  public static void Main()
  {
    BackgroundColor = ConsoleColor.Red;
    Write("Welcome to ");
    BackgroundColor = ConsoleColor.Yellow;
    ForegroundColor = ConsoleColor.Blue;
    Write("Thunderdome");
    BackgroundColor = ConsoleColor.Red;
    ForegroundColor = ConsoleColor.White;
    Write("!\n");
    BackgroundColor = ConsoleColor.Black;
    Write("\n");
    WriteLine("We're gonna change some sentences!");
    Write("What sentence shall we use? : ");
    string sentence = ReadLine();
    WriteLine(sentence);
    Write("And what word should we replace? : ");
    string findWord = ReadLine();
    Write("And finally, what should we replace it with? : ");
    string replaceWord = ReadLine();
    string output = FindAndReplace.FindAndReplaceAll(sentence, findWord, replaceWord);
    ForegroundColor = ConsoleColor.Blue;
    Write(output);
  }
}