namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number Of Day : ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine($"Today is :{week__Days.Saturday}");
                    break;
                case 2:
                    Console.WriteLine($"Today is :{week__Days.Sunday}");
                    break;
                case 3:
                    Console.WriteLine($"Today is :{week__Days.Monday}");
                    break;
                case 4:
                    Console.WriteLine($"Today is :{week__Days.Tuesday}");
                    break;
                case 5:
                    Console.WriteLine($"Today is :{week__Days.Thursday}");
                    break;
                case 6:
                    Console.WriteLine($"Today is :{week__Days.Wednesday}");
                    break;
                case 7:
                    Console.WriteLine($"Today is :{week__Days.Friday}");
                    break;
                default:
                    Console.WriteLine("Enter Numbers between 1 and 7.");
                    break;
            }
        }
    }
}