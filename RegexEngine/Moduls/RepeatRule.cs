using System.Text.RegularExpressions;

namespace RegexEngine.Moduls;

public abstract class RepeatRule : RegexRule
{
 
   private RegexRule _innerRule;
   private int _min;
   private int _max;
    
   protected RepeatRule(RegexRule innerRule, int min, int max)
   {
      _innerRule = innerRule;
      _min = min;
      _max = max;
   }
   
   public override int Consume(string text, int position)
   {
      int totalConsumed = 0;
      int currentPos = position;
      int matchCount = 0;

      while (matchCount < _max)
      {
         int Consumed = _innerRule.Consume(text, currentPos);

         if (Consumed == -1)
         {
            break;
         }
         totalConsumed += Consumed;
         currentPos += Consumed;
         matchCount++;
      }

      if (totalConsumed == _min)
      {
         return -1;
      }
      return totalConsumed;
   }


}