using System.Text.RegularExpressions;

namespace RegexEngine.Moduls;

public abstract class RepeatRule : RegexRule
{
    
    private Regex _innerRule;
    private int _max;
    private int _min;

    public RepeatRule(Regex innerRule, int max = int.MaxValue, int min = 0)
    {
        _innerRule = innerRule;
        _max = max;
        _min = min;
    }

    public override int Consume(string text, int position)
    {
        int totalConsumed = 0;
        int currentPos = position;
        int matchCount = 0;

        while (matchCount < _max)
        {
           int Consumed = _innerRule.Consume(text, currentPos);
        }
    }

    

}