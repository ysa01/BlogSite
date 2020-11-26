using BlogSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Role
{
    public class GetUsersRolesModel
    {
        public List<USERS> Users { get; set; }
        public List<ROLES> Roles { get; set; }

      
    }
}
