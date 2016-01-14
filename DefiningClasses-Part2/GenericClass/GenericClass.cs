using System;
using System.Text;

class GenericClass<T> where T : IComparable<T>
{
    private int nextIndex = 0;
    private T[] array;

    public GenericClass(int capacity)
    {
        this.array = new T[capacity];
    }

    public T this[int index]
    {
        get
        {
            //last position is not the same as array.Length because the whole array may not be full
            //we limit index to last position because we know that to this position array is full
            //and we don't want to get null value
            if (index > this.nextIndex - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range. Must be smaller than array's last position");
            }

            return this.array[index];

        }

        private set { this.array[index] = value; }
    }

    public void AddElement(T element)
    {
        if (this.nextIndex == this.array.Length)
        { 
            this.AutoGrow();
        }

        this.array[nextIndex] = element;
        nextIndex++;
    }

    public void ClearElements()
    {
        //make new array and this we clear the old
        this.array = new T[this.array.Length];
    }

    public void AddElementAtPosition(T element, int index)
    {
        //the whole array is full and there no cell to add new element
        if (this.nextIndex == this.array.Length)
        {
            //throw new IndexOutOfRangeException("Array is full and there no space for anothe element");  
            this.AutoGrow();
        }
        for (int i = this.nextIndex; i > index && i > 0; i--)
        {
            this.array[i] = this.array[i - 1];
        }

        this.array[index] = element;
        this.nextIndex++;
    }

    public void RemoveElementAtPosition(int index)
    {

        for (int i = index; i < this.nextIndex && i < this.array.Length - 1; i++)
        {
            this.array[i] = this.array[i + 1];
        }

        this.nextIndex--;
        this.array[nextIndex] = default(T);
    }

    public T Min()
    {
        if (this.nextIndex == 0)
        {
            throw new ArgumentException("There are no elements in GenericList");
        }

        T min = this.array[0];
        foreach (var element in this.array)
        {
            if (min.CompareTo(element) > 0)
            {
                min = element;
            }
        }

        return min;
    }

    public T Max()
    {
        if (this.nextIndex == 0)
        {
            throw new ArgumentException("There are no elements in GenericList");
        }

        T max = this.array[0];
        foreach (var element in this.array)
        {
            if (max.CompareTo(element) < 0)
            {
                max = element;
            }
        }

        return max;
    }

    //no one from outside can autho grow our array
    private void AutoGrow()
    {
        T[] newArray = new T[this.array.Length * 2];
        for (int i = 0; i < this.array.Length; i++)
        {
            newArray[i] = this.array[i];
        }

        this.array = newArray;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.nextIndex; i++)
        {
            sb.Append(this.array[i]);
            if (i < this.nextIndex -1)
            {
                sb.Append(", ");
            }
        }

        return sb.ToString();
    }
}
