namespace MathsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Maths maths = new Maths();
            Console.WriteLine("Enter 1 for Addition\nEnter 2 for Substration");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("Enter 1 number: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number:");
                        int b = int.Parse(Console.ReadLine());
                        int result = maths.Add(a, b);
                        Console.WriteLine($"Addition of {a} and {b} is: {result}");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter 1 number: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd Number:");
                        int b = int.Parse(Console.ReadLine());
                        int result = maths.Subtract(a, b);
                        Console.WriteLine($"Substraction of {a} and {b} is: {result}");
                    }
                    break;
                default: Console.WriteLine("Invalid Entry"); break;
            }
        }
    }
}