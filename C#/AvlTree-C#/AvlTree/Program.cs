using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/TheAlgorithms/Java/blob/master/DataStructures/Trees/AVLTree.java


namespace AvlTree_namespace
{
    class AvlTree
    {
        //节点数据
        public int Data;
        //节点高度，需要时常刷新
        public int Height;
        //树形打印用到
        public string StrData;
        //左右孩子，以及母节点
        public AvlTree LeftChild { get; set; }
        public AvlTree RightChild { get; set; }
        public AvlTree ParentNode { get; set; }
        //int的构造
        public AvlTree(int item)
        {
            this.Data = item;
        }
        //string的构造
        public AvlTree(string free)
        {
            this.StrData = free;
        }
        //空构造，最先调用
        public AvlTree()
        {
        }
    }
    class MyAvlTree
    {
        public AvlTree Root;
        //空构造函数
        public MyAvlTree()
        {
            this.Root = null;
        }
        //私有的方法  返回实时更新的 Height
        private int Height(AvlTree tree)
        {
            if (tree != null) {
                return tree.Height;
            }
            return 0;
        }
        //公开的方法  返回整棵树的Height
        public int Height()
        {
            return this.Height(this.Root);
        }
        //
        //private int Max(int a,int b)
        //{
        //    //为真则执行a，否则执行b
        //    return a > b ? a : b;
        //}
        /// <summary>
        /// 
        ///            a                b
        ///          /   \            /   \
        ///         b     c    ==    d     a
        ///       /   \             /     /  \
        ///      d     e           f     e    c
        ///     /
        ///    f
        ///  
        /// 左左结构  向右旋转
        /// </summary>
        /// <param name="PreviousNode"></param>
        private AvlTree LeftLeftRotation(AvlTree k2)
        {
            AvlTree k1;

            k1 = k2.LeftChild;
            k2.LeftChild = k1.RightChild;
            k1.RightChild = k2;

            k2.Height = Math.Max(Height(k2.LeftChild), Height(k2.RightChild)) + 1;
            k1.Height = Math.Max(Height(k1.LeftChild), k2.Height) + 1;
            return k1;
        }

        /// <summary>
        /// 右右结构，向左旋转
        /// 
        ///        a                         c
        ///      /   \                     /   \
        ///     b     c       ==          a     e
        ///          /  \                / \     \ 
        ///         d    e              b   d     f
        ///               \  
        ///                f
        /// 
        /// </summary>
        /// <param name="A"></param>
        private AvlTree RightRightRotation(AvlTree k1)
        {
            AvlTree k2;

            k2 = k1.RightChild;
            k1.RightChild = k2.LeftChild;
            k2.LeftChild = k1;

            k1.Height = Math.Max(Height(k1.LeftChild), Height(k1.RightChild)) + 1;
            k2.Height = Math.Max(Height(k2.RightChild), k1.Height) + 1;

            return k2;
        }
        /// <summary>
        /// 左右双结构，当左边太高时
        /// 
        ///           8                 8   
        ///         /   \             /   \                  6
        ///        5     12  ==      6     12    ==        /   \
        ///      /   \             /   \                  5      8
        ///     3     6           5     7                /      /  \
        ///            \         /                      3      7   12
        ///             7       3
        /// 
        /// </summary>
        /// <param name="A"></param>
        private AvlTree LeftRightRotation(AvlTree node)
        {
            node.LeftChild = RightRightRotation(node.LeftChild);
            return LeftLeftRotation(node);
        }
        /// <summary>
        /// 右左双结构
        /// 
        ///      4                  4                       6
        ///    /   \              /  \                    /   \
        ///   2      7      ==   2    6       ==         4      7
        ///        /   \            /   \              /   \     \
        ///       6     8          5      7           2     5     8
        ///      /                         \
        ///     5                           8
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        private AvlTree RightLeftRotation(AvlTree node)
        {
            node.RightChild = LeftLeftRotation(node.RightChild);
            return RightRightRotation(node);
        }

        public AvlTree InsertNode(AvlTree tree,int item)
        {
            if (tree == null) {
                tree = new AvlTree(item);
            }
            else {
                bool IsFindSameNode = this.LookSameNode(this.Root, item);
                if (IsFindSameNode == true) {
                    return tree;
                }
                else {
                    if (item < tree.Data) {
                        tree.LeftChild = InsertNode(tree.LeftChild, item);

                        if (Height(tree.LeftChild) - Height(tree.RightChild) == 2) {
                            if ((item > tree.LeftChild.Data ? 1 : -1) < 0) {
                                tree = LeftLeftRotation(tree);
                            }
                            else {
                                tree = LeftRightRotation(tree);
                            }
                        }
                    }

                    else if (item > tree.Data) {
                        tree.RightChild = InsertNode(tree.RightChild, item);

                        if (Height(tree.RightChild) - Height(tree.LeftChild) == 2) {
                            if ((item > tree.RightChild.Data ? 1 : -1) > 0) {
                                tree = RightRightRotation(tree);
                            }
                            else {
                                tree = RightLeftRotation(tree);
                            }
                        }
                    }

                    else {
                        Console.Write("插入失败");
                    }
                }
            }

            tree.Height = Math.Max(Height(tree.LeftChild), Height(tree.RightChild)) + 1;
            return tree;
        }
        public void InsertNode(int item)
        {
            Root = InsertNode(Root, item);
        }
        /// <summary>
        /// 查找插入的节点的数据，是否和树中的重复，重复则返回
        /// </summary>
        /// <param name="node"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private bool LookSameNode(AvlTree node, int item)
        {
            if (node == null) {
                return false;
            }
            if (node.Data == item) {
                return true;
            }
            else if (item < node.Data) {
                return this.LookSameNode(node.LeftChild, item);
            }
            else {
                return this.LookSameNode(node.RightChild, item);
            }
        }
        /// <summary>
        /// 中序遍历
        /// Inorder Traversal
        /// </summary>
        public void InorderTraversal()  //中序
        {
            this.InorderTraversal(this.Root);
        }
        private void InorderTraversal(AvlTree node)
        {
            if (node == null) {
                return;
            }
            this.InorderTraversal(node.LeftChild);
            Console.Write(node.Data + " ,");
            this.InorderTraversal(node.RightChild);
        }

        /// <summary>
        /// 树形打印一棵树
        /// </summary>
        /// <param name="tree"></param>
        public void PrintTree4(AvlTree tree)
        {
            if (this.Root == null) {
                //Console.WriteLine("null");
                return;
            }
            Queue<AvlTree> queue = new Queue<AvlTree>();
            AvlTree str = new AvlTree() { StrData = "*" };
            queue.Enqueue(tree);
            int Level = this.NodeDepth(this.Root);

            AvlTree temp;
            AvlTree NowLast = this.Root;
            AvlTree NextLast = null;
            bool LayerFirst = true;


            while (queue.Count > 0) {
                temp = queue.Dequeue();
                double First = this.BackFirst(Level);
                double After = this.BackAfter(Level);
                if (LayerFirst == true) {
                    this.PrintSpace(First);
                }

                if (temp.Data == 0) {
                    Console.Write(temp.StrData);
                    LayerFirst = false;
                }
                else {
                    //Console.Write(temp.Data);
                    Console.Write(temp.Data);
                    LayerFirst = false;
                }
                if (LayerFirst == false) {
                    this.PrintSpace(After);
                }

                if (temp.LeftChild == null) {
                    queue.Enqueue(str);
                }
                else {
                    queue.Enqueue(temp.LeftChild);
                    NextLast = temp.LeftChild;
                }


                if (temp.RightChild == null) {
                    queue.Enqueue(str);
                }
                else {
                    queue.Enqueue(temp.RightChild);
                    NextLast = temp.RightChild;
                }


                if (temp == NowLast) {
                    //if (temp != this.Root && temp.ParentNode.RightChild == null) {
                    //    //After = this.BackAfter(Level);
                    //    //this.PrintSpace(After);
                    //    temp = queue.Dequeue();
                    //    Console.Write(temp.StrData);

                    //}
                    Console.WriteLine();
                    LayerFirst = true;
                    Level--;
                    NowLast = NextLast;
                }
                if (Level == 0) {
                    return;
                }

            }
        }
        private void PrintSpace(double SpaceData)
        {
            for (int i = 0; i < SpaceData; i++) {
                Console.Write(" ");
            }
        }

        private double BackFirst(int Level)
        {
            double n = 1;

            n = Math.Pow(2, Level) - 1;
            return n;  //返回第一个数字  空格的数量
        }
        private double BackAfter(int Level)
        {
            double n, m;
            n = m = 1;

            n = Math.Pow(2, Level) - 1;
            m = (2 * n) + 1;
            return m;//返回第二个数字及以后的  空格的数量
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int NodeDepth(AvlTree node)
        {
            if (node == null) {
                return 0;
            }
            int LeftDepth = NodeDepth(node.LeftChild);
            int RightDepth = NodeDepth(node.RightChild);
            return Math.Max(LeftDepth, RightDepth) + 1;
        }
        /// <summary>
        /// 发现树中最小的节点
        /// </summary>
        /// <returns></returns>
        public int FindMin(AvlTree temp)
        {
            //AvlTree temp = this.Root;
            while (temp.LeftChild != null) {
                temp = temp.LeftChild;
            }
            return temp.Data;
        }
        /// <summary>
        /// 发现 树中最大的节点
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public int FindMax(AvlTree temp)
        {
            //AvlTree temp = this.Root;
            while (temp.RightChild != null) {
                temp = temp.RightChild;
            }
            return temp.Data;
        }
        /// <summary>
        /// 树的清空操作
        /// </summary>
        public void ClearTree()
        {
            this.ClearTree(this.Root);
            this.Root = null;
        }
        private void ClearTree(AvlTree tree)
        {
            if (tree != null) {
                this.ClearTree(tree.LeftChild);
                tree.LeftChild = null;
                this.ClearTree(tree.RightChild);
                tree.RightChild = null;
            }
        }
    }
    class MM
    {
        static void Main(string[] args)
        {
            MyAvlTree ff = new MyAvlTree();
            //Test1
            Console.WriteLine("Test1: ------------");
            ff.InsertNode(1);
            ff.InsertNode(2);
            ff.InsertNode(3);
            ff.InsertNode(3);
            ff.InorderTraversal();
            Console.WriteLine();
            ff.PrintTree4(ff.Root);
            Console.WriteLine();
            ff.ClearTree();

            ////Test2
            Console.WriteLine("Test2: ------------");
            ff.InsertNode(6);
            ff.InsertNode(5);
            ff.InsertNode(4);
            ff.InsertNode(4);
            ff.PrintTree4(ff.Root);
            Console.WriteLine();
            ff.ClearTree();

            //Test3
            Console.WriteLine("Test3: ------------");
            ff.InsertNode(2);
            ff.InsertNode(4);
            ff.InsertNode(5);
            ff.InsertNode(6);
            ff.InsertNode(7);
            ff.InsertNode(8);
            ff.InsertNode(8);
            ff.PrintTree4(ff.Root);
            Console.WriteLine();
            ff.ClearTree();

            //Test4
            Console.WriteLine("Test4: ------------");
            ff.InsertNode(3);
            ff.InsertNode(5);
            ff.InsertNode(6);
            ff.InsertNode(7);
            ff.InsertNode(8);
            ff.InsertNode(12);
            ff.PrintTree4(ff.Root);
            Console.WriteLine();
            ff.ClearTree();

            Console.ReadKey();
        }
    }
}
