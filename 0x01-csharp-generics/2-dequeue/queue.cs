using System;

public class Queue<T>
{
    private class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    private Node head = null;
    private Node tail = null;
    private int count = 0;

    public void Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }

    public int Count()
    {
        return count;
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
        count--;
        return value;
    }
}
