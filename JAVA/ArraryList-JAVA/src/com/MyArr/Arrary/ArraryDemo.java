package com.MyArr.Arrary;

import jdk.internal.util.xml.impl.Input;
//import org.omg.CORBA.Object;
import java.lang.Object;

import java.io.IOException;
import java.util.Comparator;

public class ArraryDemo {
    private Object [] XuegaoList;
    public int size;


    /// <summary>
    /// 有参数构造函数
    /// （此函数只插入了int index）
    /// </summary>
    /// <param name="index"></param>
    public ArraryDemo(int index) {
        this.XuegaoList = new Object[index];
        this.size = 0;
    }

    /// <summary>
    /// 无参数构造函数
    /// 默认建立一个 10 长度的
    /// </summary>
    public ArraryDemo() {
        this.size = 0;
        this.XuegaoList = new Object[10];
    }

//    public class bijiaoqi implements Comparator  {
//
////        private Object value;
////
////        public Max(){
////
////        }
////        public Object getvalue() {
////            return value;
////        }
////
////        public void setvalue(Object value) {
////            this.value = value;
////        }
//
//        @Override
//        public int compare(Object o1,Object o2) {
//            //ArraryDemo obj1 = (ArraryDemo)o1;
//            //ArraryDemo obj2 = (ArraryDemo)o2;
//
//            int Self = Integer.parseInt(this.getvalue().toString());
//            int Outside = Integer.parseInt(o.getvalue().toString());
//
//            int OutPut = Self - Outside;
//            if (OutPut > 0) {
//                return 1;
//            } else if (OutPut == 0) {
//                return 0;
//            } else {
//                return -1;
//            }
//
//        }
//
//    }


    /// <summary>
    /// 数组的扩容
    /// 扩展的倍数是 * 3 / 2 + 1
    /// </summary>
    private void ArraryExpansion() {
        Object[] NewArrary = new Object[this.size * 3 / 2 + 1];
        for (int i = 0; i < this.size; i++) {
            NewArrary[i] = XuegaoList[i];
        }
        XuegaoList = NewArrary;
    }

    /// <summary>
    /// 线表的插入
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    public void Insert(int index, Object item) {
        //传入的 index 不合理的时候
        //checkPositionIndex(index);
        if (0 > index && index > this.size) {
            System.out.println("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            return;
        }
        if (this.size == XuegaoList.length) {
            this.ArraryExpansion();
        }
        for (int i = this.size - 1; i >= index; i--) {
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
    public void AddFirst(Object InputInt) {
        this.Insert(0, InputInt);
    }

    /// <summary>
    /// 在尾部插入
    /// </summary>
    /// <param name="InputInt"></param>
    public void AddLast(Object InputInt) {
        this.Insert(this.size, InputInt);
    }

    /// <summary>
    /// 线表的清空
    /// </summary>
    public void ClearArrList() throws Exception{
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
            //return;
            //throw new IOException();
            throw new Exception();
        }
        for (int i = this.size - 1; i >= 0; i--) {
            //XuegaoList[i] = default;
            XuegaoList[i] = null;
        }
        this.size = 0;
    }

    /**
     * 将object数据转换成int进行比较大小
     * InputObjOne - InputObjTwo
     * 如果InputIntOne 大于 InputIntTwo
     * 那么返回1，等于返回0，小于则返回-1
     */
    public int ObjConversionIntCompare(Object InputObjOne, Object InputObjTwo) {
        int InputIntOne = Integer.parseInt(InputObjOne.toString());
        int InputIntTwo = Integer.parseInt(InputObjTwo.toString());
        int OutPut = InputIntOne - InputIntTwo;
        if (OutPut > 0) {
            return 1;
        } else if (OutPut == 0) {
            return 0;
        } else {
            return -1;
        }
    }

    /// <summary>
    /// 返回数组的最大值
    /// </summary>
    /// <returns></returns>
    public Object GetMax() {
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
            return null;
            //throw new Exception();
        }
        Object MaxData = this.XuegaoList[0];

        for (int i = 0; i < this.size; i++) {
            //如果Integer等于参数，则返回 0
            //如果Integer小于参数，则返回 -1
            //如果Integer大于参数，则返回 1

            if (ObjConversionIntCompare(this.XuegaoList[i], MaxData) > 0)
            //if ((XuegaoList[i]).CompareTo(MaxData) > 0)
            {
                MaxData = this.XuegaoList[i];
                continue;
            } else {
                continue;
            }
        }
        return MaxData;
    }

    /// <summary>
    /// 返回数组的最小值
    /// </summary>
    /// <returns></returns>
    public Object GetMin() {
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
            return null;
        }

        Object MinData = this.XuegaoList[0];
        //int MinData = Integer.parseInt(XuegaoList[0].toString());
        //int MinData = XuegaoList[0];


        for (int i = 0; i < this.size; i++) {
            //如果Integer等于参数，则返回 0
            //如果Integer小于参数，则返回 -1
            //如果Integer大于参数，则返回 1
            if (ObjConversionIntCompare(this.XuegaoList[i], MinData) > 0) {
                //if (TemoMin > MinData) {
                continue;
            } else {
                MinData = this.XuegaoList[i];
                continue;
            }


//            if (XuegaoList[i].CompareTo(MinData) > 0) {
//                continue;
//            } else {
//                MinData = XuegaoList[i];
//                continue;
//            }
        }
        return MinData;
    }

    /// <summary>
    /// 返回Index处的item
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public Object GetItem(int index) {
        if (0 > index || index > this.size) {
            System.out.println("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //throw new Exception();
        }
        return XuegaoList[index];
    }

    /// <summary>
    /// 返回数组的长度
    /// </summary>
    /// <returns></returns>
    public int Getsize() {
        return this.size;
    }

    /// <summary>
    /// 改变Index处的数据
    /// </summary>
    public void ChangeIndex(int index, Object item) {
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
        }
        if (0 > index || index > this.size) {
            System.out.println("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //throw new Exception();
        }

        XuegaoList[index] = item;
    }

    /// <summary>
    /// 删除index的数据
    /// </summary>
    /// <param name="index"></param>
    public void DeleteIndex(int index) {
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
        }
        if (0 > index || index > this.size) {
            System.out.println("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //Console.WriteLine("传入的 " + index + " 不符合标准 ," + "现在的长度为 " + this.size);
            //throw new Exception();
        }
        for (int i = index + 1; i < this.size; i++) {
            XuegaoList[i - 1] = XuegaoList[i];
        }
        this.size--;
    }

    /// <summary>
    /// 删除最开始的位置
    /// </summary>
    public void DeleteFirst() {
        this.DeleteIndex(0);
    }

    /// <summary>
    /// 删除最末尾的位置
    /// </summary>
    public void DeleteLast() {
        this.DeleteIndex(this.size);
    }

    /// <summary>
    /// 打印整个数组
    /// </summary>
    public void PrintArrary() {
        if (this.size == 0) {
            System.out.println("Arrary为空，报错");
            //Console.WriteLine("Arrary为空，报错");
        }
        for (int i = 0; i < this.size; i++) {
            System.out.print(XuegaoList[i] + ",");
            //Console.Write(XuegaoList[i] + ",");
        }
    }
}

//class MaxData implements Comparable<MaxData> {
//
//    private Object value;
//
//    public Object getvalue() {
//        return value;
//    }
//
//    public void setvalue(Object value) {
//        this.value = value;
//    }
//
//    @Override
//    public int compareTo(MaxData o) {
//        return Integer.parseInt(this.getvalue().toString()) - Integer.parseInt(o.getvalue().toString());
//    }
//
//}

