using System;
using System.Threading;

namespace ConLL
{
    public class Utils
    {

        private static JNode<String> CreateStringNode(int n)
        {
            JNode<String> head = new JNode<String>("Init JNode");
            JNode<String> ans = head;
            for (int i = 0; i < n; i++)
            {
                JNode<String> nJNode = new JNode<String>("jNode" + i);
                head.Next = nJNode;
                head = head.Next;
            }
            return ans;
        }
    
        public static void TraverseNode<T>(JNode<T> jNode)
        {
            while (jNode != null)
            {

                Console.WriteLine("[!]{0} Reading {1}", Thread.CurrentThread.ManagedThreadId.ToString(), jNode.Value);
                jNode = jNode.Next;
            }
        }

        public static void AppendStringNode(ref JNode<String> tail, String val)
        {
            //Got some NPE exception
            try
            {
                Console.WriteLine("[#]{0} Writing. Appending a new jNode with val {1} to existing jNode {2}", 
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    val, tail.Value);
                tail.Next = new JNode<String>(val);
                tail = tail.Next;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        internal static JNode<T> findTail<T>(JNode<T> head)
        {
            while (head.Next != null)
            {
                head = head.Next;
            }

            return head;
        }
    }
}