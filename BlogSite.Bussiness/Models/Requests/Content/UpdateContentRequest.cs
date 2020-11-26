using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Content
{
   public class UpdateContentRequest
    {
        public int ContentId { get; set; }
        public string ContentHead { get; set; }
        public string ContentText { get; set; }
        public string ContentFile { get; set; }
        
    }
}
