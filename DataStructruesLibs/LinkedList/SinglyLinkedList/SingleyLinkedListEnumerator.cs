using System.Collections;

namespace DataStructruesLibs.LinkedList.SinglyLinkedList
{
    internal class SingleyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> _current;


        public SingleyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;

        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current!=null ? true:false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}