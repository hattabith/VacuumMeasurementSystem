//add .gitignore
//edit readme.md


Console.WriteLine();
Console.WriteLine("VIT2");
Console.WriteLine();

public class MyFirstClass : IMyInterface
{
    public MyFirstClass()
    {
        if (true)
        {
            ConsolePrintTwoLines();
        }
    }

    private static void ConsolePrintTwoLines()
    {
        Console.WriteLine("dfsdf");
        Console.WriteLine("!!!!!!");
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}