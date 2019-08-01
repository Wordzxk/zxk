using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorNunit
{
    //进行双向链表单元测试
    [TestFixture(Category = "Two")]
    public class DLinkedListTest
    {
        [Test]
        public void HandTest()
        {
            //建一个链表
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);

            Assert.That(list.Head, Is.EqualTo(node));
            Assert.That(list.Tail, Is.EqualTo(node));

        }
        [Test]
        public void AddAfterTest()
        {
            //从中间添加一个
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);

            DLinkedListNode newnode = new DLinkedListNode();
            list.AddAfter(newnode, node);

            Assert.That(list.Head, Is.EqualTo(node));
            Assert.That(node.Next, Is.EqualTo(newnode));

            Assert.That(newnode.Previous, Is.EqualTo(node));
            Assert.That(list.Tail, Is.EqualTo(newnode));

        }
        [Test]
        public void AddAfterTestTwo()
        {
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);
            //再添加一个
            DLinkedListNode node_1 = new DLinkedListNode();
            list.AddAfter(node_1, node);

            DLinkedListNode newnode = new DLinkedListNode();
            list.AddAfter(newnode, node);

            Assert.That(list.Head, Is.EqualTo(node));
            Assert.That(node.Next, Is.EqualTo(newnode));

            Assert.That(newnode.Previous, Is.EqualTo(node));
            Assert.That(list.Tail, Is.EqualTo(node_1));

            Assert.That(node_1.Previous, Is.EqualTo(newnode));
            Assert.That(list.Tail, Is.EqualTo(node_1));
        }

    }
}
