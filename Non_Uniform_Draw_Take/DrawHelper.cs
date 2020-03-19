using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Non_Uniform_Draw_Take
{
    public static class DrawHelper
    {
        public static IEnumerable<T> Take_Uniform<T>(this IEnumerable<T> Items, int Take_number)
        {
            Random rnd = new Random();
            return Items.OrderBy(x => rnd.Next()).Take(Take_number);
        }
        public static IEnumerable<T> Take_Non_Uniform<T>(this IEnumerable<T> Items,List<double> Weights, int Take_number,bool Replacement=true)
        {
            //TODO replacement false
            if (Weights.Count() != Items.Count())
                throw new Exception($"weights and items should be equal in length");
            var sum = Weights.Sum();
            var Normalized_Weights = Weights.Select(x => x / sum).ToArray();
            Random rnd = new Random();
            for (int j = 0; j < Take_number; j++)
            {
                var current_rnd = rnd.NextDouble();
                for (int i = 0; i < Items.Count(); i++)
                {
                    if (current_rnd <= Normalized_Weights[i])
                    {
                        yield return Items.ElementAt(i);
                        break;
                    }
                    current_rnd -= Normalized_Weights[i];
                }
            }
        }
    }
}
