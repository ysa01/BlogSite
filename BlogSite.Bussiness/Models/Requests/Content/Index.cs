using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogSite.Bussiness.Models.Requests.Content
{
    public class Index
    {
        public int id { get; set; }
        public int contentId { get; set; }
        public string path { get; set; }
        public string head { get; set; }
        public string text { get; set; }
        
    }
}
