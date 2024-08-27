using api.services.Handlers;
using api.services.Repositories;

namespace api.services.Services
{
    public class DataBaseService : IDatabaseRepository
    {
        public async Task<bool> CreateDataBase()
        {
            bool response = false;
            //Para que tome el data source, recordar agregar en los appsettings.json de la carpeta principal(AngularApi)
            //Esta dependencia con el nombre de la bdd a crear:
            //,
            //"ConnectionStrings": {
            //"defaultConnection": "Data source=DataBase/tp3AngularApi.db"
            //}
        string database = SqliteHandler.ConnString.Replace("Data source=", "");
            if (!File.Exists(database))
            {
                try
                {
                    StreamWriter writer = File.CreateText(database);
                    response = true;
                }
                catch (Exception ex)
                {

                    response = false;
                }

            }
            return response;
        }

        public async Task<bool> CreateTableArticles()
        {
            string query = "create table Articles(Id integer primary key autoincrement, Title text, Description text, Autor text, Image varchar(200), Day text, Contain text);";
            bool response = SqliteHandler.Exec(query);

            return response;
        }
        public async Task<bool> CreateTablePageInfo()
        {
            string query = "create table PageInfo(Id integer primary key autoincrement, SiteName text, Title text, SubTitle text, Footer1 text, Footer2 text);";
            bool response = SqliteHandler.Exec(query);

            return response;
        }
    }
}
