using System;

class Node
{
    public Node? next;
    public int data;

    public Node(int data)
    {
        this.data = data;
    }
}

class LinkList
{
    public Node? head;

    public void InsertAddFirst(int data)
    {
        if (head == null)
        {
            head = new Node(data);
            return;
        }
        var temp = head;
        Node newNode = new Node(data);
        head = newNode;
        newNode.next = temp;
    }

    public void InsertAtLast(int data)
    {
        if (head == null)
        {
            head = new Node(data);
            return;
        }
        var newNode = new Node(data);
        var temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void DeleteFirst()
    {
        if (head == null)
        {
            Console.WriteLine("empty");
        }
        head = head.next;
    }

    public void DeleteLast()
    {
        if (head == null)
        {
            Console.WriteLine("empty");
            return;
        }
        if (head.next == null)
        {
            head = null;
            return;
        }
        Node secondlast = head;
        Node lastNode = head.next;
        while (lastNode.next != null)
        {
            lastNode = lastNode.next;
            secondlast = secondlast.next;
        }
        secondlast.next = null;
    }

    public void InsertMiddleValue(int value)
    {
        if (head == null)
        {
            Console.WriteLine("empty");
            return;
        }
        if (head.data == value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            return;
        }

        Node currentNode = head;
        Node previousNode = null;

        while (currentNode != null)
        {
            if (currentNode.data == value)
            {
                Node newNode = new Node(value);
                previousNode.next = newNode;
                newNode.next = currentNode;
                return;
            }

            previousNode = currentNode;
            currentNode = currentNode.next;
        }

        // If the value is not found in the linked list
        Console.WriteLine("Value not found in the list");
    }

    public void DeleteMiddleValue(int value)
    {
        if (head == null)
        {
            Console.WriteLine("empty");
            return;
        }

        // If the value is found in the head node, update head and return
        if (head.data == value)
        {
            head = head.next;
            return;
        }

        Node currentNode = head;
        Node previousNode = null;

        // Traverse the linked list to find the node with the desired value
        while (currentNode != null)
        {
            if (currentNode.data == value)
            {
                // Update the previous node's next reference to skip the current node
                previousNode.next = currentNode.next;
                return;
            }

            // Move to the next node
            previousNode = currentNode;
            currentNode = currentNode.next;
        }

        // If the value is not found in the linked list
        Console.WriteLine("Value not found in the list");
    }

    public void Traversal()
    {
        if (head == null)
        {
            Console.WriteLine("empty List");
            return;
        }

        var temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
    // ... (previous code remains the same) ...


    // ... (previous code remains the same) ...

    public void InsertAtIndex(int index, int data)
    {
        if (index < 0)
        {
            Console.WriteLine("Invalid index. Index must be non-negative.");
            return;
        }

        if (index == 0)
        {
            InsertAddFirst(data);
            return;
        }

        Node currentNode = head;
        int currentIndex =1;

        while (currentNode != null)
        {
            if (currentIndex == index)
            {
                Node newNode = new Node(data);
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                return;
            }

            currentIndex++;
            currentNode = currentNode.next;
        }

        // If the index is greater than the length of the list, insert at the end
        if (currentIndex == index)
        {
            Node newNode = new Node(data);
            currentNode.next = newNode;
            return;
        }

        Console.WriteLine("Index out of range.");
    }

    // ... (previous code remains the same) ...


}

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkList();
        list.InsertAddFirst(5);
        list.InsertAtLast(1);
        list.InsertAddFirst(6);
        list.InsertAddFirst(2);
        list.InsertAtLast(3);
        list.InsertAtIndex(3, 8);    
        list.DeleteMiddleValue(5);
        list.Traversal();
    }
}

