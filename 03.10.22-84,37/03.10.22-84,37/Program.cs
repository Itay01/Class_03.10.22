class Assignment_37
{
    public static void Main()
    {
        double balance;
        Console.WriteLine("Enter your bank account balance:");
        balance = double.Parse(Console.ReadLine());
        if (balance > 0)
        {
            Console.WriteLine("Your bank account balance is positive!");
        }
        else
        {
            if (balance == 0)
                Console.WriteLine("Your bank account balance is 0!");
            else
                Console.WriteLine("Your bank account balance is negative!");
        }
    }
}