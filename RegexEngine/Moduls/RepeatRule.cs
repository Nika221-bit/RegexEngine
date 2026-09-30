using System.Text.RegularExpressions;

namespace RegexEngine.Moduls;

public class RepeatRule : RegexRule
{
    private RegexRule _innerRule;
    private int _min;
    private int _max;
    
    public RepeatRule(RegexRule innerRule, int min = 0, int max = int.MaxValue)
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
        
        if (matchCount < _min)
        {
            return -1;
        }
      
        return totalConsumed;
    }
}