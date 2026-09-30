namespace RegexEngine.Moduls;
using System.Collections.Generic;

public class RegexParser
{
   public static List<RegexRule> parse(string pattern)
   {
      List<RegexRule> rules = new List<RegexRule>();
      for (int i = 0; i < pattern.Length; i++)
      {
         char C = pattern[i];

         if (C == '\\' && i + 1 < pattern.Length)
         {
            char C2 = pattern[i + 1];
            if (C2 == 'd')
            {
               rules.Add(DigitRule());
            } 
         }
      }
   }
}