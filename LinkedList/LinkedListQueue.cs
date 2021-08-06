﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListQueue
    {
        Node<int> head = null;
        internal void Enqueue(int data)
        {
            Node<int> node = new Node<int>(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("{0} is inserted into Queue", node.data);
            }
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} is inserted into Queue", node.data);
            }
        }

        internal void Display()
        {
            Node<int> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}