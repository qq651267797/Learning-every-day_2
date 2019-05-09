using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链表删除ListDelete
{
    //使其可以删除某个链表中给定的（非末尾）节点，你将只被给定要求被删除的节点。

    //现有一个链表 -- head = [4,5,1,9]，它可以表示为:
    //输入: head = [4,5,1,9], node = 5
    //输出: [4,1,9]
    //解释: 给定你链表中值为 5 的第二个节点，那么在调用了你的函数之后，该链表应变为 4 -> 1 -> 9.

    //输入: head = [4,5,1,9], node = 1
    //输出: [4,5,9]
    //解释: 给定你链表中值为 1 的第三个节点，那么在调用了你的函数之后，该链表应变为 4 -> 5 -> 9.

    //链表至少包含两个节点。
    //链表中所有节点的值都是唯一的。
    //给定的节点为非末尾节点并且一定是链表中的一个有效节点。
    //不要从你的函数中返回任何结果。

    public class ListNode
    {
        public int Data;
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode(int data)
        {
            this.Data = data;
        }
        public ListNode()
        {

        }
    }

    class LinkListDelete
    {
        public ListNode Head;
        public ListNode Last;

        public void Delete(int value){
            ListNode A = this.Head;
            ListNode node = new ListNode() { Data = value };
            if (A.Data == node.Data) {
                A.Data = A.NextNode.Data;
                A.NextNode = A.NextNode.NextNode;
                //A.NextNode = null;
                return;
            }

            while (A != null) { 
                if (A.NextNode.Data == node.Data) {
                    A.NextNode = A.NextNode.NextNode;
                    return;
                }
                else if (A.NextNode.NextNode == null) {
                    A.NextNode = null;
                }
                else {
                    A = A.NextNode;
                }
            }
        }
        public void ADDDDD(int value)
        {
            ListNode LastNode = this.Last;
            ListNode NewNode = new ListNode() { Data = value };

            if (this.Head == null) {
                this.Head = NewNode;
                this.Last = NewNode;
            }
            else {
                NewNode.NextNode = null;
                NewNode.PreviousNode = LastNode;
                LastNode.NextNode = NewNode;
                this.Last = NewNode;
            }
        }

        public void print()
        {
            ListNode printNode = this.Head;
            while (printNode != null) {
                Console.Write(printNode.Data + " ,");
                printNode = printNode.NextNode;
            }
        }
    }
    class ListDelete
    {
        static void Main(string[] args)
        {
            LinkListDelete f = new LinkListDelete();
            f.ADDDDD(4);
            f.ADDDDD(5);
            f.ADDDDD(1);
            f.ADDDDD(9);
            f.print();
            Console.WriteLine();
            //f.Delete(5);
            //f.print();
            f.Delete(4);
            f.print();
            //f.Delete(5);
            //f.print();
            //f.Delete(5);
            //f.print();

            Console.ReadKey();
        }
    }
}
