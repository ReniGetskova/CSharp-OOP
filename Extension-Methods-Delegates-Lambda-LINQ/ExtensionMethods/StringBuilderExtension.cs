namespace ExtensionMethods
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index + length > input.Length)
            {
                throw new ArgumentOutOfRangeException("Length of wanted substring is out of range");
            }
            for (int i = index; i <= index + length - 1 ; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }
    }
}
