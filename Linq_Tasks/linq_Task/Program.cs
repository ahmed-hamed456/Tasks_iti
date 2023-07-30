using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linq_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int>() {2,4,6,7,1,4,2,9,1};

            var q1 =numbers.OrderBy((s=>s)).Distinct();

            foreach (var number in q1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("================================");

            var q2 =numbers.Select((s)=> new {Number=s,Multiply=s*s}) ;
            foreach (var number in q2)
            {
                Console.WriteLine(number);
            }


        }
    }
}