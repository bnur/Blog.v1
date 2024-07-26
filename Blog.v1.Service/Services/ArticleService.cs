using Blog.v1.Core.Model;
using Blog.v1.Core.Repositories;
using Blog.v1.Core.UnitOfWork;
using Blog.v1.DataAccess;
using Blog.v1.DataAccess.Repository;
using Blog.v1.Service.Infastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Service.Services
{
    public class ArticleService : BaseService<Article>, IArticleService
    {
        IUnitOfWork _unitOfWork;
        IArticleRepository _articleRepository;
        public ArticleService(IUnitOfWork unitOfWork, IArticleRepository articleRepository) : base(articleRepository, unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Article>> GetByCategory(int categoryId)
        {
            var articlesInCategory = await _articleRepository.GetAllAsync();

            return articlesInCategory.Where(a=>a.CategoryId == categoryId).ToList();

        }

    }
}
