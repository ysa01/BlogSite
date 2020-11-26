using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Content
{
   public class InsertContentRequest
    {
        public string ContentHead { get; set; }
        public string ContentText { get; set; }
        public int CategoriId { get; set; }
    }
}
