using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber_namespace
{
    //编写一个算法来判断一个数是不是“快乐数”。
    //一个“快乐数”定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，
    //然后重复这个过程直到这个数变为 1，也可能是无限循环但始终变不到 1。如果可以变为 1，
    //那么这个数就是快乐数。
    //示例: 
    //输入: 19
    //输出: true
    //解释: 
    //1^2 + 9^2 = 82
    //8^2 + 2^2 = 68
    //6^2 + 8^2 = 100
    //1^2 + 0^2 + 0^2 = 1
    class HappyNumber
    {
        public bool IsHappy(int n) {
            List<int> FalseList = new List<int>();
            bool flag = true;

            while (n != 1) {
                int intLength = n.ToString().Length;
                int sum = 0;
                for (int i = intLength; i > 0; i--) {
                    int High = Convert.ToInt32(Math.Pow(10, i));
                    int Low = Convert.ToInt32(Math.Pow(10, i - 1));
                    int SecondPower = n % High / Low;

                    sum += Convert.ToInt32(Math.Pow(SecondPower, 2));
                }
                //如果 sum 属于FalseList 则直接返回false
                if (FalseList.Contains(sum)) {
                    return !flag;
                }
                FalseList.Add(sum);
                //sum的值 给 n
                n = sum;
            }
            return flag;
        }
    }
    class Progarm
    {
        static void Main(string[] args)
        {
            HappyNumber ff = new HappyNumber();
            int data = 19;

            bool temp = ff.IsHappy(data);
            Console.WriteLine(temp);

            data = 1;
            temp = ff.IsHappy(data);
            Console.WriteLine(temp);

            data = 99;
            temp = ff.IsHappy(data);
            Console.WriteLine(temp);

            data = 89;
            temp = ff.IsHappy(data);
            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
