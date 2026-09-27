namespace RegexEngine.Moduls;

public abstract class AnyRule:RegexRule
{
    public override int Consume(string text, int position)
    {
        if (position <= text.Length)
        {
            return -1;
        }
        return 1;
    }
}