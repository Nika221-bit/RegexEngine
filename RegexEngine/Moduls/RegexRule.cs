namespace RegexEngine.Moduls;

public abstract class RegexRule
{
    public abstract int Consume(string text, int position);
}