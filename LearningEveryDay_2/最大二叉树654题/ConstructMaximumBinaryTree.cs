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

    class MyTree
    {
        //首先将插入的数组找到最大值
        //
        public Tree Root;
        public MyTree()
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

            this.InsertNode(InputMax);
            //this.Root.LeftChild.Data = LeftList[0];
            //int RightListLenght = RightList.Count;
            //this.Root.RightChild.Data = RightList[RightListLenght - 1];
            foreach(int i in LeftList) {
                this.InsertNode(this.Root.LeftChild, i);
            }

            int RightListLenght = RightList.Count;
            for (int ii = RightListLenght; ii >= 0; ii--) {

                this.InsertNode(this.Root.RightChild, ii);
            }
        }

        private void InsertNode(int item)
        {
            Tree NewNode = new Tree(item);

            if (this.Root == null) {
                this.Root = NewNode;
                return;
            }
            else {
                Tree tempRoot = this.Root;
                while (true) {
                    if (item > this.Root.Data) {
                        if (tempRoot.RightChild == null) {
                            tempRoot.RightChild = NewNode;
                            NewNode.ParentNode = tempRoot;
                            break;
                        }
                        else {
                            tempRoot = tempRoot.RightChild;
                        }
                    }
                    else if (item < this.Root.Data) {
                            if (tempRoot.LeftChild == null) {
                                tempRoot.LeftChild = NewNode;
                                NewNode.ParentNode = tempRoot;
                                break;
                            }
                            else {
                                tempRoot = tempRoot.LeftChild;
                            }
                        }
                    else {
                        break;
                    }
                }
            }
        }
        private Tree InsertNode(Tree tree, int item)
        {
            Tree NewNode = new Tree(item);

            if (this.Root == null) {
                return NewNode = this.Root;
            }
            else {
                if (item > tree.Data) {
                    tree.RightChild = this.InsertNode(tree.RightChild, item);
                }
                else if (item < tree.Data) {
                    tree.LeftChild = this.InsertNode(tree.LeftChild, item);
                }
                else {
                    Console.WriteLine("插入重复的  ");
                }
            }
            return tree;
        }

        public void TreePrint(Tree tree)
        {
            if (tree == null) {
                Console.WriteLine("空树 ");
            }
            Queue<Tree> queue = new Queue<Tree>();
            Tree str = new Tree("*");
            //压入队列
            queue.Enqueue(tree);
            //定义一个什么，用来返回一个节点的高度值
            int Level = this.NodeDepth(this.Root);
            Tree temp;
            //此行的最后一个
            Tree NowLast = this.Root;
            //下一行的最后一个
            Tree NextLast = null;
            //是否是每一行的第一个数字
            bool LayerFirst = true;

            while (queue.Count > 0) {
                //出队列
                temp = queue.Dequeue();
                //返回Level层的  第一个空格数
                double First = this.BackFirst(Level);
                //返回Level层的  第一个数字以后的空格
                double After = this.BackAfter(Level);
                //如果是第一个数字
                if (LayerFirst == true) {
                    this.PrintSpace(First);
                }
                //如果
                if (temp.Data == 0) {
                    Console.Write(str.Data);
                    LayerFirst = false;
                }
                else {
                    Console.Write(temp.Data);
                    LayerFirst = false;
                }
                //如果 不是 第一个数字
                if (LayerFirst == false) {
                    this.PrintSpace(After);
                }
                //如果临时节点的左节点为空
                if (temp.LeftChild == null) {
                    queue.Enqueue(str);
                }
                //如果不为空，则压入临时节点的左节点
                else {
                    queue.Enqueue(temp.LeftChild);
                    NextLast = temp.LeftChild;
                }
                //如果临时节点的右节点为空
                if (temp.RightChild == null) {
                    queue.Enqueue(str);
                }
                //如果不为空，则压入临时节点的右节点
                else {
                    queue.Enqueue(temp.RightChild);
                    NextLast = temp.RightChild;
                }

                //如果临时节点是此行的最后一个节点
                if (temp == NowLast) {
                    //如果临时节点不是Root  并且  临时节点的母节点的右节点为空
                    if (temp != this.Root && temp.ParentNode.RightChild == null) {
                        //打印一个 str
                        temp = queue.Dequeue();
                        Console.Write(temp.StrData);
                    }
                    Console.WriteLine();
                    //一行的结束，LayerFirst置起
                    LayerFirst = true;
                    //减一层
                    Level--;

                    NowLast = NextLast;
                }
                //
                if (Level == 0) {
                    return;
                }

            }
        }
        /// <summary>
        /// 返回高度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int NodeDepth(Tree node)
        {
            if (node == null) {
                return 0;
            }
            int LeftDepth = NodeDepth(node.LeftChild);
            int RightDepth = NodeDepth(node.RightChild);
            return Math.Max(LeftDepth, RightDepth) + 1;
        }
        /// <summary>
        /// 打印空格
        /// </summary>
        /// <param name="SpaceData"></param>
        private void PrintSpace(double SpaceData)
        {
            for (int i = 0; i < SpaceData; i++) {
                Console.Write(" ");
            }
        }
        /// <summary>
        /// 返回打印每一行第一个数字，所需要的空格
        /// </summary>
        /// <param name="Level"></param>
        /// <returns></returns>
        private double BackFirst(int Level)
        {
            double n = 1;

            n = Math.Pow(2, Level) - 1;
            return n;  //返回第一个数字  空格的数量
        }
        /// <summary>
        /// 返回打印每一行从第二个开始的数字，所需要的空格
        /// </summary>
        /// <param name="Level"></param>
        /// <returns></returns>
        private double BackAfter(int Level)
        {
            double n, m;
            n = m = 1;

            n = Math.Pow(2, Level) - 1;
            m = (2 * n) + 1;
            return m;//返回第二个数字及以后的  空格的数量
        }

    }
    class ConstructMaximumBinaryTree
    {
        static void Main(string[] args)
        {
            MyTree f = new MyTree();
            //f.ADDDDD(4);
            //f.ADDDDD(5);
            //f.ADDDDD(1);
            ////f.ADDDDD(9);
            //f.Print();
            List<int> inPutList = new List<int>() { 3, 2, 1, 6, 0, 5 };

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
