using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using String = System.String;

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
            JenList.Add("tiger");
        


            Reader<String> ReadingThread = new Reader<string>(JenList);
            Thread reader1 = new Thread(new ThreadStart(ReadingThread.Read));
            reader1.Start();


            //writting with a writer
            StringWriter WritingThread = new StringWriter(JenList, 10);
            Thread writer1 = new Thread(new ThreadStart(WritingThread.WriteRange));
            writer1.Start();


            Thread writer2 = new Thread(new ThreadStart(WritingThread.WriteRange));
            writer2.Start();


            Thread writer3 = new Thread(new ThreadStart(WritingThread.WriteRange));
            writer3.Start();

            Thread writer4 = new Thread(new ThreadStart(WritingThread.WriteRange));
            writer4.Start();

            Thread writer5 = new Thread(new ThreadStart(WritingThread.WriteRange));
            writer5.Start();

            writer1.Join();
            writer2.Join();
            writer3.Join();
            writer4.Join();
            writer5.Join();

            Thread reader2 = new Thread(new ThreadStart(ReadingThread.Read));
            reader2.Start();

            reader1.Join();
            reader2.Join();


        }
    }
}

