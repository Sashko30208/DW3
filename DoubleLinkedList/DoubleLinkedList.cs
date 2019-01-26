using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    interface IDoubleLinkedList<T>
    {
        DoubleLinkedNode<T> First { get; set; }
        DoubleLinkedNode<T> Last { get; set; }
        void Reverse();
        //insert new DoubleLinkedListNode with given value at the start of the list
        void AddFirst(T value);
        //insert new DoubleLinkedListNode with given value at the end of the list
        void AddLast(T value);
    }
    public class LinkedList<T>:IDoubleLinkedList<T>,IComparable<LinkedList<T>>,IComparer
    {
        public DoubleLinkedNode<T> First { get; set; }
        public DoubleLinkedNode<T> Last { get; set; }

        DoubleLinkedNode<T> old = new DoubleLinkedNode<T>();

        public void Reverse()
        {
            if (First == null)
            {
                Console.WriteLine("The List is empty");
                Console.ReadKey();
            }
            else
            {
                DoubleLinkedNode<T> Temp = new DoubleLinkedNode<T> { Value = First.Value, Next = First.Next, Prev = First.Prev };
                Last = new DoubleLinkedNode<T> { Value = First.Value, Prev = First.Next, Next = First.Prev };

                First.Next = Temp.Prev;
                First.Prev = Temp.Next;
                while (Temp.Next != null)
                {
                    Temp = new DoubleLinkedNode<T> { Value = Temp.Next.Value, Next = Temp.Next.Next, Prev = Temp.Next.Prev };
                    First = First.Prev;
                    First.Next = Temp.Prev;
                    First.Prev = Temp.Next;
                }
            }

        }
        /// <summary>
        /// Insert value at the begining
        /// </summary>
        /// <param name="value">value with needed type of data</param>
        public void AddFirst(T value)
        {
            if (First != null)
            {
                old=First;
                old.Prev=
                First = new DoubleLinkedNode<T> { Value = value,Next=old};  
            }
            else
            {
                First = new DoubleLinkedNode<T> { Value = value, Prev = null, Next = null };
                Last = First;
            }
        }

        /// <summary>
        /// Insert value at the list's end
        /// </summary>
        /// <param name="value">value with needed type of data</param>
        public void AddLast(T value)
        {
            if(Last!=null)
            {
                old = Last;
                old.Next =
                Last = new DoubleLinkedNode<T> { Value = value, Prev = old };
            }
            else
            {
                Last = new DoubleLinkedNode<T> { Value = value, Next = null, Prev = null };
                First = Last;
            }
        }

        public int CompareTo(LinkedList<T> other) => First.CompareTo(other.First);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            LinkedList<T> list = (LinkedList<T>)obj;

            return (this.First == list.First) &&
                (this.Last == list.Last);
        }

        /// <summary>
        /// outputting of all values with begining at the first node
        /// </summary>
        /// <param name="first">the first node of list</param>
        public void WriteListFromTheFirst(DoubleLinkedNode<string> first)
        {
            DoubleLinkedNode<string> node = new DoubleLinkedNode<string>
            { Value = first.Value, Next = first.Next, Prev = first.Prev };
            uint counter = 0;
            while (true)
            {
                Console.WriteLine("{0} value is: {1}", counter, node.Value.ToString());
                counter++;
                if (node.Next == null)
                break;
                node = node.Next;               
            }
            Console.Write("*************\n");
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
