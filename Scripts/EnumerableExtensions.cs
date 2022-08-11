using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableExtensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Returns each element once at random.
        /// </summary>
        public static IEnumerable<T> RandomOnce<T>(this IEnumerable<T> enumerable)
        {
            var array = enumerable as T[] ?? enumerable.ToArray();
            
            foreach (int i in Enumerable.Range(0, array.Length).OrderBy(_ => UnityEngine.Random.value))
                yield return array[i];
        }

        /// <summary>
        /// Returns a specified amount of elements once at random.
        /// </summary>
        public static IEnumerable<T> RandomOnce<T>(this IEnumerable<T> enumerable, int count)
        {
            var array = enumerable as T[] ?? enumerable.ToArray();
            
            foreach (int i in Enumerable.Range(0, array.Length).OrderBy(_ => UnityEngine.Random.value).Take(count))
                yield return array[i];
        }

        /// <summary>
        /// Returns a random element.
        /// </summary>
        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            var array = enumerable as T[] ?? enumerable.ToArray();

            if (array.Length == 0)
                return default;

            return array[UnityEngine.Random.Range(0, array.Length)];
        }

        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }
    }
}