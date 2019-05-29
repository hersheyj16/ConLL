using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace ConLL
{
    public class Reader<T>
    {
        public JLinkedListJL<T> JList { get; set; }

        public Reader(JLinkedListJL<T> jList)
        {
            JList = jList;
        }

        public void Read()
        {          
            Utils.TraverseNode(JList.Head);
        }
    }
}