using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    internal static class Extentions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source , Predicate<T> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TResulte> Choose<TSource , TResulte>(this IEnumerable<TSource> source, Func<TSource , TResulte> chooser)
        {
            foreach (var item in source)
            {
                //Deferred 
                yield return  chooser(item);
            }
        }
    }
}
