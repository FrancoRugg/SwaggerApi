using api.services.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace AngularApi.Controllers
{
    public class DataBaseController : ControllerBase
    {
        //DataBaseService service = new DataBaseService();
        private readonly IDatabaseRepository _dataBaseService;

        public DataBaseController(IDatabaseRepository dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        [HttpGet("createDb")]
        public async Task<bool> createDb()
        {
            return await Task.Run(() => _dataBaseService.CreateDataBase());
        }

        [HttpGet("createTBArticles")]
        public async Task<bool> createTBArticles()
        {
            return await Task.Run(() => _dataBaseService.CreateTableArticles());
        }
        [HttpGet("createTBPageInfo")]
        public async Task<bool> createTBPageInfo()
        {
            return await Task.Run(() => _dataBaseService.CreateTablePageInfo());
        }


    }
}
