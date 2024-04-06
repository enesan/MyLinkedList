namespace Algorithms;

public class MyLinkedListNode<T>
{
    public MyLinkedListNode<T>? Next { get; set; }
    public MyLinkedListNode<T>? Prev { get; set; }
    public T Item { get; set; }
    public MyLinkedList<T>? List { get; internal set; }

    public MyLinkedListNode(T item, MyLinkedList<T> list)
    {
        Item = item;
        List = list;
    }

    public MyLinkedListNode(MyLinkedListNode<T>? next, MyLinkedListNode<T>? prev, T item, MyLinkedList<T>? list)
    {
        Next = next;
        Prev = prev;
        Item = item;
        List = list;
    }

    public MyLinkedListNode( T item)
    {
        Item = item;
    }

    public override string ToString()
    {
        return Item.ToString();
    }
}