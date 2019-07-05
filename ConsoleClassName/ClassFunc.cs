using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassName
{
    class Classfunc
    {
        /*定义一个求较大数的函数并在主函数中调用*/
        //static int Max(int n1, int n2)
        //{
        //    return (n1 > n2 ? n1 : n2);
        //}

        //static void Main(string[] args)
        //{
            //int num1, num2;                 //声明两个变量
            //num1 = 4;                       //赋值
            //num2 = 7;                       //赋值
            ////调用Max函数
            //int s = Max(num1, num2);
            //Console.WriteLine(s);
            //Console.ReadKey();

        //}




        /*实参对形参的数据传递*/
       /* static void S(int n)
        {
            int i;
            Console.WriteLine(n);
            for (i = n - 1; i >= 1; i--)
                n += 1;                     // 改变形参的值
            Console.WriteLine(n);           //输出改变后的形参的值

        }
        static void Main(string[] args)
        {
            int n = 10;                     //定义实参n，并初始化
            S(n);                           //调用函数
            Console.WriteLine(n);           //查看实参是否因函数调用而改变
            Console.ReadKey();              
        } */


        //写一函数，统计字符串中字母的个数
        //static bool Isalp(char c)
        //{
        //    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
       /* static void Main(string[] arge)
        {
            int i, num = 0;                         //声明变量
            string line = Console.ReadLine();       //接收用户输入  |在控制台输入|
            char[] str = line.ToCharArray();        //将字符串转换为字符数组
            int lineLen = str.Length;               //得到字符数组的长度
            for (i = 0; i < lineLen; i++)
            {
                if (Isalp(str[i]))
                {
                    num++;
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }*/


    }
}
