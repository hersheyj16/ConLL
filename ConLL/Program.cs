using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = CreateNode(5);
            Node Tail = Utils.findTail(Head);

            //Read
            Utils.TraverseNode(Head);

            // Writes
            Utils.AppendNode(ref Tail, "5th");
            Utils.AppendNode(ref Tail, "6th");
            Utils.AppendNode(ref Tail, "7th");
            
            //Read
            Utils.TraverseNode(Head);

            // Writes
            Utils.AppendNode(ref Tail, "8th");
            Utils.AppendNode(ref Tail, "9th");
            Utils.TraverseNode(Head);
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

