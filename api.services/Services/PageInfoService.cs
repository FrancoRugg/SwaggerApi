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
    public class PageInfoService : IPageInfoRepository
    {
        //Id integer primary key autoincrement,
        //SiteName text,
        //Title text,
        //SubTitle text,
        //Footer1 text,
        //Footer2 text
        public async Task<string> GetInfo()
        {
            string query = "select * from PageInfo;";
            string result = SqliteHandler.GetJson(query);
            return await Task.Run(() => result);
        }
        public async Task<bool> DeletePageInfo(int id)
        {
            string query = $"delete from PageInfo where Id = {id};";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }


        public async Task<bool> PostPageInfo(PageInfo page)
        {
            string query = $"insert into PageInfo VALUES(null,'{page.SiteName}','{page.Title}','{page.SubTitle}','{page.Footer1}','{page.Footer2}');";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }

        public async Task<bool> PutInfo(PageInfo page)
        {
            string query = $"update PageInfo set SiteName = '{page.SiteName}', Title = '{page.Title}',SubTitle ='{page.SubTitle}', Footer1 ='{page.Footer1}',Footer2 ='{page.Footer2}'  where Id = {page.Id};";
            //Le seteo que me actualize el Id 1
            //string query = $"update PageInfo set SiteName = '{page.SiteName}', Title = '{page.Title}',SubTitle ='{page.SubTitle}', Footer1 ='{page.Footer1}',Footer2 ='{page.Footer2}'  where Id = 1;";
            bool result = SqliteHandler.Exec(query);
            return await Task.Run(() => result);
        }
    }
}
