using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.models
{
    public class PageInfo
    {
        //Id integer primary key autoincrement,
        //SiteName text,
        //Title text,
        //SubTitle text,
        //Footer1 text,
        //Footer2 text
        public int Id { get; set; }
        public string? SiteName { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Footer1 { get; set; }
        public string? Footer2 { get; set; }
    }
}
