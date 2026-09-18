namespace RegexEngine.Moduls;

public class DigitRule : RegexRule
{
    public override int Consume(string text, int position)
    {
        if (position >= text.Length || !char.IsDigit(text[position]))
        {
            return -1;
        }
        return 1;
    }
}