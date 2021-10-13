using System;

namespace lesson2
{
    class Program
    {
        static void Main()
        {
        // int n = int.Parse(Console.ReadLine()) + 1;

        //     int sum = 0;

        //     while(n-->0)
        //     {
        //         sum+=n;
        //     }
        //     Console.WriteLine($"{sum}");

        // for(int i = 0; i<= n; i++)
        // {
        //     sum+=n;
        // }
        // Console.WriteLine($"{sum}");

            var sonlar = new { 1, 2, 3, 4, 5, 6, 7 };
            foreach(int son in sonlar)
            {
                Console.WriteLine($"{son}");
            }
        }


        static void Main_Conditionals(string[] args)
        {
            int son = int.Parse(Console.ReadLine());

            // var message = son switch
            // {
            //     1 => "Siz bir kiritdingiz!",
            //     2 => "Siz ikki kiritdingiz!",
            //     3 => "Siz uch kiritdingiz!",
            //     4 => "Siz tort kiritdingiz!",
            //     _ => $"Siz {son} kiritdingiz";
            // };
            
            var message = son switch
            {
                // qavs qoyish va qoymaslik mumkun
                > 0 => "Siz musbat son kiritdingiz!",
                (< 0 ) => "Siz manfiy son kiritdingiz!",
                _ => "Siz noll kiritdingiz!",
            };

            Console.WriteLine(message);
            // int son = int.Parse(Console.ReadLine());

            // switch(son)
            // {
            //     case 1: Console.WriteLine("Siz bir kiritdingiz!"):break;
            //     case 2: Console.WriteLine("Siz ikki kiritdingiz!"):break;
            //     case 3: Console.WriteLine("Siz uch kiritdingiz!"):break;
            //     case 4: Console.WriteLine("Siz tort kiritdingiz!"):break;
            //     case 5: Console.WriteLine("Siz besh kiritdingiz!"):break;
            //     default: Console.WriteLine($"Siz {son} kiritdingiz!"):break;
            // }

            // int a = 10;

            // long b = 11;

            // string interpolation
            // System.Console.WriteLine($"{a} and {b}");
        }
    }
}
