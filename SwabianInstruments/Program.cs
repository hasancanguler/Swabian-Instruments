using System;
using System.Collections.Generic;

namespace SwabianInstruments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("never odd or even"));
            Console.WriteLine(SumMultiplier(new int[] { 1, 1, 2, 10, 3, 1, 12 }));
            Console.WriteLine(WordSplit(new string[] { "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z" }));
        }


        public static string WordSplit(string[] strArr)
        {
            string[] strSearchArr = strArr[1].Split(",");

            for (int index = 1; index < strSearchArr.Length - 1; index++)
            {
                for (int inline = index + 1; inline < strSearchArr.Length; inline++)
                {
                    if (strArr[0] == (strSearchArr[index] + strSearchArr[inline]))
                        return strSearchArr[index] + "," + strSearchArr[inline];
                    else if (strArr[0] == (strSearchArr[inline] + strSearchArr[index]))
                        return strSearchArr[inline] + "," + strSearchArr[index];
                }
            }
            return "not possible";
        }


        public static string SumMultiplier(int[] arr)
        {
            int summary = SumArray(arr);
            int multiply = 0;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                for (int inline = index + 1; inline < arr.Length; inline++)
                {
                    multiply = arr[index] * arr[inline];
                    if (multiply > summary)
                        return "true";
                }
            }
            return "false";
        }

        private static int SumArray(int[] arr)
        {
            int summary = 0;
            for (int index = 0; index < arr.Length; index++)
                summary += arr[index];
            return summary;
        }


        public static string Palindrome(string str)
        {
            str = ClearBlank(str);
            string strReverse = Reverse(str);
            if (str == strReverse)
                return "true";
            else
                return "false";

        }

        private static string ClearBlank(string str)
        {
            string clearStr = "";
            string[] strList = str.Split(" ");
            for (int index = 0; index < strList.Length; index++)
                clearStr += strList[index].ToString();
            return clearStr;
        }

        private static string Reverse(string str)
        {
            string strReverse = "";
            for (int index = str.Length; index > 0; index--)
                strReverse += str.Substring(index - 1, 1);
            return strReverse;
        }

    }
}
