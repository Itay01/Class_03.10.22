class Assignment_38
{
    public static void Main()
    {
        char letter1, letter2, letter3;
        Console.WriteLine("Enter three letters:");
        letter1 = char.Parse(Console.ReadLine());
        letter2 = char.Parse(Console.ReadLine());   
        letter3 = char.Parse(Console.ReadLine());
        if ((letter1 < letter2) && (letter2 < letter3))
        {
            Console.WriteLine("The letters are in positive order!");
        }
        else
        {
            if ((letter1 > letter2) && (letter2 > letter3))
                Console.WriteLine("The letters are in negative order!");
            else
                Console.WriteLine("The letters are not in order!");
        }
    }
}