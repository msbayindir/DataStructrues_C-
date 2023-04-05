using System;
namespace DataStructruesLibs.LinkedList.SinglyLinkedList
{
	public class SinglyLinkedListNode<T>
	{
		public T Value { get; set; }
		public SinglyLinkedListNode<T> Next { get; set; }
		public SinglyLinkedListNode()
		{
		}

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
			return $"{Value}";
        }
    }
}

