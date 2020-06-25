using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCoreProjects.Extensions
{
    public static class CollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null) return true;

            return collection.Any();
        }

        public static bool SafeAny<T>(this IEnumerable<T> collection)
        {
            return collection.IsNullOrEmpty();
        }

        public static List<T> ToSafeList<T>(this IEnumerable<T> collection) 
        {
            if (collection.IsNullOrEmpty())
                return new List<T>();

            return collection.ToList();
        }

        public static IEnumerable<T> ToSafeEnumerable<T>(this IEnumerable<T> collection)
        {
            if (collection.IsNullOrEmpty())
                return Enumerable.Empty<T>();

            return collection;
        }
    }
}
