using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ArrayList");
        ArrayList list = new ArrayList();
        
        // Commented out previous code
        // list.Add("Taha");
        // list.Add(2);
        // list.Add('A');
        // list.Add(true);
        // Console.WriteLine(list[0]);
        // foreach (var item in list)
        //     Console.WriteLine(item);

        // AddRange: Adds elements from a collection to the ArrayList
        Console.WriteLine("***AddRange");

        // Commented out previous code
        // string[] colors = {"red", "yellow", "green", "blue"};
        // foreach (var item in colors)
        //     Console.WriteLine(item);

        List<int> numbers = new List<int>() {1, 3, 5, 7, 8, 9, 99};
        // foreach (var item in numbers)
        //     Console.WriteLine(item);

        list.AddRange(numbers);
        foreach (var item in list)
            Console.WriteLine(item);

        // Sort: Sorts the elements in the entire ArrayList
        Console.WriteLine("***SORT");
        list.Sort();
        foreach (var item in list)
            Console.WriteLine(item);

        // Reverse: Reverses the order of the elements in the entire ArrayList
        Console.WriteLine("***REVERSE");
        list.Reverse();
        foreach (var item in list)
            Console.WriteLine(item);

        // BinarySearch: Searches for the specified object and returns the zero-based index of the first occurrence within the entire ArrayList
        Console.WriteLine("***BINARY SEARCH");
        Console.WriteLine(list.BinarySearch(9));
    }
}
