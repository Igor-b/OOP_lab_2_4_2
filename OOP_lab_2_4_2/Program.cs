using System;

namespace OOP_lab_2_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = 0.5; x <= 4.5; x += 0.4)
            {
                double y = Math.Log(x);
                Console.WriteLine("x = {0:f1} y = {1:f4}", x, y);
            }
        }
    }
}
