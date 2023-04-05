using System;
using System.Collections;

namespace DataStructruesLibs.LinkedList.SinglyLinkedList
{
	public class SinglyLinkedList<T>:IEnumerable<T>

	{
		public SinglyLinkedListNode<T> Head { get; set; }
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(IEnumerable<T> collections)
        {
            foreach (var item in collections)
            {
                AddFirst(item);
            }

        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
                
        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var temp = Head;
            while(temp.Next!=null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;

        }
        public void AddAfter(SinglyLinkedListNode<T> node,T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            var temp = Head;
            while (temp.Next != node)
            {
                temp = temp.Next;
            }
            newNode.Next = node.Next;
            temp.Next.Next = newNode;


        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            var temp = Head;

            while (temp.Next != node)
            {
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;





        }

        public SinglyLinkedListNode<T> Find(T value)
        {
            var temp = Head;
            while (!temp.Value.Equals(value))
            {
                temp = temp.Next;
            }

            return temp;
        }
        public SinglyLinkedListNode<T> FindLast(T value)
        {
            var temp = Head;
            var lastNode = new SinglyLinkedListNode<T>();
            while (temp!=null)
            {
                if (temp.Value.Equals(value)) lastNode = temp;
                temp = temp.Next;
            }
            //if (temp.Value.Equals(value)) lastNode = temp;
            return lastNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SingleyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

