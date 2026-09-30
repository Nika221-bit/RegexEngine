using System;
using System.Collections.Generic;
using RegexEngine.Moduls; 

public class Program
{
    public static void Main()
    {
        string pattern1 = @"\d+KG"; 
        
        List<RegexRule> rules1 = RegexParser.Parse(pattern1);
        
        SequenceMatcher matcher1 = new SequenceMatcher(rules1);
        Console.WriteLine($"ტესტი 1: {pattern1} ");
        Console.WriteLine(matcher1.Validate("80KG"));  
        Console.WriteLine(matcher1.Validate("5KG"));    
        Console.WriteLine(matcher1.Validate("80K"));    
        
        string pattern2 = @"A.*B";
        
        List<RegexRule> rules2 = RegexParser.Parse(pattern2);
        SequenceMatcher matcher2 = new SequenceMatcher(rules2);

        Console.WriteLine($"\n--- ტესტი 2: {pattern2} ---");
        Console.WriteLine(matcher2.Validate("AB"));       
        Console.WriteLine(matcher2.Validate("A123B"));    
        Console.WriteLine(matcher2.Validate("AxyzB"));   
        Console.WriteLine(matcher2.Validate("A123"));   
    }
}