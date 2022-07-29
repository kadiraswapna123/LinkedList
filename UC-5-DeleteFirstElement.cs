using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class UC_5_DeleteFirstElement
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d; next = null;

            }
        }

        void deleteAlt()
        {
            if (head == null)
                return;

            Node prev = head;
            Node now = head.next;

            while (prev != null && now != null)
            {
                prev.next = now.next;

                now = null;

                prev = prev.next;
                if (prev != null)
                    now = prev.next;
            }
        }


        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Function to print linked list */
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /* Driver code*/
        public static void Main(String[] args)
        {
            LinkedList llist = new LinkedList();

            /* Constructed Linked List is
            1->2->3->null */
            llist.push(70);
            llist.push(30);
            llist.push(56);

            Console.WriteLine("Linked List before" +
                                "calling deleteAlt() ");
            llist.printList();

            llist.deleteAlt();

            Console.WriteLine("Linked List after" +
                                "calling deleteAlt() ");
            llist.printList();
        }
    }

}

