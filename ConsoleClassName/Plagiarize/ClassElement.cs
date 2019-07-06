using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleClassName.Element_inversion
{
    class Classelement
    {
        /*
         练习：将一个字符串数组的元素的顺序进行反转
         *{"3" ,"a", "8", "haha"} 转换为{"haha", "8", "a", "3"}   
         *提示：第i个和的length-i-个进行交换
             */
        //Main函数是入口函数，在生成一个项目的时候会在Program类里面自动生成，不要对它进行修改
        //也不要在其他类里面声明这个方法，下面这个方法名应改为其他名字
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
