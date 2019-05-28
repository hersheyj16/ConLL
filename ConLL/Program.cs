﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConLL
{
    class Program
    {
        public static void LinkedListCSDemo()
        {
            LinkedList<String> ll = new LinkedList<string>();
            string firstNode = "first";
            LinkedListNode<string> n1 = new LinkedListNode<string>("a");
            ll.AddLast(n1);
            ll.AddFirst(firstNode);
            ll.AddAfter(ll.First, "second");
            Console.WriteLine(ll.Count);

            foreach (string w in ll)
            {
                Console.WriteLine(w);
            }
        }

        public static void OldDemo()
        {
//            JNode<String> Head = CreateStringNode(5);
//            //Write on one thread
//            Writer WritingThread = new Writer(Head, 10);
//            Thread writer1 = new Thread(new ThreadStart(WritingThread.Write));
//            writer1.Start();
//            
//            Writer WritingThread2 = new Writer(Head, 20);
//            Thread writer2 = new Thread(new ThreadStart(WritingThread2.Write));
//            writer2.Start();
//            
//            //Read on another Thread
//            Reader ReadingThread = new Reader(Head);
//            Thread reader1 = new Thread(new ThreadStart(ReadingThread.Read));
//            reader1.Start();
//            
//            Thread reader2 = new Thread(new ThreadStart(ReadingThread.Read));
//            reader2.Start();
//            
//            writer1.Join();
//            writer2.Join();
//            reader1.Join();
//            reader2.Join();
        }

        static void Main(string[] args)
        {
            JLinkedListJL<String> JenList = new JLinkedListJL<string>();
            JNode<String> n1 = new JNode<string>("Tigs");
            JNode<String> n2 = new JNode<string>("Husky");
            JNode<String> n3 = new JNode<string>("BooButter");

            JenList.Add(n1);
            JenList.Add(n2);
            JenList.Add(n3);

            Utils.TraverseNode(JenList.Head);
        }




    }
}

