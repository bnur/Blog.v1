using Blog.v1.Core.Model;
using Blog.v1.Core.Repositories;
using Blog.v1.Core.UnitOfWork;
using Blog.v1.Service.Infastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Service.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<Category> _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = repository;
        }

    }
}
