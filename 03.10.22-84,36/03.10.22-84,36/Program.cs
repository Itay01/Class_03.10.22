class Assignment_36
{
    public static void Main()
    {
        double num1, num2;
        Console.WriteLine("Enter two numbers:");
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        if (num1 / num2 > 1)
        { 
            Console.WriteLine("The first number is bigger!");
            Console.WriteLine(num2 + ", " + num1);
        }
        else
        {
            if (num1 == num2)
                Console.WriteLine("The numbers are equal!");
            else
                Console.WriteLine("The second number is bigger!");
            Console.WriteLine(num1 + ", " + num2);
        }
    }       
}