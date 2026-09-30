namespace RegexEngine.Moduls;

public abstract class OrRule:RegexRule
{
    private RegexRule _left;
    private RegexRule _right;
    
    protected OrRule(RegexRule left, RegexRule right)
    {
        _left = left;
        _right = right;
    }

    public override int Consume(string text, int position)
    {
        int leftConsumed = _left.Consume(text, position);
        if (leftConsumed != -1)
        {
            return leftConsumed;
        }
        return _right.Consume(text, position);
    }
}