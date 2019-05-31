using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大二叉树654题
{

    //给定一个不含重复元素的整数数组。一个以此数组构建的最大二叉树定义如下：

    //二叉树的根是数组中的最大元素。
    //左子树是通过数组中最大值左边部分构造出的最大二叉树。
    //右子树是通过数组中最大值右边部分构造出的最大二叉树。
    //通过给定的数组构建最大二叉树，并且输出这个树的根节点。
    //    输入: [3,2,1,6,0,5]
    //输入: 返回下面这棵树的根节点：

    //      6
    //    /   \
    //   3     5
    //    \    / 
    //     2  0   
    //       \
    //        1
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

    class MyLinkList
    {
        public ListNode Head;
        public ListNode Last;

        public void ConstructMaximumBinaryTree(List<int> Input)
        {
            int InputMax = Input.Max();
            int IndexMax = 0;

            for (int i = 0; i < Input.Count; i++) {
                if (Input[i] == InputMax) {
                    IndexMax = i;
                    break;
                }
            }
            //去重
            for (int i = 0; i < Input.Count; i++) {
                if (Input[i] == InputMax) {
                    Input.Remove(InputMax);
                }
            }
            List<int> LeftList = new List<int>();

            for (int i = 0; i < IndexMax; i++) {
                LeftList.Add(Input[i]);
            }
            List<int> RightList = new List<int>();
            for (int i = IndexMax; i < Input.Count - 1; i++) {
                RightList.Add(Input[i]);
            }

        }


        private void ADDDDD(int value)
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

        public void Print()
        {
            ListNode printNode = this.Head;
            while (printNode != null) {
                Console.Write(printNode.Data + " ,");
                printNode = printNode.NextNode;
            }
        }
    }
    class ConstructMaximumBinaryTree
    {
        static void Main(string[] args)
        {
            MyLinkList f = new MyLinkList();
            f.ADDDDD(4);
            f.ADDDDD(5);
            f.ADDDDD(1);
            f.ADDDDD(9);
            f.Print();
            Console.WriteLine();
            //f.Delete(5);
            //f.print();
            f.Delete(4);
            f.Print();
            //f.Delete(5);
            //f.print();
            //f.Delete(5);
            //f.print();

            Console.ReadKey();
        }
    }
}
