using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两数相加2_AddTwoNumbers
{

    //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
    //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
    //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
    //输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
    //输出：7 -> 0 -> 8
    //原因：342 + 465 = 807
    public class ListNode
    {
        public int Data;
        public ListNode NextNode;
        public ListNode(int x) { this.Data = x; }
        public ListNode()
        {

        }
    }
    public class Solution
    {
        public List<int> AddTwoNumbers3(List<int> intFirstList, List<int> intSecondList)
        {

            List<int> OutPutList = new List<int>();
            int Carry = 0;  //进位 
            int Index = 0;
            while (intFirstList.Count > Index && intSecondList.Count > Index) {
                int SumOne = intFirstList[Index] + intSecondList[Index] + Carry;
                Carry = SumOne / 10;
                OutPutList.Add(SumOne % 10);
                Index++;
            }
            while (intFirstList.Count > Index) {
                int SumTow = intFirstList[Index] + Carry;
                Carry = SumTow / 10;
                OutPutList.Add(SumTow % 10);
                Index++;
            }
            while (intSecondList.Count > Index) {
                int SumThree = intSecondList[Index] + Carry;
                Carry = SumThree / 10;
                OutPutList.Add(SumThree % 10);
                Index++;
            }
            if (Carry != 0) {
                Index++;
                OutPutList.Add(Carry);
            }
            return OutPutList;
        }

        public List<int> AddTwoNumbers(List<int> intFirstList, List<int> intSecondList)
        {
            List<int> OutPutList = new List<int>();

            int First = intFirstList.Count;
            int Second = intSecondList.Count;
            First--;
            Second--;
            int tempFirst = 0;
            int tempSecond = 0;

            for(int i = First; i >= 0; i--) {
                tempFirst += Convert.ToInt32(intFirstList[i] * Math.Pow(10, i));
            }
            OutPutList.Add(tempFirst);

            for (int i = Second; i >= 0; i--) {
                tempSecond += Convert.ToInt32(intSecondList[i] * Math.Pow(10, i));
            }
            OutPutList.Add(tempSecond);

            return OutPutList;
        }
    }
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            List<int> intFirstList = new List<int>();
            List<int> intSecondList = new List<int>();
            List<int> OutPutList = new List<int>();
            intFirstList.Add(8);
            intFirstList.Add(4);
            intFirstList.Add(3);
            intSecondList.Add(5);
            intSecondList.Add(6);
            intSecondList.Add(7);

            Solution ff = new Solution();
            OutPutList = ff.AddTwoNumbers3(intFirstList, intSecondList);

            foreach (int i in OutPutList) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
