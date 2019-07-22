using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace XFormsAppDesignTwo.Extensions
{
    public static class Functions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return !(list?.Any() ?? false);
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> coll)
        {
            var c = new ObservableCollection<T>();
            if (coll.IsNullOrEmpty())
                return c;
            foreach (var e in coll)
                c.Add(e);
            return c;
        }

        public static void AddRange<TSource>(this ObservableCollection<TSource> source, IEnumerable<TSource> items)
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }
    }
}
