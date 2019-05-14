using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除外层括号
{
    //1021，删除最外层的括号
    //输入："(()())(())"
    //输出："()()()"

    //输入："(()())(())(()(()))"
    //输出："()()()()(())"

    //输入："()()"
    //输出：""
    class RemoveOutermostBracket
    {
        public string RemoveBracket(string input)
        {
            //string Useless = "((";  //提供"("
            //string DisUseless = "))";   //提供")"

            //List<char> OutputList = new List<char>();
            //List<char> tempList = new List<char>();

            //if (input.Length == 0 || input == null) {
            //    return OutputList;
            //}
            //for(int i = 0; i < input.Length; i++) {
            //    int tempList_int = 0;
            //    //char input_data = input[i];
            //    if (i == 0) {
            //        tempList.Add(input[i]);
            //    }
            //    else {
            //        //Useless[0] == (  ;;;  DisUseless[0] == )
            //        bool flag = tempList[i - 1] == Useless[0] && [i] == DisUseless[0];
            //        if (!flag) {
            //            tempList.Add(input[i]);
            //        }
            //        if (flag && (--i != 0)) {

            //        }

            //    }
            //}

            string 

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<char> brackets = new Stack<char>();
            //string s = "(()())";
            ////for(int i = 0; i < s.Length; i++) {
            //    brackets.Push(s[i]);
            //}
            //for (int i = 0; i < brackets.Count; i++) {
            //    char brac = brackets[i];
            //    Console.WriteLine(brac);
            //}

            //Console.WriteLine(brackets.ToString());

            //int icount = brackets.Count;
            //foreach (char a in brackets) {
            //    Console.WriteLine("brackets打印第" + icount + "次 ，" + a);
            //    icount--;
            //}

            string input = "(()())";
            RemoveOutermostBracket ff = new RemoveOutermostBracket();
            string output =  ff.RemoveBracket(input);
            Console.WriteLine("output");
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
