using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraryList_namespace
{
    ///where T : IComparable
    ///引入的意义是，进行泛型T的 Min Max的比较
    class MyArrary<T> where T : IComparable
    {
        private T[] XuegaoList;
        public int size;
        /// <summary>
        /// 有参数构造函数
        /// （此函数只插入了int index）
        /// </summary>
        /// <param name="index"></param>
        public MyArrary(int index)
        {
            this.XuegaoList = new T[index];
            this.size = 0;
        }
        /// <summary>
        /// 无参数构造函数
        /// 默认建立一个 10 长度的
        /// </summary>
        public MyArrary()
        {
            this.size = 0;
            this.XuegaoList = new T[10];
        }
        /// <summary>
        /// 数组的扩容
        /// 扩展的倍数是 * 3 / 2 + 1
        /// </summary>
        private void ArraryExpansion()
        {
            T [] NewArrary = new T[this.size * 3 / 2 + 1];
            for(int i = 0; i < this.size; i++)
            {
                NewArrary[i] = XuegaoList[i];
            }
            XuegaoList = NewArrary;
        }

        /// <summary>
        /// 线表的插入
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item)
        {
            //传入的 index 不合理的时候
            //checkPositionIndex(index);
            if (0 > index && index > this.size)
            {
                Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
                return;
            }
            if (this.size == XuegaoList.Length)
            {
                this.ArraryExpansion();
            }
            for(int i = this.size - 1; i >= index; i--)
            {
                XuegaoList[i + 1] = XuegaoList[i];
            }
            //当size等于0，也就是说当前数组没有长度的时候
            //if (this.size == 0)
            //{
            //    XuegaoList[0] = item;
            //    this.size++;
            //    return;
            //}
            XuegaoList[index] = item;
            this.size++;
        }
        /// <summary>
        /// 在头部插入
        /// </summary>
        /// <param name="InputInt"></param>
        public void AddFirst(T InputInt)
        {
            this.Insert(0, InputInt);
        }
        /// <summary>
        /// 在尾部插入
        /// </summary>
        /// <param name="InputInt"></param>
        public void AddLast(T InputInt)
        {
            this.Insert(this.size, InputInt);
        }
        /// <summary>
        /// 线表的清空
        /// </summary>
        public void ClearArrList()
        {
            if (this.size == 0)
            {
                Console.WriteLine("Arrary为空，报错");
                throw new Exception();
            }
            for (int i = this.size - 1; i >= 0; i--)
            {
                XuegaoList[i] = default;
            }
            this.size = 0;
        }
        /// <summary>
        /// 返回数组的最大值
        /// </summary>
        /// <returns></returns>
        public T GetMax () 
        {
            if (this.size == 0)
            {
                Console.WriteLine("Arrary为空，报错");
                throw new Exception();
            }

            T MaxData = XuegaoList[0];

            for(int i = 0; i < this.size; i++)
            {
                //如果Integer等于参数，则返回 0
                //如果Integer小于参数，则返回 -1
                //如果Integer大于参数，则返回 1
                if ((XuegaoList[i]).CompareTo(MaxData) > 0)
                {
                    MaxData = XuegaoList[i];
                    continue;
                }
                else
                {
                    continue;
                }
            }
            return MaxData;
        }
        /// <summary>
        /// 返回数组的最小值
        /// </summary>
        /// <returns></returns>
        public T GetMin()
        {
            if (this.size == 0)
            {
                Console.WriteLine("Arrary为空，报错");
                throw new Exception();
            }

            T MinData = XuegaoList[0];

            for (int i = 0; i < this.size; i++)
            {
                //如果Integer等于参数，则返回 0
                //如果Integer小于参数，则返回 -1
                //如果Integer大于参数，则返回 1
                if (XuegaoList[i].CompareTo(MinData) > 0)
                {
                    continue;
                }
                else
                {
                    MinData = XuegaoList[i];
                    continue;
                }
            }
            return MinData;
        }
        /// <summary>
        /// 返回Index处的item
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetItem(int index)
        {
            if(0 > index || index > this.size)
            {
                Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
                //throw new Exception();
            }
            return XuegaoList[index];
        } 
        /// <summary>
        /// 返回数组的长度
        /// </summary>
        /// <returns></returns>
        public int Getsize()
        {
            return this.size;
        }
        /// <summary>
        /// 改变Index处的数据
        /// </summary>
        public void ChangeIndex(int index,T item)
        {
            if (this.size == 0)
            {
                Console.WriteLine("Arrary为空，报错");
            }
            if (0 > index || index > this.size)
            {
                Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
                //throw new Exception();
            }

            XuegaoList[index] = item;
        }
        /// <summary>
        /// 删除index的数据
        /// </summary>
        /// <param name="index"></param>
        public void DeleteIndex(int index)
        {
            if (this.size == 0)
            {
                Console.WriteLine("Arrary为空，报错");
            }
            if (0 > index || index > this.size)
            {
                Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
                //throw new Exception();
            }
            for(int i = index + 1; i < this.size; i++)
            {
                XuegaoList[i - 1] = XuegaoList[i];
            }
            this.size--;
        }
        /// <summary>
        /// 删除最开始的位置
        /// </summary>
        public void DeleteFirst()
        {
            this.DeleteIndex(0);
        }
        /// <summary>
        /// 删除最末尾的位置
        /// </summary>
        public void DeleteLast()
        {
            this.DeleteIndex(this.size);
        }
        /// <summary>
        /// 打印整个数组
        /// </summary>
        public void PrintArrary()
        {
            if (this.size == 0)
            {
                Console.WriteLine("数组为空，不允许打印");
            }
            for(int i = 0; i < this.size; i++)
            {
                Console.Write(XuegaoList[i] + ",");
            }
        }
    }
    class ArraryList
    {
        static void Main(string[] args)
        {
            MyArrary<int> ff = new MyArrary<int>();
            ff.AddLast(1);
            ff.AddLast(2);
            ff.AddLast(3);
            ff.AddLast(4);
            ff.AddLast(5);
            ff.AddLast(6);
            ff.AddLast(7);
            ff.AddLast(8);
            ff.Insert(7, 9);
            ff.Insert(9, 9);
            ff.AddLast(1000);
            ff.AddLast(99);
            ff.AddLast(999);
            ff.AddLast(9999);
            ff.Insert(5,0);

            //测试最大值在中间，在开始，在末尾的三种情况
            int Maxdata = ff.GetMax();
            Console.WriteLine("Maxdata = " + Maxdata);

            //测试最小值在中间，在开始，在末尾的三种情况
            int Mindata = ff.GetMin();
            Console.WriteLine("Mindata = " + Mindata);

            ff.PrintArrary();
            Console.WriteLine();

            ff.DeleteIndex(8);
            ff.PrintArrary();
            Console.ReadKey();
        }
    }
}
