using DataStructruesLibs.Array;
using DataStructruesLibs.LinkedList;
using DataStructruesLibs.LinkedList.SinglyLinkedList;
using System.Collections.Generic;
var list = new List<string>(){"Sefa","Ahmet","Ali","Mehmet","Ayse"};

var linkedList = new System.Collections.Generic.LinkedList<string>(list);
var root = new SinglyLinkedList<string>(list);
foreach (var item in root)
{
    Console.WriteLine(item);
}


root.Remove("Sefa");
root.Remove("Ahmet");
root.Remove("aYŞE");
root.Remove("Mehmet");
root.Remove("Ayse");









//Console.WriteLine("--------------------------------------");
//foreach (var item in root)
//{
//    Console.WriteLine(item);
//}