using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/*
 练习：将一个字符串数组的元素的顺序进行反转
 *{"3" ,"a", "8", "haha"} 转换为{"haha", "8", "a", "3"}   
 *提示：第i个和的length-i-个进行交换
     */
namespace ConsoleClassName.Element_inversion
{
    class Classelement
    {
       /* static void Main(string[] args)
        {
            //声明一个字符串数组，并赋值
            string[] st = new string[] { "3", "a", "8", "haha" };
            //string[] st = new string[] {"3", "a", "8", "haha", "qw"};
            string s;                                                     //声明一个中间数值

            //对数组长度进行单双判断
            if (st.Length % 2 == 0)
            {
                for (int i = 0; i < st.Length / 2; i++)
                {
                    s = st[i];
                    st[i] = st[st.Length - i - 1];
                    st[st.Length - i - 1] = s;
                }
            }
            foreach (var a in st)
            {
                Console.Write(" "+a);
            }
            Console.ReadKey();
        }*/

    }
}
