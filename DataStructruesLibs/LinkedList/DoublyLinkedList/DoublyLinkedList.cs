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
            var newNode = new DoublyLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
                return;
            }
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
        public void AddAfter(DoublyLinkedListNode<T> node,T value)
        {
            if (Head == null)
            {
                AddFirst(value);
                return;
            }
            if (node == Tail)
            {
                AddLast(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Next = node.Next;
            node.Next.Prev = newNode;
            node.Next = newNode;
            node = newNode.Prev;



        }
        //public void AddBefore(DoublyLinkedListNode<T> node, T value)
        //{
        //    if (Head == null)
        //    {
        //        AddFirst(value);
        //        return;
        //    }
        //    if (node == Head)
        //    {
        //        AddFirst(value);
        //        return;
        //    }
        //}
        //----------------------------------Add----------------------------------

    }
}

