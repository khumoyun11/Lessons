using System;
using System.Linq;
using lesson1.Solutions;

namespace lesson1
{
    class Program
    {
        static void Main()
        {
            var lab2 = new Lab2();
            lab2.Problem1();
            lab2.Problem2();
            lab2.Problem3();
            lab2.Problem4();
            lab2.Problem5();
            lab2.Problem6();
            lab2.Problem7();
            lab2.Problem8();
            lab2.Problem9();

            var lab3 = new Lab3();
            lab3.Problem1();
            lab3.Problem2();
            lab3.Problem3();
            lab3.Problem4();
            lab3.Problem5();
            lab3.Problem6();

            var lab4 = new Lab4();
            lab4.Problem1();
            lab4.Problem2();
            lab4.Problem3();
            lab4.Problem4();
            lab4.Problem5();
            lab4.Problem6();
            lab4.Problem7();
            lab4.Problem8();
            lab4.Problem9();
            lab4.Problem10();
            
        }

        static void Main1()
        {
            //string input = Console.ReadLine();
            //Console.WriteLine("You entered: " + input);

            var inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // foreach(string input in inputs)
            // {
            //     // int son = int.Parse(input);
            //     // Console.WriteLine(son * 10);

            //     int son = 0;
            //     bool parsed = int.TryParse(input, out son);
            //     if(parsed)
            //     {
            //         System.Console.WriteLine(son);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Not son");
            //     }
            // }

            var ints = inputs.Select(i =>
            {
                int son = int.Parse(i);
                Console.WriteLine(son);
                return son;
            }).ToList();
        }
    }
}
