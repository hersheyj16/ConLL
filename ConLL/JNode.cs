using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLL
{

    public class JNode<T>
    {
        public T Value { get; set; }
        public JNode<T> Next { get; set; }
        public JNode<T> Previous { get; set; }
        public JNode(T value, JNode<T> next)
        {
            Value = value;
            this.Next = next;
        }

        public JNode(T value)
        {
            Value = value;
        }
    }
}
