using System;
using System.Collections.Generic;

public static class Kata
{


    public static List<string> Anagrams(string word, List<string> words)
    {

        List<string> toTheReturn = new List<string>();
        char[] wordToCharArray  = word.ToCharArray();
        Array.Sort(wordToCharArray);

        for (int i = 0; i < words.Count; i++)
        { 
            char[] listWordToCharArray = words[i].ToCharArray();
            Array.Sort(listWordToCharArray);

            var a = new string(wordToCharArray);
            var b = new string(listWordToCharArray);
            if (a == b)
            {
                toTheReturn.Add(words[i]);
            }

        }
        return toTheReturn;
    }
}