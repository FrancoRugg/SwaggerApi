using api.models;
using api.services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Core.Persistence.Repositories;

namespace AngularApi.Controllers
{
    [Route("api/page")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageInfoRepository _pageservice;

        public PageController(IPageInfoRepository pageservice)
        {
            _pageservice = pageservice;
        }
        [HttpGet]
        public async Task<string> GetInfo()
        {
            return await Task.Run(() => _pageservice.GetInfo());
        }
        
        [HttpDelete]
        public async Task<bool> DeletePageInfo(int id)
        {
            return await Task.Run(() => _pageservice.DeletePageInfo(id));
        }
        [HttpPost]
        public async Task<bool> PostPageInfo(PageInfo page)
        {
            return await Task.Run(() => _pageservice.PostPageInfo(page));
        }
        [HttpPut]
        public async Task<bool> PutInfo(PageInfo page)
        {
            return await Task.Run(() => _pageservice.PutInfo(page));
        }
    }
}
