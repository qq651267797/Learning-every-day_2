using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 减法
{
    public class Solution
    {
        public int Subtraction(int BaseData, int Subtracted)
        {
            int OutputInt = 0;
            Subtracted = ~Subtracted + 1;
            OutputInt = BaseData + Subtracted;
            return OutputInt;
        }
    }
    class Subtraction
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int BaseData = 1;
            int Subtracted = 5;
            int OutPutInt = ff.Subtraction(BaseData, Subtracted);
            Console.WriteLine(OutPutInt);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
