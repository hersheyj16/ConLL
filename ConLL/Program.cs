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
            Utils.TraverseNode(Head);
            Node Tail = Utils.findTail(Head);
            Utils.AppendNode(Tail, "5th");
            Tail = Utils.findTail(Tail);
            Utils.AppendNode(Tail, "6th");
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

