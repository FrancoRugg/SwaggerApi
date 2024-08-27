using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Repositories
{
    public interface IDatabaseRepository
    {

        public Task<bool> CreateDataBase();

        public Task<bool> CreateTableArticles();

        public Task<bool> CreateTablePageInfo();


    }
}
