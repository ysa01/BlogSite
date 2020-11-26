using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Role
{
  public  class UserRoleRequest
    {
        public int roleId { get; set; }
        public int userId { get; set; }
    }
}
