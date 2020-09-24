using System;

class Aula02
{
    public static void Main(string[] args)
    {
        Console.Write("BATATA");
        if (args.GetLength(0) > 0)
        {
            Console.Write(args.GetValue(0));
        }
    }
}