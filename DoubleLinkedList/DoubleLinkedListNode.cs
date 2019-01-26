using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        DoubleLinkedNode<T> Next { get; set; }
        DoubleLinkedNode<T> Prev { get; set; }
    }
    /// <summary>
    /// An unit of Double Linked List
    /// </summary>
    /// <typeparam name="T">type of data</typeparam>
    public class DoubleLinkedNode<T>:IDoubleLinkedListNode<T>,IComparable<DoubleLinkedNode<T>>
    {
        public T Value { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }

        public int CompareTo(DoubleLinkedNode<T> other) => Next.CompareTo(other);

    }
   
}
