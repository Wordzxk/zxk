using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassName.Array
{
    class Copy
    {
       /* static void Main(string[] args)
        {
            int guessCount = 10;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Random random = new Random();
            int first = random.Next(9) + 1;              //首位不为0
            int second = random.Next(9);                 //要求不重复 所以依次递减 还剩9个
            int third = random.Next(8);
            int fourth = random.Next(7);
            //系统生成随机四位数 number
            int number = list[first] * 1000;
            list.RemoveAt(first);
            number += list[second] * 100;
            list.RemoveAt(third);
            number += list[fourth];
            list.RemoveAt(fourth);
            //系统生成了随机四位数 number
            string systemNumber = number.ToString();
            //当剩余次数大于0
            while (guessCount > 0)
            {
                Console.Write("请输入四位数字：");
                string input = Console.ReadLine().Trim();
                int inputNumber = 0;
                int a = 0;                                  //猜位置
                int b = 0;                                  //猜数字
                //如果输入的是数字 且长度为四
                if (int.TryParse(input, out inputNumber)
                    && inputNumber.ToString().Length == 4)
                {
                    string guessNumber = inputNumber.ToString();
                    //如果有重复 比如输入了1233
                    if (guessNumber[0].Equals(guessNumber[1])
                        || guessNumber[0].Equals(guessNumber[2])
                        || guessNumber[0].Equals(guessNumber[3])
                        || guessNumber[0].Equals(guessNumber[3]))
                    {
                        Console.WriteLine("不能输入有重复的数字\n");
                        continue;
                    }
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            //含数字的情况
                            if (systemNumber.Contains(guessNumber[i]))
                            {
                                b++;
                            }
                            //恰等于的情况
                            if (systemNumber[i].Equals(guessNumber[i]))
                            {
                                a++;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("输入的不是四位数字\n");
                    continue;
                }
                //位置全猜对时
                if (a == 4)
                {
                    Console.WriteLine("恭喜你猜对了");
                    break;
                }
                else
                {
                    Console.WriteLine("猜对数字的个数为"+ b +",猜对位置的个数时" + a);
                }
                //剩余次数
                guessCount--;
                if (guessCount == 0)
                {
                    Console.WriteLine("没有机会了！正确答案为："+ systemNumber);
                }
                else
                {
                    Console.WriteLine("还剩"+ guessCount + "次机会\n");
                }
            }
            Console.WriteLine("\n按回车键退出， 按其他任意键继续猜~ ~");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                return;
            }
            else
            {
                Console.Clear();
                Main(null);
            }
        }*/
    }
}
