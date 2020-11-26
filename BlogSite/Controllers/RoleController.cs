using BlogSite.Bussiness.Models.Requests.Role;
using BlogSite.Bussiness.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class RoleController : BaseController
    {
        // GET: Role
       
        public ActionResult RoleIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RoleIndex(RoleRequest role )
        {
            rolerepository.RoleInsert(role);
            return View();
        }
        public ActionResult RoleSelect()
        {

            return View(rolerepository.UserRoleList());
        }

        [HttpPost]
        public ActionResult RoleSelect(UserRoleRequest roleRequest)
        {
            rolerepository.RoleSelect(roleRequest);
            return View(rolerepository.UserRoleList());
        }
    }
}