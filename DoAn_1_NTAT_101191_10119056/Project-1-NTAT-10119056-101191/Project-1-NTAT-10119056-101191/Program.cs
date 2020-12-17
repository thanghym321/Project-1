using System;
using Project_1_NTAT_10119056_101191.Presenation;
using System.Text;


namespace Project_1_NTAT_10119056_101191
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Menu doan1 = new Menu();
            doan1.MenuChinh();
            Console.ReadKey();
        }
    }
}
