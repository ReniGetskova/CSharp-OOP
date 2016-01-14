namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtension 
    {
        public static T Sum<T>(this List<T> collection)
        {
           T resultSum = default(T);
            foreach (var item in collection)
            {
                resultSum = (dynamic)resultSum + item;
            }

            return resultSum;
        }
        
        public static T Product<T>(this List<T> collection)
        {
            T resultProduct = (dynamic)1;
            foreach (var item in collection)
            {
                resultProduct = (dynamic)resultProduct * item;
            }

            return resultProduct;
        }

        public static T Max<T>(this List<T> collection) where T : IComparable
        {
            T max = collection[0];
            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Min<T>(this List<T> collection) where T : IComparable
        {
            T min = collection[0];
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Avarage<T>(this List<T> collection)
        {
            T avarage = default(T);
            avarage = (dynamic)collection.Sum() / collection.Count;
            return avarage;
        }
    }
}
