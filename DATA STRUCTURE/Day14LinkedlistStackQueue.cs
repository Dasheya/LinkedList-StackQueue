using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURE
{
    internal class Day14LinkedlistStackQueue
    {
        internal Node head; //new 
        private Node top;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);//NullrefrenceRxception
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        class LinkedListQueue
        {
            Node head = null;

            internal void Enqueue(int data)
            {
                Node node = new Node(data);
                if (head == null)
                    head = node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                    node.next = head;

                }
                Console.WriteLine("{0} inserted into queue ", node.data);

            }

            internal void Dequeue()
            {
                Node temp = this.head;
                if (temp.next == null)
                {
                    this.head = null;
                }
                while (temp.next != null)
                {
                    if (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    else
                    {
                        temp.next = null;
                        break;
                    }
                }
            }
        }
    }
}
