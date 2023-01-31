using System;

public class Queue<T>
{
    private T[] items;
    private int startIndex = 0;
    private int endIndex = -1;

    public Queue()
    {
        items = new T[0];
    }

    public void Enqueue(T item)
    {
        if (endIndex + 1 >= items.Length)
        {
            T[] newArray = new T[items.Length + 10];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }

        items[++endIndex] = item;
    }

    public T Dequeue()
    {
        if (endIndex == -1)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        T item = items[startIndex];
        items[startIndex++] = default(T);

        if (startIndex > endIndex)
        {
            startIndex = 0;
            endIndex = -1;
        }

        return item;
    }

    public T Peek()
    {
        if (endIndex == -1)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return items[startIndex];
    }

    public int Count
    {
        get
        {
            return endIndex - startIndex + 1;
        }
    }

    public void Clear()
    {
        startIndex = 0;
        endIndex = -1;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        for (int i = 0; i < Count; i++)
        {
            array[i] = items[startIndex + i];
        }

        return array;
    }

    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
