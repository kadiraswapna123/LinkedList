using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class UC_7_NodeWithValue30
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class LinkedList
    {
        Node head; 

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }

        public bool search(Node head, int x)
        {
            Node current = head; 
            while (current != null)
            {
                if (current.data == x)
                    return true; 
                current = current.next;
            }
            return false; 
        }

        public static void Main(String[] args)
        {

            // Start with the empty list
            LinkedList llist = new LinkedList();

            /*Use push() to construct below list
            50->40->30->20->10 */
            llist.push(10);
            llist.push(20);
            llist.push(30);
            llist.push(40);
            llist.push(50);

            if (llist.search(llist.head, 30))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
}
