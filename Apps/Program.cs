using DataStructruesLibs.Array;
using DataStructruesLibs.LinkedList;
using DataStructruesLibs.LinkedList.DoublyLinkedList;
using DataStructruesLibs.LinkedList.SinglyLinkedList;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

var list = new List<string>(){"Sefa","Ahmet","Ali","Mehmet","Ayse"};


var a = new DoublyLinkedList<int>();

a.AddFirst(1);
a.AddFirst(2);
a.AddFirst(3);
a.AddFirst(4);
a.AddAfter(a.Head, 5);
a.AddBefore(a.Head.Next, 6);


Console.WriteLine(a.Head.Next);

