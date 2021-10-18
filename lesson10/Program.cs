using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node<string>("5");
            var node2 = new Node<int>(5);
            node2.Data = 4;
        }
    }
}
