namespace RegexEngine.Moduls;

public class LiteralRule : RegexRule
{
    private char _targetChar;

    public LiteralRule(char targetChar)
    {
        _targetChar = targetChar;
    }

    public override int Consume(string text, int position)
    {
        if (position >= text.Length || text[position] != _targetChar)
        {
            return -1;
        }
        else
        
            return 1;
    }
}