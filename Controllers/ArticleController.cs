using api.models;
using api.services.Handlers;
using api.services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AngularApi.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticlesRepository _articleservice;

        public ArticleController(IArticlesRepository articleservice)
        {
            _articleservice = articleservice;
        }
        [HttpGet]
        public async Task<string> GetArticles()
        {
            return await Task.Run(() => _articleservice.GetArticles());
        }
        [HttpGet("byId")]
        public async Task<string> GetArticleById(int id)
        {
            return await Task.Run(() => _articleservice.GetArticleById(id));
        }
        [HttpDelete]
        public async Task<bool> DeleteArticles(int id)
        {
            return await Task.Run(() => _articleservice.DeleteArticles(id));
        }
        [HttpPost]
        public async Task<bool> PostArticles(Articles article)
        {
            return await Task.Run(() => _articleservice.PostArticles(article));
        }
        [HttpPut]
        public async Task<bool> PutArticles(Articles article)
        {
            return await Task.Run(() => _articleservice.PutArticles(article));
        }
    }
}
