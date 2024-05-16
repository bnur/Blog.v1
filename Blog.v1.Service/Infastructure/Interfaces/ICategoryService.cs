using Blog.v1.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Service.Infastructure.Interfaces
{
    public interface ICategoryService : IBaseService<Category>
    {
        //public Category GetByArticleId(int articleId);
    }
}
