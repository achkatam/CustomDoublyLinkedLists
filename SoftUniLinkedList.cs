namespace DoublyLinkedList;
public class SoftUniLinkedList
{
    public Node? Head { get; set; }
    //public Node? Tail { get; set; }

    public int Count { get; set; }

    //public void AddLast(Node node)
    //{
    //    if (Head is null)
    //    {
    //        Head = node;
    //        Tail = node;

    //        return;
    //    }

    //    Tail.Next = node;
    //    Tail = node;
    //}

    public void AddFirst(Node node)
    {
        node.Next = Head;
        Count++;
        Head = node;
    }

    public void AddFirst(int value)
    {
        AddFirst(new Node(value));
    }

    public int RemoveFirst() //same as .Pop method in Stack
    {
        Count--;
        int oldHead = Head.Value;
        Head = Head.Next;

        return oldHead;
    }
}