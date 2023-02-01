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
            next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }
}
