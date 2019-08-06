using BLL;
using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class BlogService
    {
        private BlogRepository _blogRepository;
        public BlogService(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public Blog Get(int id)
        {
            return _blogRepository.Get(id);
        }
        //public IList<Blog> Get(int? bloggerId, int pageIndex, int pageSize)
        //{
        //    IList<Blog> blogs = null;
        //    if (bloggerId.HasValue)
        //    {
        //        blogs = _blogRepository.GetByAuthor(bloggerId.Value);
        //        return _blogRepository.Paged(blogs, pageIndex, pageSize);
        //    }
        //    else
        //    {
        //        return _blogRepository.Get(pageIndex, pageSize);
        //    }
        //}
        //public Blog Publish(Blog blog)
        //{
        //    return _blogRepository.save(blog);
        //}
    }
}
