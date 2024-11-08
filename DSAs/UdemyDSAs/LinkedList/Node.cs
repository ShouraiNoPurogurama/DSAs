namespace UdemyDSAs.LinkedList;

public class Node
{
    public Node? Next { get; set; }
    public int Data { get; set; }

    public Node()
    {
        
    }
    
    public Node(int data, Node? next)
    {
        Next = next;
        Data = data;
    }
}