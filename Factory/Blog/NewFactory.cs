using BLL.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory.Blog
{
    internal class NewFactory
    {

        internal static void Create()
        {
            string path = Environment.CurrentDirectory;

            //选择文件夹---暂未有内容
            //string folderPath = "..\\..\\..\\Blog\\???";
            //string[] filenames = Dictionary.GetFiles(folderPath);
            //for (int i = 0; i < filenames.Length; i++)
            //{   
            //    
            //     string path = filenames[i];
            //    //设定内容
            //    string body File.ReadAllText(path, Encoding.UTF8);
            //    BLL.User author = null;
            //    if (i % 4 ==0)
            //    {
            //        author = RegisterFactory.FeiGe;
            //    }
            //     else
            //    {
            //     author =RegisterFactory.CeshiB;
            //    }
            //    publish(Path,GetFileName(path),body,author); 
            //}

        }
        private static BLL.Blog publich(string title, string body, BLL.User author)
        {
            BlogRepository repository = new BlogRepository(Help.contest);
            BLL.Blog blog = new BLL.Blog
            {
                Title = title,
                Body = body,
                Author = author
            };
            repository.Save(blog);
            return blog;
        }

    }

    //internal class Dictionary
    //{
    //    internal static string[] GetFiles(string folderPath)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
