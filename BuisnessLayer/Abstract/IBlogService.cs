using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> GetAll();
        List<Blog> GetBlogListWithCategory();
        Blog GetById(int id);

        List<Blog> GetAllById(int id);


    }
}
