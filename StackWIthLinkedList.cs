namespace DoublyLinkedList;
class StackWIthLinkedList
{
    private SoftUniLinkedList linkedList = new SoftUniLinkedList();

    public int Count
    {
        get { return linkedList.Count; }
    }


    public void Add(int number)
    {
        linkedList.AddFirst(number);
    }

    public int Pop()
    {
       return linkedList.RemoveFirst();
    }
} 