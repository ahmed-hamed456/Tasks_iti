using System.Xml.Linq;

namespace linq_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var q1 = names.Where((s) => s.Length==3);
            foreach (var name in q1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==============================");

            var q2=names.Where((s) => s.Contains('a')|| s.Contains('A')).OrderBy((s=>s.Length));
            foreach (var name in q2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==============================");
            

        }
    }
}