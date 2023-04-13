using DataStructruesLibs.Array;
using DataStructruesLibs.LinkedList;
using DataStructruesLibs.LinkedList.DoublyLinkedList;
using DataStructruesLibs.LinkedList.SinglyLinkedList;
using System.Collections.Generic;
var list = new List<string>(){"Sefa","Ahmet","Ali","Mehmet","Ayse"};


var a = new DoublyLinkedList<int>();

a.AddFirst(1);
a.AddFirst(2);

Console.WriteLine(a.Head.Next.Next == null);

