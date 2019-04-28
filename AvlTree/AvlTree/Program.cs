using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int Max(int a,int b)
        {
            //为真则执行a，否则执行b
            return a > b ? a : b;
        }
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



    }
    class MM
    {
        static void Main(string[] args)
        {
        }
    }
}
