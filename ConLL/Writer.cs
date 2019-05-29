using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLL
{
    interface IWriter<T>
    {
        void Write();

        void WriteRange();
    }

    class StringWriter : IWriter<String>
    {
        public JLinkedListJL<String> JList { get; set; }
        public int Range { get; set; }

        public StringWriter(JLinkedListJL<String> List, int RangeArg)
        {
            JList = List;
            Range = RangeArg;
        }

        public void Write()
        {
            JNode<String> n1 = new JNode<String>("test");
            JList.Add(n1);
        }

        public void WriteRange()
        {
            lock (JList.ListLock)
            {
                for (int i = 0; i < Range; i++)
                {
                    String value = JList.Tail.Value + "-" + i;
                    JNode<String> n = new JNode<string>(value);
                    JList.Add(n);
                }
            }
        }
    }
    class IntWriter : IWriter<int>
    {
        public JLinkedListJL<int> JList { get; set; }
        public int Range { get; set; }

        public IntWriter(JLinkedListJL<int> List, int RangeArg)
        {
            JList = List;
            Range = RangeArg;
        }

        public void Write()
        {
            JNode<int> n1 = new JNode<int>(0);
            JList.Add(n1);
        }

        public void WriteRange()
        {
            for (int i = 0; i < Range; i++)
            {            
                JNode<int> n = new JNode<int>(i);
                JList.Add(n);
            }
        }
    }
}
