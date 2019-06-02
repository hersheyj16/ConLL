using System;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace ConLL
{
    public class JLinkedListJL<T>
    {
        //Fix the JNode intern
        public JNode<T> Head { get; set; }
        public JNode<T> Tail { get; set; }
        
        public int Count { get; set; }
        public readonly object ListLock = new object();

        internal void Add(T val)
        {
            JNode<T> node = new JNode<T>(val);
            lock (ListLock)
            {
                Console.WriteLine("[!]{0} Adding {1}", Thread.CurrentThread.ManagedThreadId.ToString(), node.Value);

                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                    Count = 1;
                    return;
                }

                Count++;
                Tail.Next = node;
                Tail = Tail.Next;
            }
        }

        void Remove(T node)
        {
            Console.WriteLine("will do later");
            throw new NotImplementedException();

        }

        void Remove(int i)
        {
            Console.WriteLine("will do later");
            throw new NotImplementedException();
        }



        public JNode<T> GetAt(int i)
        {

            lock (ListLock)
            {
                if (i < 0 || i >= Count)
                {
                    throw new System.ArgumentException("Range is invalid.");
                }

                i--; // off by 1 error since index start at 0

                JNode<T> node = Head;
                while (node != null && i > 0)
                {
                    node = node.Next;
                    i--;
                }

                return node;
            }
        }
    }
}
