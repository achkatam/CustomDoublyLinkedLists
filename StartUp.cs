namespace DoublyLinkedList;

using System;

public class StartUp
{
    static void Main()
    {
        StackWIthLinkedList stack = new StackWIthLinkedList();
        stack.Add(1);
        stack.Add(2);
        stack.Add(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        return;
        SoftUniLinkedList linkedList = new SoftUniLinkedList();

        // Implementing the AddFirst method
        linkedList.AddFirst(new Node(1));
        linkedList.AddFirst(new Node(2));
        linkedList.AddFirst(new Node(3));
        linkedList.AddFirst(new Node(4));
        linkedList.AddFirst(new Node(5));

        while (linkedList.Count > 0)
        {
            Console.WriteLine(linkedList.RemoveFirst());
        }

        // Implementing the AddLast method
        //linkedList.AddLast(new Node(1));
        //linkedList.AddLast(new Node(2));
        //linkedList.AddLast(new Node(3));
        //linkedList.AddLast(new Node(4));
        //linkedList.AddLast(new Node(5));
        
        //Node currNode = linkedList.Head;

        //while (currNode is not null)
        //{
        //    Console.WriteLine(currNode.Value);

        //    currNode = currNode.Next;
        //}
    }
}