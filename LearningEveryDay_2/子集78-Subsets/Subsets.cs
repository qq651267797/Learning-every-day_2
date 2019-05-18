using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 子集78_Subsets
{
    class Solution
    {
        public List<int> Subsets(int[] nums)
        {
            List<int> OutList = new List<int>();
            int numsLength = nums.Length;
            //for(int i = 0; i < nums.Length; i++) {
            //    OutList.Add(nums[i]);
            //}
            if (nums.Length == 0) {
                return OutList;
            }
            foreach (int i in nums) {
                OutList.Add(i);
            }
            return OutList;
        }

        //public List<List<int>> subsets(int[] nums) {
        //    List<List<int>> results = new ArrayList<>();
        //    results.add(new ArrayList<>());

        //    for (int i = 0; i < nums.length; i++) {
        //        List<List<int>> plusNumbers = new ArrayList<>();
        //        for (List<int> result : results) {
        //            List<int> newNumber = new ArrayList<>(result);
        //            newNumber.add(nums[i]);
        //            plusNumbers.add(newNumber);
        //        } results.addAll(plusNumbers);
        //    }
        //    return results;
        //}
    }

    class Subsets
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int[] num = { 1, 2, 3 };
            List<int> OutList = new List<int>();

            OutList = ff.Subsets(num);
            foreach(int i in OutList) {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
