using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加法
{
    public class Solution
    {
        public int Addition(int BaseData, int Addend)
        {
            int Carry = 0;
            while (Addend != 0) {
                Carry = BaseData & Addend;
                BaseData = BaseData ^ Addend;
                Addend = Carry << 1;
            }
            return BaseData;
        }
    }
    class Addition
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int OutPut = ff.Addition(5, -3);
            Console.WriteLine(OutPut);
            OutPut = ff.Addition(1, -1);
            Console.WriteLine(OutPut);
            OutPut = ff.Addition(-5, -1);
            Console.WriteLine(OutPut);
            OutPut = ff.Addition(-5, 3);
            Console.WriteLine(OutPut);

            Console.ReadKey();
        }
    }
}
