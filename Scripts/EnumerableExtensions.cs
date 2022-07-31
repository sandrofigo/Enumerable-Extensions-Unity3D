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
            var list = enumerable.ToList();

            while (list.Count != 0)
            {
                int index = UnityEngine.Random.Range(0, list.Count);
                yield return list[index];
                list.RemoveAt(index);
            }
        }

        /// <summary>
        /// Returns a specified amount of elements once at random.
        /// </summary>
        public static IEnumerable<T> RandomOnce<T>(this IEnumerable<T> enumerable, int count)
        {
            var list = enumerable.ToList();

            if (count > list.Count)
                throw new ArgumentOutOfRangeException(nameof(count), "The provided count is larger than the total number of items.");

            while (count > 0)
            {
                int index = UnityEngine.Random.Range(0, list.Count);
                yield return list[index];
                list.RemoveAt(index);
                count--;
            }
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