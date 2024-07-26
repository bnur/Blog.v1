using AutoMapper;
using Blog.v1.Core.Dto;
using Blog.v1.Core.Model;
using Blog.v1.Service.Infastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Blog.v1.Api.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleController : ControllerBase
    {
        private IArticleService _service;
        private IMapper _mapper;

        public ArticleController(IArticleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAllAsync();

            return new ObjectResult(_mapper.Map<List<ArticleDto>>(response));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return new ObjectResult(_mapper.Map<ArticleDto>(response));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Article article)
        {
            var response = await _service.AddAsync(article);

            return new ObjectResult(_mapper.Map<ArticleDto>(response));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(ArticleDto article)
        {
            var articleEntity = (Article)_mapper.Map(article, typeof(ArticleDto), typeof(Article));
            await _service.RemoveAsync(articleEntity);

            return new ObjectResult(HttpStatusCode.NoContent);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ArticleDto article)
        {
            var articleEntity = (Article)_mapper.Map(article, typeof(ArticleDto), typeof(Article));
            _service.Update(articleEntity);

            return new ObjectResult(HttpStatusCode.NoContent);
        }

        [HttpGet("/GetByCategoryId")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var response = await _service.GetByCategory(categoryId);

            return new ObjectResult(_mapper.Map<List<ArticleDto>>(response));
        }
    }
}
