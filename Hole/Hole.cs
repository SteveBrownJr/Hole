using System;
using System.Collections.Generic;

namespace Hole
{
    class Hole<T>
    {
        Node top;
        public int Count { get; private set; }
        public Hole()
        {
            top = null;
            Count = 0;
        }

        public void Push(T data)
        {
            top = new Node(data, top);
            Count++;
        }
        public T Pop()
        {
            if (top == null)
                throw new Exception("Empty");
            T data = top.data;
            top = top.next;
            Count--;
            return data;
        }
        public IEnumerable<T> PopAll()
        {
            List<T> outpost = new List<T>();
            while (Count!=0)
                outpost.Add(Pop());
            return outpost;
        }
        public T Peek()
        {
            if (top == null)
                throw new Exception("Empty");
            T data = top.data;
            return data;
        }
        public bool Contains(T data)
        {
            Node p = null;
            while (top!=null)
            {
                p = top;
                if (p.data.Equals(data))
                    return true;
            }
            return false;
        }
        public void Clear()
        {
            top = null;
        }
        class Node
        {
            public T data;
            public Node next;
            public Node(T data, Node next = null)
            {
                if (data == null)
                    throw new NullReferenceException();
                this.data = data;
                this.next = next;
            }
        }
    }
}
