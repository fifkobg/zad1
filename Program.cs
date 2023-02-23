using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count:");
            int count = int.Parse(Console.ReadLine());
            List<Olympiada> olymp = new List<Olympiada>();
            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split();
                Olympiada olimp = new Olympiada(data[0], int.Parse(data[1]));
                olymp.Add(olimp);
            }
            foreach (var item in olymp)
            {
                item.Print();
            }
            olymp.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, olymp.Select(x=>x.Points)));

            IComparer comparator=new IComparer();
            olymp.Sort(comparator);

        }
    }
}
