class Assignment_38
{
    public static void Main()
    {
        Console.WriteLine("Enter a symbol:");
        char symbol = char.Parse(Console.ReadLine());
        if ((symbol > 'A') && (symbol < 'Z'))
        {
            Console.WriteLine("Capital letter");
        if ((symbol > 'a') && (symbol > 'z'))
            Console.WriteLine("Small letter");
        else
            if ((symbol >= 0) || (symbol <= 0))
                Console.WriteLine("Digit");
            else
                Console.WriteLine("Other symbol");
        }
    }
}