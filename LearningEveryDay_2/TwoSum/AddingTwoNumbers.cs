using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTwoNumbers_namespace
{

//给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的
//那 两个 整数，并返回他们的数组下标。

//你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
//示例:
//给定 nums = [2, 7, 11, 15], target = 9

//因为 nums[0] + nums[1] = 2 + 7 = 9
//所以返回[0, 1]

    class AddingTwoNumbers
    {
        public int[] TwoSum(int[] A,int Together)
        {
            int[] FinallyList = new int[2];

            for(int i = 0; i < A.Length; i++) {
                for(int j = i + 1; j < A.Length; j++) {
                    if (A[i] + A[j] == Together) {
                        FinallyList[0] = i;
                        FinallyList[1] = j;
                        return FinallyList;
                    }
                }
            }
            throw new Exception();
        }
    }
    class TwoSum
    {
        static void Main(string[] args)
        {
            AddingTwoNumbers ff = new AddingTwoNumbers();
            int[] num = { 3, 5, 9, 12, 16, 5, 6 };
            int[] FinallyList = ff.TwoSum(num, 110);
            Console.WriteLine("{0} , {1}", FinallyList[0], FinallyList[1]);

            Console.ReadKey();
        }
    }
}
