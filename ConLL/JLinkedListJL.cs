using System;
using System.Threading;

namespace ConLL
{
    public class JLinkedListJL<T>
    {
        public JNode<T> Head { get; set; }
        public JNode<T> Tail { get; set; }
        public readonly object ListLock = new object();

        internal void Add(JNode<T> node)
        {
            
                Console.WriteLine("[!]{0} Adding {1}", Thread.CurrentThread.ManagedThreadId.ToString(), node.Value);

                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                    return;
                }

                Tail.Next = node;
                Tail = Tail.Next;
            
        }

        void Remove(JNode<T> node)
        {
            Console.WriteLine("will do later");
            throw new NotImplementedException();

        }



        public JNode<T> GetAt(int i)
        {
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