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
        }

        private static Node CreateNode(int n)
        {
            Node head = new Node("Init Node");
            Node ans = head;
            for (int i = 0; i < n; i++)
            {
                Node nNode = new Node("node" + i);
                head.nextNode = nNode;
                head = head.nextNode;
            }
            return ans;
        }

    }
}

