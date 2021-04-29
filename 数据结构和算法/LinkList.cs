using System;
using System.Collections.Generic;
using System.Text;

namespace 单链表
{
    class LinkNode<T>
    {
        public T Data;
        public LinkNode<T> Next;
        public LinkNode(T t, LinkNode<T> next)
        {
            Data = t;
            Next = next;
        }
    }

    class LinkList<T>
    {
        public LinkNode<T> Head;
        public LinkList(LinkNode<T> head)
        {
            Head = head;
        }

        /// <summary>
        /// 遍历反转单链表，思路:遍历每一个节点，使该节点的下一个节点为上一个遍历到的节点
        /// </summary>
        public static LinkNode<T> ReverseLinkList(LinkNode<T> node)
        {
            if (node == null || node.Next == null)
            {
                return node;
            }

            LinkNode<T> prev = null;
            LinkNode<T> next = null;
            LinkNode<T> curr = node;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;

                curr = next;
            }

            return prev;
        }
    }
}
