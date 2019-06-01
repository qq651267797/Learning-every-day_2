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
    class Tree
    {
        //节点数据
        public int Data;
        //节点高度，需要时常刷新
        //public int Height;
        //树形打印用到
        public string StrData;
        //左右孩子，以及母节点
        public Tree LeftChild { get; set; }
        public Tree RightChild { get; set; }
        public Tree ParentNode { get; set; }
        //int的构造
        public Tree(int item)
        {
            this.Data = item;
        }
        //string的构造
        public Tree(string free)
        {
            this.StrData = free;
        }
        //空构造，最先调用
        public Tree()
        {
        }
    }

    class MyAvlTree
    {
        //首先将插入的数组找到最大值
        //
        public Tree Root;
        public MyAvlTree()
        {
            this.Root = null;
        }
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
            for (int i = IndexMax; i < Input.Count; i++) {
                RightList.Add(Input[i]);
            }

            foreach(int i in LeftList) {
                Console.WriteLine(i);
            }
            foreach (int i in RightList) {
                Console.WriteLine(i);
            }

        }

        private void InsertNode(int item)
        {
            
            if()
        }



    }
    class ConstructMaximumBinaryTree
    {
        static void Main(string[] args)
        {
            MyLinkList f = new MyLinkList();
            //f.ADDDDD(4);
            //f.ADDDDD(5);
            //f.ADDDDD(1);
            ////f.ADDDDD(9);
            //f.Print();
            List<int> inPutList = new List<int>() { 4, 3, 1, 9 ,8 };

            f.ConstructMaximumBinaryTree(inPutList);
            Console.WriteLine();
            //f.Delete(5);
            //f.print();
            //f.Delete(4);
            //f.Delete(5);
            //f.print();
            //f.Delete(5);
            //f.print();

            Console.ReadKey();
        }
    }
}
