using BlogSite.Bussiness.Models.Requests.Auth;
using BlogSite.Bussiness.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogSite.Controllers
{
    public class AuthController : BaseController
    {

        // GET: Auth
     
        public ActionResult AdminPanel()
        {
            
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginRequest request)
        {
            bool control = authrepository.LoginControl(request);
            if (control) { 
                if (request.Email != null)
            {
                FormsAuthentication.SetAuthCookie(request.Email, false);
                return RedirectToAction("AdminPanel", "Auth");
            }
                else
                {
                    return View();
                }
            }
            else
            
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterRequest request)
        {
            if (request.Password!=request.ConfirmPassword)
                return View();

            bool control = authrepository.RegisterInsert(request);
            if(control)
                return RedirectToAction("Login", "Auth");
            return View();
        }

    }
}