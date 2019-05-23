using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_栈的实现
{
    class Stack_zhan
    {
        public int Data { get; set; }   //栈的数据
        public Stack_zhan NextNode { get; set; }
        public Stack_zhan PreviousNode { get; set; }

        public Stack_zhan()
        {

        }
        public Stack_zhan(int data)
        {
            this.Data = data;
        }
        public Stack_zhan(int data, Stack_zhan next)
        {
            this.Data = data;
            this.NextNode = null;
        }
    }
    class MyStack
    {
        public int size;    //栈的长度
        public Stack_zhan StacKHead;

        /// <summary>
        /// 判断栈是否为空
        /// 为空则返回 True
        /// 不为空返回 False
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (size == 0) {
                return true;
                //为空栈；
            }
            return false;
        }
        /// <summary>
        /// 返回栈的长度
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return size;
        }
        public void Add(int index,int value)
        {
            if (index < 0 || index > this.size) {
                throw new Exception(" 插入的位置不合法 ");
            }
            Stack_zhan tempHead = this.StacKHead;
            for(int i = 0; i < index; i++) {
                tempHead = tempHead.NextNode;
            }
            Stack_zhan NewNode = new Stack_zhan(value);
            NewNode.NextNode = tempHead.NextNode;
            tempHead.NextNode = NewNode;
            this.size++;
        }
        /// <summary>
        /// 打印堆
        /// </summary>
        public void Print()
        {
            if (this.StacKHead == null) {
                Console.WriteLine("空");
            }
            else {
                Stack_zhan tempHead = this.StacKHead;
                while (tempHead != null) {
                    Console.Write(tempHead.Data + ",");
                    tempHead = tempHead.NextNode;
                }
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            MyStack ff = new MyStack();
            ff.Add(ff.size, 1);
            ff.Add(ff.size, 2);
            ff.Add(0, 2);

            ff.Print();
            Console.ReadKey();
        }
    }
}
