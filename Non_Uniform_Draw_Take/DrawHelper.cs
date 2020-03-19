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
            HashSet<int> drawn = new HashSet<int>();
            //TODO replacement false
            if (Weights.Count() != Items.Count())
                throw new Exception($"weights and items should be equal in length");
            if (Replacement==false && Take_number>Items.Count())
                throw new Exception($"theres a few items can't take many items");
            var sum = Weights.Sum();
            var Normalized_Weights = Weights.Select(x => x / sum).ToArray();
            Random rnd = new Random();
            double start = 0;
            for (int j = 0; j < Take_number; j++)
            {
                var current_rnd = rnd.NextDouble()*(1-start);
                for (int i = 0; i < Items.Count(); i++)
                {
                    if (drawn.Contains(i))
                        continue;
                    if (current_rnd <= Normalized_Weights[i])
                    {
                        yield return Items.ElementAt(i);
                        start += Normalized_Weights[i];
                        drawn.Add(i);
                        break;
                    }
                    current_rnd -= Normalized_Weights[i];
                }
            }
        }
    }
}
