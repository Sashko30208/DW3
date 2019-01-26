using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void AddFirstTest()
        {
            LinkedList<string> List = new LinkedList<string>();
            DoubleLinkedNode<string> expected = new DoubleLinkedNode<string>();
            DoubleLinkedNode<string> actual = new DoubleLinkedNode<string>();


            DoubleLinkedNode<string> second = new DoubleLinkedNode<string> { Value = "second"};
            DoubleLinkedNode<string> first = new DoubleLinkedNode<string> { Value = "first", Prev=second };

            second.Next = first;
            List.AddFirst("first");
            List.AddFirst("second");

            expected = second;
            actual = List.First;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddFirstTestEasy()
        {
            LinkedList<string> List = new LinkedList<string>();
            DoubleLinkedNode<string> expected = new DoubleLinkedNode<string>();
            DoubleLinkedNode<string> actual = new DoubleLinkedNode<string>();            

            DoubleLinkedNode<string> first = new DoubleLinkedNode<string> { Value = "first" };
            List.AddFirst("first");

            expected = first;
            actual = List.First;
            Assert.AreEqual(expected.Value,actual.Value);
        }
    }
}