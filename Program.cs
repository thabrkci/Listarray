using System.Collections;

Console.WriteLine("ArrayList");
ArrayList liste = new ArrayList();
//liste.Add("Taha");
//liste.Add(2);
//liste.Add('A');
//liste.Add(true);
//Console.WriteLine(liste[0]);
//foreach( var item in liste)
//Console.WriteLine(item);
//Addrange(Bir koleksiyona başka bir koleksiyon eklemek için kullanılır)
Console.WriteLine("***AddRange");
//string[] renkler = {"kırmızı","sarı","yeşil","mavi"};
//foreach( var item in renkler)
//Console.WriteLine(item);
List<int> sayılar =new List<int>(){1,3,5,7,8,9,99};
//foreach( var item in sayılar)
//Console.WriteLine(item);
liste.AddRange(sayılar);
foreach( var item in liste)
Console.WriteLine(item);
//Sort
Console.WriteLine("***SORT***");
liste.Sort();
foreach( var item in liste)
Console.WriteLine(item);
Console.WriteLine("***REVERSE***");
liste.Reverse();
foreach( var item in liste)
Console.WriteLine(item);
//Binary Search
Console.WriteLine("***BİNARY SEARCH");
Console.WriteLine(liste.BinarySearch(9));