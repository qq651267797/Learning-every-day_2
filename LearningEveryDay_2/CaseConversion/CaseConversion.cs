using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseConversion_namespace
{
    class CaseConversion
    {
        public string ToLower(string str)
        {
            if (str == null || str.Length == 0) {
                return null;
            }

            for(int i = 0; i < str.Length; i++) {
                if((str[i]>='A') && (str[i] <= 'Z')) {
                    char temp = str[i]; 
                    temp += 32;
                }
            }
            return str;
        }

    }
    class Progarm
    {
        static void Main(string[] args)
        {
        }
    }
}
