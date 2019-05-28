using System;

namespace ConLL
{
    internal class JLinkedListJL<T>
    {
        public JNode<T> Head { get; set; }
        public JNode<T> Tail { get; set; }

        internal void Add(JNode<T> node)
        {
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
        }
    }
}