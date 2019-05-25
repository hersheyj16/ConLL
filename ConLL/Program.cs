using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = CreateNode(5);
            Node Tail = Utils.findTail(Head);

            Reader ReadingThread = new Reader(Head);

            Thread reader = new Thread(new ThreadStart(ReadingThread.Read));
            reader.Start();

            //Write on main thread
            Utils.AppendNodeHelper(Tail, 10);

            reader.Join();

        }

        private static Node CreateNode(int n)
        {
            Node head = new Node("Init Node");
            Node ans = head;
            for (int i = 0; i < n; i++)
            {
                Node nNode = new Node("node" + i);
                head.Next = nNode;
                head = head.Next;
            }
            return ans;
        }


    }
}

