namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartPoint
    {
        public static void Main()
        {
            StringBuilder text = new StringBuilder("Extension substring method test");
            Console.WriteLine("Text: {0}", text);
            StringBuilder testSubstring = text.Substring(10, 10);
            Console.WriteLine("Substring: {0}", testSubstring);

            List<int> listSum = new List<int>{ 3, 4, 5 };
            Console.WriteLine("Items in collection:");
            foreach (var item in listSum)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int sum = listSum.Sum();
            Console.WriteLine("Sum: {0}", sum);

            List<int> listProduct = new List<int> { 3, 4, 5 };
            int product = listProduct.Product();
            Console.WriteLine("Product: {0}", product);

            List<int> listMax = new List<int> { 3, 4, 5 };
            int max = listMax.Max();
            Console.WriteLine("Max: {0}", max);

            List<int> listMin = new List<int> { 3, 4, 5 };
            int min = listMax.Min();
            Console.WriteLine("Min: {0}", min);

            List<int> listavarage = new List<int> { 3, 4, 5 };
            int avarage = listMax.Avarage();
            Console.WriteLine("Avarage: {0}", avarage);
        }
    }
}
