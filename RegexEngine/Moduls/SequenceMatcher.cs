namespace RegexEngine.Moduls;

public class SequenceMatcher
{
    private List<RegexRule>_rules;
    
    public SequenceMatcher(List<RegexRule> rules)
    {
        _rules = rules;
    }

    public bool Validate(string text)
    {
        int currentPoint = 0;

        foreach (var Rule in _rules)
        {
            if (currentPoint >= text.Length)
            {
                return false;
            }
            
            int consumed = Rule.Consume(text,currentPoint);

            if (consumed == -1)
            {
                return false;
            }
            currentPoint += consumed;
        }
              return currentPoint == text.Length;
    }
    
    
}