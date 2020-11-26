using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Content
{
   public class InsertCotegoriesRequest
    {
        public string categoriesName { get; set; }
        public string categoriesLink { get; set; }
        public string categoriesFile { get; set; }
    }
}
