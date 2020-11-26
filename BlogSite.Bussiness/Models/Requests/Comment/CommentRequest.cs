using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Comment
{
   public class CommentRequest
    {
        public int commentId { get; set; }
        public int contentId { get; set; }
        public DateTime insertDate { get; set; }

    }
}
