using api.models;
using api.services.Handlers;
using api.services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class ArticlesService : IArticlesRepository
    {
        //create table Articles(Id integer primary key autoincrement,
        //Title text,
        //Description text,
        //Autor text,
        //Image varchar(200),
        //Day text,
        //Contain text
        public async Task<bool> DeleteArticles(int id)
        {
            string query = $"delete from Articles where Id = {id};";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }

        public async Task<string> GetArticleById(int id)
        {
            string query = $"select * from Articles where Id = {id};";
            string result = SqliteHandler.GetJson(query);
            return await Task.Run(() => result);
        }

        public async Task<string> GetArticles()
        {
            string query = "select * from Articles;";
            string result = SqliteHandler.GetJson(query);
            return await Task.Run(() => result);
        }

        public async Task<bool> PostArticles(Articles article)
        {
            string query = $"insert into Articles VALUES(null,'{article.Title}','{article.Description}','{article.Autor}','{article.Image}','{article.Day}','{article.Contain}');";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }

        public async Task<bool> PutArticles(Articles article)
        {
            string query = $"update Articles set Title = '{article.Title}', Description = '{article.Description}',Autor ='{article.Autor}', Image ='{article.Image}',Day ='{article.Day}',Contain ='{article.Contain}'  where Id = {article.Id};";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }
    }
}
