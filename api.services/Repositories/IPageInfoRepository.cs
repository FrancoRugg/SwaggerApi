using api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IPageInfoRepository
    {
        public Task<string> GetInfo();
        public Task<bool> PostPageInfo(PageInfo user);
        public Task<bool> PutInfo(PageInfo user);
        public Task<bool> DeletePageInfo(int id);
    }
}
