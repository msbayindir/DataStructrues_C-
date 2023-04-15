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
            newNode.Prev = node;




        }
        public void AddBefore(DoublyLinkedListNode<T> node, T value)
        {
            if (Head == null)
            {
                AddFirst(value);
                return;
            }
            if (node == Head)
            {
                AddFirst(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            node.Prev.Next = newNode;
            newNode.Prev = node.Prev;
            newNode.Next = node;
            node.Prev = newNode;
            
        }
        //----------------------------------Add----------------------------------

        //----------------------------------Remove-------------------------------
        public DoublyLinkedListNode<T> Remove(T value)
        {
            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                var returnNode = Head.Prev;
                Head.Prev = null;
                return returnNode;
            }
            if (Tail.Value.Equals(value))
            {
                Tail = Tail.Prev;
                var returnNode = Tail.Next;
                Tail.Next = null;
                return returnNode;
            }
            var temp = Head;

            while (!temp.Value.Equals(value))
            {
                temp = temp.Next;
            if (!temp.Value.Equals(value) && temp == Tail) throw new Exception($"The Doubly list do not have The {value} ");
            }
            var prev = temp.Prev;
            prev.Next = temp.Next;
            temp.Next.Prev = prev;
            return temp;
        }

        //----------------------------------Remove-------------------------------



    }
}

