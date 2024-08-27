using api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IArticlesRepository
    {
        public Task<string> GetArticles();
        public Task<string> GetArticleById(int id);
        public Task<bool> PostArticles(Articles user);
        public Task<bool> PutArticles(Articles user);
        public Task<bool> DeleteArticles(int id);
    }
}
