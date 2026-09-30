namespace RegexEngine.Moduls;
using System.Collections.Generic;

public class RegexParser
{
   public static List<RegexRule> Parse(string pattern)
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
               rules.Add(new DigitRule());
            }
            else
            {
               rules.Add(new LiteralRule(C2));
            }

            i++;
               continue;
         }

         if (C == '.')
         {
            rules.Add(new AnyRule());
            continue;
         }

         if (C == '+')
         {
            RegexRule lastRule = rules[rules.Count - 1];
            rules.RemoveAt(rules.Count - 1);
            rules.Add(new RepeatRule(lastRule,1));
            continue;
         }

         if (C == '*')
         {
            RegexRule lastRule = rules[rules.Count - 1];
            rules.RemoveAt(rules.Count - 1);
            rules.Add(new RepeatRule(lastRule,0));
            continue;
            
         }
         rules.Add(new LiteralRule(C));
      }
      return rules;
     
   }
}