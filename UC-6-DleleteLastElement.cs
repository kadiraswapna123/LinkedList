using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class UC_6_DleleteLastElement
    {
        public class Node
        {
            public int data;
            public Node next;
        };

        static Node removeLastNode(Node head)
        {
            if (head == null)
                return null;

            if (head.next == null)
            {
                return null;
            }

            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;

            second_last.next = null;

            return head;
        }

        static Node push(Node head_ref, int new_data)
        {
            Node new_node = new Node();
            new_node.data = new_data;
            new_node.next = (head_ref);
            (head_ref) = new_node;
            return head_ref;
        }

        public static void Main(String[] args)
        {
            // Start with the empty list /
            Node head = null;

            // Use push() function to construct
            // the below list 70 . 30 . 56 /
            head = push(head, 56);
            head = push(head, 30);
            head = push(head, 70);

            head = removeLastNode(head);
            for (Node temp = head; temp != null; temp = temp.next)
                Console.Write(temp.data + " ");
        }
    }
}
}
