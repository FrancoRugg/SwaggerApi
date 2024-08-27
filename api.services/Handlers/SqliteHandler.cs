using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.Data;
using Formatting = Newtonsoft.Json.Formatting;
using Microsoft.Data.Sqlite;

namespace api.services.Handlers
{
    public class SqliteHandler
    {
        //Cadena de conexion 
        //Utilizar el Mode=ReadWrite para poder sobreescribir en la bdd, sinó no vas a poder ejecutar el crear nuevas tablas correctamente
        public static string ConnString = "Data Source=tp3AngularApi.db;Mode=ReadWrite;";

        public static string GetJson(string query)
        {
            DataTable dt = GetDataTable(query);
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return json;
        }
        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            SqliteConnection conn = new SqliteConnection(ConnString);
            conn.Open();
            SqliteCommand command = new SqliteCommand(query, conn);
            command.CommandText = query;
            SqliteDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;
        }
        public static bool Exec(string query)
        {
            bool result = false;
            //Creo la conexion
            SqliteConnection conn = new SqliteConnection(ConnString);
            //Creo un comando 
            SqliteCommand command = new SqliteCommand(query, conn);
            conn.Open(); //abro la conexion
            try
            {
                command.ExecuteNonQuery();
                result = true;
            }
            catch (System.Exception)
            {
                result = false;
            }
            conn.Close(); //cierro la conexion 
            return result;
        }
    }
}
