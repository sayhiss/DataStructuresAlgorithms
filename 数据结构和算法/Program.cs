using System;

namespace 单链表
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkNode<int> node5 = new LinkNode<int>(5,null);
            LinkNode<int> node4 = new LinkNode<int>(4, node5);
            LinkNode<int> node3 = new LinkNode<int>(3, node4);
            LinkNode<int> node2 = new LinkNode<int>(2, node3);
            LinkNode<int> node1 = new LinkNode<int>(1, node2);
            LinkNode<int> result = LinkList<int>.ReverseLinkListRecursion(node1);
            Console.WriteLine("finish..");
            Console.ReadKey();
        }
    }
}
