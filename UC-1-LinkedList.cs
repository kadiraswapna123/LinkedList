using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class UC_1_LinkedList
    {
        public class Node
        {
            private Object data;

            public Node next { get; set; }

            public Node(Object data)
            {
                this.data = data;
            }

        }

        public class Linkedlist
        {
            Node head;

            public void Add(Node n)
            {
                n.Next = this.Head;
                this.Head = n;
            }
        }
    }
}
