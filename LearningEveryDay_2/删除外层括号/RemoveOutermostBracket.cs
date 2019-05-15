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
        public List<char> RemoveBracket(string input)
        {

            List<char> tempList = new List<char>();
            if (input.Length == 0 || input == null) {
                return tempList;
            }
            for (int i = 0; i < input.Length; i++) {
                tempList.Add(input[i]);
                //tempList[i] = input[i];
                //tempList = 0; 将input赋值，也没有用，会报错溢出
            }
            char space = ' ';
            string OutPut = "";
            int num = 0;

            for(int i = 0; i < tempList.Count; i++) {
                if (num == 0) {
                    tempList[i] = space;
                    num++;
                    continue;
                    //input = ' ';
                    ///传进来的参数是只读的，不可以修改
                }
                if (tempList[i] == '(') {
                    num++;
                }
                else {
                    num--;
                    if (num == 0) {
                        tempList[i] = space;
                        continue;
                    }
                    else {
                        continue;
                    }
                }
            }
            return tempList;
        }


        //public string RemoveBracket(string input)
        //{
        //    //string Useless = "((";  //提供"("
        //    //string DisUseless = "))";   //提供")"
        //    //List<char> OutputList = new List<char>();
        //    //List<char> tempList = new List<char>();

        //    //if (input.Length == 0 || input == null) {
        //    //    return OutputList;
        //    //}
        //    //for(int i = 0; i < input.Length; i++) {
        //    //    int tempList_int = 0;
        //    //    //char input_data = input[i];
        //    //    if (i == 0) {
        //    //        tempList.Add(input[i]);
        //    //    }
        //    //    else {
        //    //        //Useless[0] == (  ;;;  DisUseless[0] == )
        //    //        bool flag = tempList[i - 1] == Useless[0] && [i] == DisUseless[0];
        //    //        if (!flag) {
        //    //            tempList.Add(input[i]);
        //    //        }
        //    //        if (flag && (--i != 0)) {

        //    //        }

        //    //    }
        //    //}
        //    //if (input.Length == 0 || input == null) {
        //    //    return outPut;
        //    //}

        //}

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
            List<char> outPutList = new List<char>();
            RemoveOutermostBracket ff = new RemoveOutermostBracket();

            string input = "(()())";
            Console.WriteLine("output");
            outPutList = ff.RemoveBracket(input);
            foreach(char i in outPutList) {
                Console.Write(i);
            }
            Console.WriteLine();
            //()()

            input = "(()())(())";
            outPutList = ff.RemoveBracket(input);
            Console.WriteLine("output");
            foreach (char i in outPutList) {
                Console.Write(i);
            }
            Console.WriteLine();

            input = "(()())(())(()(()))";
            Console.WriteLine("output");
            outPutList = ff.RemoveBracket(input);
            foreach (char i in outPutList) {
                Console.Write(i);
            }
            Console.WriteLine();
            //输出："()()()()(())"

            input = "()()";
            Console.WriteLine("output");
            outPutList = ff.RemoveBracket(input);
            foreach (char i in outPutList) {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
