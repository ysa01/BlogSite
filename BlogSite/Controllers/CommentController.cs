﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class CommentController : BaseController
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
    }
}