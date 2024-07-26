using Blog.v1.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Core.Repositories
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
    }
}
