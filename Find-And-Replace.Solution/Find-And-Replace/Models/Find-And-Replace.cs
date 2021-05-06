using System.Collections.Generic;

namespace FindAndReplaceSolution
{
  public class FindAndReplace
  {
    public static string FindAndReplaceAll(string sentence, string findWord, string replaceWord)
    {
      string modifiedSentence = "";
      // look at each word in the sentence
      foreach (string word in sentence.Split(' '))
      {
        // check if the current word in the sentence is the same as the findWord
        if (findWord != word)
        {
          modifiedSentence += " " + word;
        }
        else if (findWord == word)
        {
          modifiedSentence += " " + replaceWord;
        }
      }
      return modifiedSentence.Remove(0, 1);
    }
  }
}
