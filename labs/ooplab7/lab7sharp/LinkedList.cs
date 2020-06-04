using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public struct LinkedList : IEnumerable
    {
        Node head;
        Node tail;
        int count; 

        public void Removenegative()
        {
            int counter = 1;
            foreach (double item in this)
            {
                if (item < 0)
                {
                    Remove(item);
                }
                counter++;
            }
        }
        public void AppendFirst(double data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        public bool Remove(double data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        public int NumberOfElementsBiggerThanAvg()
        {
            double avg = 0;
            foreach (double item in this)
            {
                avg = avg + item;
            }
            avg /= Count;

            int counter = 0;

            foreach (double item in this)
            {
                if (item > avg)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    public class Node
    {
        public Node(double data)
        {
            Data = data;
        }
        public double Data { get; set; }
        public Node Next { get; set; }
    }
}