using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除外层括号
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> brackets = new Stack<char>();
            int icount = 0;
            string s = "(()())";
            for(int i = 0; i < s.Length; i++) {
                brackets.Push(s[i]);
            }
            for(int i = 0; i < brackets.Count; i++) {
                char brac = brackets[i];
                Console.WriteLine(brackets[0]);
            }


            foreach (char a in brackets) {
                Console.WriteLine("brackets打印第" + icount + "次 ，" + a);
                icount++;
            }



            //char t;
            //char r;
            //if (brackets.Count > 0) {
            //    t = brackets.Pop();
            //    Console.WriteLine("t =" + t);
            //}
            //else {
            //    return;
            //}
            ////Console.WriteLine(s[0]);

            //Console.WriteLine(s[0]);
            Console.ReadKey();
        }
    }
}
