using System;
using System.Collections.Generic;

public static class RobotNameGenerator 
{
    private static HashSet<string> usedNames = new HashSet<string>();
    private static Random random = new Random();
    public static string GenerateUniqueName() 
    {
        string name;
        do 
        {
            name = GenerateName();
        }
        while (!usedNames.Add(name));
        return name;
    }
    private static string GenerateName() 
    {
        char letter1 = (char)random.Next('A', 'Z' + 1);
        char letter2 = (char)random.Next('A', 'Z' + 1);
        int number = random.Next(0, 1000);
        return $"{letter1}{letter2}{number:D3}";
    }
}

public class Robot
{
    private string name;
    public string Name => name ??= RobotNameGenerator.GenerateUniqueName();
    public void Reset()
    {
        name = null;
    }
}