using BlogSite.Bussiness.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class BaseController : Controller
    {
        protected static readonly AuthRepository authrepository = new AuthRepository();
        protected  static readonly ContentRepository contentrepository = new ContentRepository();
        protected static readonly RoleRepository rolerepository = new RoleRepository();
    }
}