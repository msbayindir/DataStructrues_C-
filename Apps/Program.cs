using DataStructruesLibs.Array;
using DataStructruesLibs.LinkedList;
using DataStructruesLibs.LinkedList.SinglyLinkedList;
var list = new List<string>(){"Ali","Sefa","Ahmet","Ali","Mehmet","Ayse","Ali"};
var linkedList = new System.Collections.Generic.LinkedList<string>(list);
var root = new SinglyLinkedList<string>(list);
var nodeAli = root.FindLast("Ali");
Console.WriteLine(nodeAli.Next == null);

var nodeLinkedList = linkedList.FindLast("Ali");

Console.WriteLine(nodeLinkedList.Next == null);



