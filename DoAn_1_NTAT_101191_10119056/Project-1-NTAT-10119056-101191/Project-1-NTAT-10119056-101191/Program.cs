using System;
using Project_1_NTAT_10119056_101191.Presenation;
using System.Text;


namespace Project_1_NTAT_10119056_101191
{
    class Program
    {
        public static void MoDau()
        {
            Console.WriteLine("■■■");
            Console.WriteLine("■   ■■");
            Console.WriteLine("■     ■■ ");
            Console.WriteLine("■      ■■");
            Console.WriteLine("■       ■");
            Console.WriteLine("■       ■");
            Console.WriteLine("■       ■");
            Console.WriteLine("■      ■■");
            Console.WriteLine("■    ■■■");
            Console.WriteLine("■■■■");
        }
            static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Menu Menu = new Menu();
            Menu.MenuChinh();
            Console.ReadKey();
        }
    }
}
