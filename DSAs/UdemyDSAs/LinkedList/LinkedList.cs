namespace UdemyDSAs.LinkedList;

public class LinkedList
{
    public Node? Head { get; private set; }
    public Node? Tail { get; private set; }
    public int Size { get; private set; }

    public LinkedList()
    {
        Head = null;
    }
    
    public LinkedList(Node head, Node tail)
    {
        Head = head;
        Tail = tail;
    }

    public void AddLast(int element)
    {
        var newNode = new Node(element, null);
        if (Head is null || Tail is null)
        {
            Head = newNode;
            Tail = Head;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }

        ++ Size;
    }
}