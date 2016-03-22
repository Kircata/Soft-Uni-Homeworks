using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Custom_LINQ_Extension_Methods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot <T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var result = new List<T>();
            foreach (T el in collection)
            {
                if (!condition(el))
                {
                    result.Add(el);
                }
            }
            return result;
        }
        public static TSelector Max <TSource, TSelector>
            (this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
             where TSelector : IComparable<TSelector> 
        {
            var result = new List<TSelector>();
            foreach (var el in collection)
            {
                result.Add(func(el));
            }

            TSelector max = result[0];
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i].CompareTo(max) > 0)
                {
                    max = result[i];
                }
            }

            return max;
        }
    }
}
