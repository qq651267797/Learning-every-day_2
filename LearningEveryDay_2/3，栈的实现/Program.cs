using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_链表的实现
{
    class ListNode
    {
        public int Data;   //链表的数据
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode()
        {
            this.Data = 0;
        }
        public ListNode(int data)
        {
            this.Data = data;
        }
    }
    class MySatck
    {
        MyList Stack_Node = new MyList();
        /// <summary>
        /// 获取 Stack 中包含的元素个数
        /// </summary>
        /// <returns></returns>
        public int Count_Stack()
        {
            int Count = this.Stack_Node.GetCount();
            return Count;
        }
        /// <summary>
        /// 返回 栈 的最大值
        /// </summary>
        /// <returns></returns>
        public int Max_Stack()
        {
            int MAX_Data = this.Stack_Node.GetMAX();
            return MAX_Data;
        }
        /// <summary>
        /// 返回 栈 的最小值
        /// </summary>
        /// <returns></returns>
        public int Min_Stack()
        {
            int Min_Data = this.Stack_Node.GetMin();
            return Min_Data;
        }
        /// <summary>
        /// 在 栈 的 顶部添加一个对象
        /// </summary>
        public void Push_Stack(int value)
        {
            this.Stack_Node.AddLast(value);
        }
        /// <summary>
        /// 返回在 Stack 的顶部的对象，但不移除它
        /// </summary>
        public int Peek_Stack()
        {
            int OutPeek = this.Stack_Node.GetLast();
            return OutPeek;
        }
        /// <summary>
        /// 移除并返回在 Stack 的顶部的对象
        /// </summary>
        public int Pop_Stack()
        {
            int outPop = this.Stack_Node.GetLast();
            this.Stack_Node.DeleteLast();
            return outPop;
        }
        /// <summary>
        ///  Stack 中移除所有的元素
        /// </summary>
        public void Clear()
        {
            this.Stack_Node.Clear();
        }
    }

    /// <summary>
    /// 链表的实现
    /// </summary>
    class MyList
    {
        public int size;    //链表的长度
        public ListNode ListHead;
        public ListNode ListLast;

        public MyList()
        {
            this.size = 0;
            this.ListHead = null;
            this.ListLast = null;
        }
        /// <summary>
        /// 判断链表是否为空
        /// 为空则返回 True
        /// 不为空返回 False
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (size == 0) {
                return true;
                //为空链表；
            }
            return false;
        }
        /// <summary>
        /// 返回链表的长度
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return size;
        }
        /// <summary>
        /// 返回链表的 首部
        /// </summary>
        /// <returns></returns>
        public int GetHead()
        {
            ListNode tempHead = this.ListHead;
            if (tempHead == null) {
                throw new Exception();
            }
            return tempHead.Data;
        }
        /// <summary>
        /// 返回链表的 尾部
        /// </summary>
        /// <returns></returns>
        public int GetLast()
        {
            ListNode tempLast = this.ListLast;
            if (tempLast == null) {
                throw new Exception();
            }
            return tempLast.Data;
        }
        /// <summary>
        /// 返回指定index位置的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetListNode(int index)
        {
            if (index > this.size || 0 > index) {
                throw new Exception();
            }
            ListNode tempHaed = this.ListHead;
            for(int i = 0; i < this.size; i++) {
                tempHaed = tempHaed.NextNode;
            }
            return tempHaed.Data;
        }
        /// <summary>
        /// 返回链表的最大值
        /// </summary>
        /// <returns></returns>
        public int GetMAX()
        {
            ListNode MaxNode = new ListNode();
            MaxNode.Data = this.ListHead.Data;
            ListNode tempNode = this.ListHead;
            if (this.ListHead == null) {
                throw new Exception();
            }
            for (int i = 0; i < this.size; i++) {
                if (tempNode.Data > MaxNode.Data) {
                    MaxNode.Data = tempNode.Data;
                    tempNode = tempNode.NextNode;
                }
                else {
                    tempNode = tempNode.NextNode;
                }
            }
            return MaxNode.Data;
        }
        /// <summary>
        /// 返回链表的最小值
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            ListNode MinNode = new ListNode();
            MinNode.Data = this.ListHead.Data;
            ListNode tempNode = this.ListHead;
            if (this.ListHead == null) {
                throw new Exception();
            }
            for(int i = 0; i < this.size; i++) {
                if (tempNode.Data > MinNode.Data) {
                    tempNode = tempNode.NextNode;
                }
                else {
                    MinNode.Data = tempNode.Data;
                    tempNode = tempNode.NextNode;
                }
            }
            return MinNode.Data;
        }

        /// <summary>
        /// 清空整个链表
        /// </summary>
        public void Clear()
        {
            this.ListHead = null;
            this.ListLast = null;
        }
        /// <summary>
        /// 在链表末尾加入value
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(int value)
        {
            this.InsertNode(this.size, value);
        }
        /// <summary>
        /// 在链表的首部加入value
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(int value)
        {
            this.InsertNode(0, value);
        }
        /// <summary>
        /// 在 index的后面插入节点
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertNode(int index,int value)
        {
            if (0 > index || index > this.size) {
                throw new Exception(" 插入的位置不合法 ");
            }
            ListNode newNode = new ListNode() { Data = value };
            ListNode tempHead = this.ListHead;
            ListNode tempLast = this.ListLast;

            if (this.ListHead == null) {
                this.ListHead = newNode;
                this.ListLast = newNode;
            }
            else if (index == 0) {
                newNode.NextNode = tempHead;
                newNode.PreviousNode = null;
                this.ListHead = newNode;
                tempHead.PreviousNode = newNode;
            }
            else if (index == this.size) {
                newNode.NextNode = null;
                newNode.PreviousNode = tempLast;
                tempLast.NextNode = newNode;
                this.ListLast = newNode;
            }
            else {
                ListNode a = null;
                ListNode b = this.ListHead;
                for(int temp_length = 0; temp_length < index; temp_length++) {
                    a = b.PreviousNode;
                    b = b.NextNode;
                }
                a.NextNode = newNode;
                b.PreviousNode = newNode;
                newNode.NextNode = b;
                newNode.PreviousNode = a;
            }
            this.size++;
        }
        /// <summary>
        /// 删除链表的头结点
        /// </summary>
        public void DeleteFirst()
        {
            this.DeleteNode(0);
        }
        /// <summary>
        /// 删除链表的尾节点
        /// </summary>
        public void DeleteLast()
        {
            this.DeleteNode(this.size);
        }
        /// <summary>
        /// 删除链表的节点
        /// </summary>
        /// <param name="index"></param>
        public void DeleteNode(int index)
        {
            if (index < 0 || index > this.size) {
                throw new Exception();
            }

            if (this.ListHead == null) {
                throw new Exception();
            }
            else if (index == 0) {
                ListNode tempHead = this.ListHead;
                this.ListHead = tempHead.NextNode;
            }
            else if (index == this.size) {
                ListNode tempLast = this.ListLast;
                tempLast.PreviousNode.NextNode = null;
                this.ListLast = tempLast.PreviousNode;
                tempLast = null;
            }
            else {
                ListNode a = this.ListHead.NextNode;
                ListNode b = this.ListHead;

                for(int temp_Length = 0; temp_Length < index - 1; temp_Length++) {
                    a = a.NextNode;
                    b = b.NextNode;
                }
                a = a.NextNode;
                b.NextNode = a;
                a.PreviousNode = b;
            }
            this.size--;
        }
        /// <summary>
        /// 打印 整个链表
        /// </summary>
        public void Print()
        {
            if (this.ListHead == null) {
                Console.WriteLine("空");
                return;
            }
            else {
                ListNode tempHead = this.ListHead;
                while (tempHead != null) {

                    Console.WriteLine(tempHead.Data + ",");
                    tempHead = tempHead.NextNode;
                }
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList ff = new MyList();

            ff.AddLast(12);
            ff.AddLast(0);
            ff.AddFirst(1);
            ff.AddLast(3);
            ff.AddLast(8);
            ff.AddLast(2);
            ff.AddLast(9);
            ff.Print();
            Console.WriteLine("                    ");
            int Max = ff.GetMAX();
            Console.WriteLine("List MAX = " + Max);
            int Min = ff.GetMin();
            Console.WriteLine("List Min = " + Min);
            Console.WriteLine("                    ");
            //ff.DeleteFirst();
            //ff.DeleteLast();
            //ff.DeleteNode(ff.GetCount());
            //ff.DeleteNode(1);
            int cou =  ff.GetCount();
            Console.WriteLine("size = " + cou);

            MySatck xx = new MySatck();

            xx.Push_Stack(1);
            xx.Push_Stack(0);
            xx.Push_Stack(3);
            xx.Push_Stack(6);
            xx.Push_Stack(10);
            int poppp = xx.Pop_Stack();
            Console.WriteLine(poppp);

            int pekk = xx.Peek_Stack();
            Console.WriteLine(pekk);
            

            Console.ReadKey();
        }
    }
}
