using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace api.models
{
    public class Articles
    {
        //create table Articles(Id integer primary key autoincrement,
        //Title text,
        //Description text,
        //Autor text,
        //Image varchar(200),
        //Day text,
        //Contain text
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Autor { get; set; }
        public string? Image { get; set; }
        public string? Day { get; set; }
        public string? Contain { get; set; }
    }
}
