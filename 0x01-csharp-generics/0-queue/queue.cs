using System;

namespace QueueImplementation
{
    /// <summary>
    /// A generic class for creating Queue data structure
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue</typeparam>
    public class Queue<T>
    {
        private T[] elements;
        private int head;
        private int tail;
        private int count;

        /// <summary>
        /// Initializes a new instance of the Queue class that is empty and has the default initial capacity.
        /// </summary>
        public Queue()
        {
            elements = new T[0];
            head = 0;
            tail = -1;
            count = 0;
        }

        /// <summary>
        /// Gets the number of elements contained in the queue.
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Adds an object to the end of the queue.
        /// </summary>
        /// <param name="element">The object to add to the queue. The value can be null for reference types.</param>
        public void Enqueue(T element)
        {
            if (count == elements.Length)
            {
                T[] newElements = new T[elements.Length == 0 ? 4 : 2 * elements.Length];
                Array.Copy(elements, head, newElements, 0, count);
                elements = newElements;
                head = 0;
                tail = count - 1;
            }
            tail = (tail + 1) % elements.Length;
            elements[tail] = element;
            count++;
        }

        /// <summary>
        /// Removes and returns the object at the beginning of the queue.
        /// </summary>
        /// <returns>The object that is removed from the beginning of the queue</returns>
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("The queue is empty");

            T removed = elements[head];
            head = (head + 1) % elements.Length;
            count--;
            return removed;
        }

        /// <summary>
        /// Returns the object at the beginning of the queue without removing it.
        /// </summary>
        /// <returns>The object at the beginning of the queue</returns>
        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("The queue is empty");

            return elements[head];
        }

        /// <summary>
        /// Check the type of the elements in the queue.
        /// </summary>
        /// <returns>The type of the elements in the queue</returns>
        public Type CheckType()
        {
            return typeof(T);
        }
    }
}
