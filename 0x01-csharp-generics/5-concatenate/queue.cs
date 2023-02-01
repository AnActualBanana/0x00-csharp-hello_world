using System;

public class Queue<T>
{
    private class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public void Enqueue(T value)
    {
        Node node = new Node(value);
        if (tail == null)
            head = tail = node;
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        if (head == null)
            tail = null;
        count--;
        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.value);
            current = current.next;
        }
        Console.WriteLine();
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }

        Node current = head;
        string result = string.Empty;
        while (current != null)
        {
            result += current.value;
            current = current.next;
        }

        return result;
    }
}
