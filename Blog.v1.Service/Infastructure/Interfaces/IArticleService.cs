using Blog.v1.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Service.Infastructure.Interfaces
{
    public interface IArticleService : IBaseService<Article>
    {
        Task<List<Article>> GetByCategory(int categoryId);
    }
}
