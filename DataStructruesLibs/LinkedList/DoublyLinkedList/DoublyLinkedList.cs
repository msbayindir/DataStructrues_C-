using System;
namespace DataStructruesLibs.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }


        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }
        //----------------------------------Add----------------------------------
        public void AddFirst(T value)
        {
            if(Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;

            if (Tail == null) Tail = Head;
        }
        public void AddLast(T value)
        {
            if(Tail == null)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);

            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
        //----------------------------------Add----------------------------------

    }
}

