using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Ban ten gi?");
            string Ten = "";
            Ten = Console.ReadLine();
            Console.WriteLine("Ban may tuoi?");
            int Tuoi = 0;
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban {0} nam nay {1} tuoi.", Ten, Tuoi);
            Console.Read();
        }
    }
}
