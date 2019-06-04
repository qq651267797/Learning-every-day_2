using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_乘法
{
    public class Solution
    {
        public int Multiply(int BaseData, int MultipleData)
        {
            int i = 1;
            int res = 0;
            while (MultipleData != 0) {
                if ((MultipleData & 1) == 1) {
                    res += (BaseData << (i - 1));
                    MultipleData = MultipleData >> 1;
                    i++;
                }
                else {
                    MultipleData = MultipleData >> 1;
                    i++;
                }
            }
            return res;
        }

            //int OutputInt = 0;

            //if (MultipleData == 0) {
            //    OutputInt = 0;
            //    return OutputInt;
            //}
            //if (MultipleData == 1) {
            //    OutputInt = BaseData;
            //    return OutputInt;
            //}
            //if (BaseData == 0) {
            //    OutputInt = 0;
            //    return OutputInt;
            //}
            //if (BaseData == 1) {
            //    OutputInt = MultipleData;
            //    return OutputInt;
            //}

            //bool FinallyFlag = false;
            //if (BaseData >= 0 && MultipleData >= 0) {
            //    FinallyFlag = true;
            //}
            //else if (BaseData >= 0 && MultipleData < 0){
            //    FinallyFlag = false;
            //}
            //else if (BaseData < 0 && MultipleData >= 0) {
            //    FinallyFlag = false;
            //}
            //else {
            //    FinallyFlag = true;
            //}

            //BaseData = Math.Abs(BaseData);
            //MultipleData = Math.Abs(MultipleData);

            //OutputInt = FinallyFlag == true ? OutputInt : ~OutputInt + 1;
            //return OutputInt;
    }
    class Multiplication
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int Base = 2222;
            int Multiple = 5555;
            int OutPutInt = ff.Multiply(Base, Multiple);
            Console.WriteLine("底数是 " + Base +" 乘以 " + Multiple);
            Console.WriteLine("乘完之后结果为 " + OutPutInt);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
