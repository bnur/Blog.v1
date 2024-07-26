using Blog.v1.Core.Model;
using Blog.v1.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.DataAccess.Repository
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly AppDbContext _context;
        public ArticleRepository(AppDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
