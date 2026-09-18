using System;
using System.Collections.Generic;
using RegexEngine.Moduls;

public class Program
{
    public static void Main()
    {
        List<RegexRule> rules = new List<RegexRule>
        {
            new DigitRule(),    
            new DigitRule(),    
            new LiteralRule('K'), 
            new LiteralRule('G')  
        };

        SequenceMatcher matcher = new SequenceMatcher(rules);

        Console.WriteLine(matcher.Validate("80KG")); 
        Console.WriteLine(matcher.Validate("75KG")); 
        Console.WriteLine(matcher.Validate("80LB"));  
        Console.WriteLine(matcher.Validate("A0KG")); 
        
        Console.WriteLine(matcher.Validate("80K"));   
        Console.WriteLine(matcher.Validate("800KG"));
    }
}