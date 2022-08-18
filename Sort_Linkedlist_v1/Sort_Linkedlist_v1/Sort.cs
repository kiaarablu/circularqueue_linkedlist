using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Linkedlist_v1
{
    internal class Sort
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node prev;
        }

        public class Operation
        {
            Node head = null;
            Node lastItem = null;

            public bool IsNull()
            {
                if (head == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Enqueue(int value)
            {
                if (IsNull())
                {
                    Node createdNode = new Node();
                    createdNode.value = value;
                    createdNode.next = createdNode;
                    createdNode.prev = createdNode;
                    head = createdNode;
                    lastItem = head;
                }
                else
                {
                    Node createdNode = new Node();
                    createdNode.value = value;

                    lastItem.next = createdNode;
                    createdNode.prev = head;
                    createdNode.next = head;
                    lastItem = createdNode;
                }
            }

            public void Dequeue()
            {
                if (!IsNull())
                {
                    if (lastItem == head)
                    {
                        head = null;
                    }
                    else
                    {
                        var temp = head.next;
                        head = null;
                        temp.prev = lastItem;
                        head = temp;
                        lastItem.next = temp;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }


            public void Print()
            {
                if (!IsNull())
                {
                    Console.WriteLine(head.value);
                    var temp = head.next;
                    while (temp != head)
                    {
                        Console.WriteLine(temp.value);
                        temp = temp.next;
                    }


                }
            }

        }

    }
}

