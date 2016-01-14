using System;

class GenericClassTest
{
    public static void Main()
    {
        GenericClass<int> arrayElements = new GenericClass<int>(9);
        arrayElements.AddElement(5);
        arrayElements.AddElement(6);
        arrayElements.AddElement(7);
        arrayElements.AddElement(8);
        arrayElements.AddElement(9);
        arrayElements.AddElement(10);

        arrayElements.RemoveElementAtPosition(2);

        arrayElements.AddElementAtPosition(100, 2);
        arrayElements.AddElementAtPosition(101, 2);
        arrayElements.AddElementAtPosition(102, 2);
        arrayElements.AddElementAtPosition(103, 2);

        
        arrayElements.AddElementAtPosition(-104, 2);
        Console.WriteLine(arrayElements);

        Console.WriteLine(arrayElements.Min());
        Console.WriteLine(arrayElements.Max());
    }
}
