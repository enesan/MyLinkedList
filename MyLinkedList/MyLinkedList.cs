using System.Collections;
using System.Reflection.PortableExecutable;

namespace Algorithms;

public class MyLinkedList<T> : ICollection
{
    private MyLinkedListNode<T>? _head;
    private MyLinkedListNode<T>? _last;
    private int _count = 0;

    #region Constructors

    public MyLinkedList()
    {
    }

    public MyLinkedList(MyLinkedListNode<T> head)
    {
        AddLast(head);
    }

    public MyLinkedList(IEnumerable<T> collection)
    {
        foreach (var i in collection)
        {
            AddLast(new MyLinkedListNode<T>(i));
        }
    }

    #endregion
    
    public int Count
    {
        get => _count;
    }
    
    public MyLinkedListNode<T>? First
    {
        get => _head;
    }

    public MyLinkedListNode<T>? Last
    {
        get => _last;
    }

    public void AddLast(MyLinkedListNode<T> node)
    {
        if (_last != null)
        {
            node.List = this;
            node.Prev = _last;
            _last.Next = node;
            _last = node;
        }
        else if(_head != null)
        {
            node.List = this;
            node.Prev = _head;
            if(_head != null) _head.Next = node;
            _last = node;
        }
        else
        {
            _head = node;
        }

        _count++;
    }
    

    public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        newNode.Prev = node.Prev;
        newNode.Next = node;
        node.Prev!.Next = newNode;
        node.Prev = newNode;
        newNode.List = this;
        _count++;
    }
    
    public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        newNode.Prev = node;
        newNode.Next = node.Next;
        node.Next!.Prev = newNode;
        node.Next = newNode;
        newNode.List = this;
        _count++;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Array array, int index)
    {
        throw new NotImplementedException();
    }


    public bool IsSynchronized => false;
    public object SyncRoot => false;
    
    
    public class MyLinkedListEnumerator : IEnumerator, IEnumerator<T>
    {
        private T _current;

        private MyLinkedList<T> _list;
        private MyLinkedListNode<T>? _node;
        private int _postition = -1;

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        T IEnumerator<T>.Current => _current;

        public object Current { get; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}


