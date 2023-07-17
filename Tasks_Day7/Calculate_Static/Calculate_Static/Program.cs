namespace Calculate_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inter The First Number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Inter The Second Number : ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Inter The Operator : ");
            char character = char.Parse(Console.ReadLine());

            switch (character)
            {
                case '+':
                    Console.WriteLine($"The Result Of Addition : {Calculate.Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"The Result Of Subtract :{Calculate.Sub(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"The Result Of Multiplication :{Calculate.Mul(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"The Result Of Divide :{Calculate.Div(x, y)}");
                    break;
                case '%':
                    Console.WriteLine($"The Result Of Reminder :{Calculate.Reminder(x, y)}");
                    break;
            }

        }
    }
}
