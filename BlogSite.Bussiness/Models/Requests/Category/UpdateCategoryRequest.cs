using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Category
{
    public class UpdateCategoryRequest
    {
        public int CATEGORIID { get; set; }
        public string CATEGORINAME { get; set; }
        public string CATEGORILINK { get; set; }
    }
}
