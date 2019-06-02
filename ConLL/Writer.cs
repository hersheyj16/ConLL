using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLL
{
    //TODO: Delete this interface

    class StringWriter
    {
        public JLinkedListJL<String> JList { get; set; }
        public int Range { get; set; }

        public StringWriter(JLinkedListJL<String> List, int RangeArg)
        {
            JList = List;
            Range = RangeArg;
        }


        public void WriteRange()
        {
            for (int i = 0; i < Range; i++)
            {
                String value = JList.Tail.Value + "-" + i;
                JList.Add(value);
            }
        }
    }
}
