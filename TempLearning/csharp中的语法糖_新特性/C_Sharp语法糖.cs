using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp语法糖
{
    //C# 2.0新特性
    class C_Sharp
    {
        public class Yu_fa_tangV2
        {
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/whats-new/csharp-version-history
            //C# Version History

            public void V2()
            {
                //1，可空类型
                //int? aa = null;
                //aa = 33;
                //Console.WriteLine(aa.HasValue);  //True
                //Console.WriteLine(aa.Value);  //33
                //if (aa.HasValue) {
                //    int bb = aa.Value;
                //    Console.WriteLine(bb);    //33
                //}

                //2，泛型
                //List<int> vs = new List<int>();
                //vs.Add(2);
                //List<T> vs = new List<T>();



            }
            //C# 3.0新特性
            public void V3()
            {

            }
            //C# 4.0新特性
            public void V4()
            {

            }
            //C# 5.0新特性
            public void V5()
            {

            }
            //C# 6.0新特性
            public void V6()
            {

            }
            //C# 7.0新特性
            public void V7()
            {

            }
            //C# 8.0新特性
            public void V8()
            {

            }
            //C# 9.0新特性
            public void V9()
            {

            }
            //C# 10.0新特性
            public void V10()
            {

            }

            //官网中的更新 Version and update considerations
            public double CalculateSquare(double value)
            {
                return value * value;
            }
            // After_Updata
            //public double CalculateSquare(double value) => value * value;

            //After_Updata_Updata
            //public double CalculateSquare(in double value) => value * value;

            //官网中的更新 Relationships between language and framework
            //在针对尚未部署这些类型或成员的环境编写代码时，可使用包含较新版本的语言所需类型的 NuGet 包。
            //相关示例包括：
            //Exception - 用于编译器生成的所有异常。
            //String - C# string 类型是 String 的同义词。
            //Int32 - int 的同义词。


            //保留
            public void VXX()
            {

            }

        }

    }

    class C_Sharp语法糖
    {
        static void Main(string[] args)
        {
        }
    }
}
