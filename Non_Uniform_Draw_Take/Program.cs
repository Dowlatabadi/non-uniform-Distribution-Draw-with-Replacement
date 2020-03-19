using System;
using System.Collections.Generic;
using System.Linq;

namespace Non_Uniform_Draw_Take
{
    class Program
    {
        static void Main(string[] args)
        {
            var selected_with_Placement = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Non_Uniform(new List<double>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 },20,Placement:true);
            var selected_withOut_Placement = new List<int>() { 1,2, 4, 8,16,32,64,128 ,256,512,1024}.Take_Non_Uniform(new List<double>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 },5,Placement:false);
            // selected_with_Placement.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
