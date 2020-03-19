using System;
using System.Collections.Generic;
using System.Linq;

namespace Non_Uniform_Draw_Take
{
    class Program
    {
        static void Main(string[] args)
        {
            var selected = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Non_Uniform(new List<double>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 },5,Replacement:false);
            selected.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
