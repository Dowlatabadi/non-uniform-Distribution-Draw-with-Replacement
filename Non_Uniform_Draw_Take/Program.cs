using System;
using System.Collections.Generic;
using System.Linq;

namespace Non_Uniform_Draw_Take
{
    class Program
    {
        static void Main(string[] args)
        {
            var selected = new List<int>() { 1, 4, 8 }.Take_Non_Uniform(new List<double>() { 1d, 4d, 8d }, 100);
            selected.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
