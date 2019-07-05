using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleClassName.Array
{
  /*class TASK
    {
        /// <summary>
        /// 启动方式
        /// </summary>
        public static void Startway()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Hello, task");
            });
            task1.Start();
            var task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello, task started by task factory");
            });
        }
        /// <summary>
        /// 生命周期测试
        /// </summary>
        public static void LifeCircle()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Finish");
            });
            Console.WriteLine("Befoce start:" +task1.Status);
            task1.Start();
            Console.WriteLine("After start:" + task1.Status);
            task1.Wait();
            Console.WriteLine("After Finish:" + task1.Status);
        }
        /// <summary>
        /// 等待所有任务完成
        /// </summary>
        public static void WaitAll()
        {
            var task1 = new Task(() =>
           {
               Console.WriteLine("Task 1 Begin");
               System.Threading.Thread.Sleep(2000);
               Console.WriteLine("Task 1 Finish");
           });
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 2 Finish");
            });
            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);
            Console.WriteLine("waitAll task finished!");
        }/// <summary>
        /// 等待任意一个执行任务完成
        /// </summary>
        public static void WaitAny()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 1 Finish");
            });
            var task2 = new Task(() =>
           {
               Console.WriteLine("Task 1 Begin");
               System.Threading.Thread.Sleep(2000);
               Console.WriteLine("Task 1 Finish");
           });
            task1.Start();
            task2.Start();
            Task.WaitAny(task1, task2);
            Console.WriteLine("WaitAny task finished!");
        }
        /// <summary>
        /// 任务回调方法
        /// </summary>
        public static void ContinueWith()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Task 1 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 1 Finish");
            });
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Task 2 Finish");
            });
            task1.Start();
            task2.Start();
            var result = task1.ContinueWith<string>(task =>
            {
                Console.WriteLine("task1 finished!");
                return "This is task1 result!";
            });
        }
        /// <summary>
        /// 取消任务
        /// </summary>
        public static void Cancel()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Abort mission success!");
                        return;
                    }
                }
            },token);
            token.Register(() =>
            {
                Console.WriteLine("Canceled");
            });
            Console.WriteLine("Press enter to cancel task...");
            Console.ReadKey();
            tokenSource.Cancel();

            Console.ReadKey();
        }
        /// <summary>
        /// 函数入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("StarWay is runing");
            Startway();
            Console.WriteLine("LifeCircle is runing");
            LifeCircle();
            Console.WriteLine("WaitAll is runing");
            WaitAll();
            Console.WriteLine("ContinueWit is runing");
            ContinueWith();
            Console.WriteLine("Cancel is runing");
            Cancel();

            Console.Read();
        }
    }*/
}
