namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException 
    {
        public InvalidRangeException(string message, T min, T max)
            :base(message)
        {
            this.Min = min;
            this.Max = max;
        }

        public T Min { get; private set; }

        public T Max { get; private set; }
    }
}
