using BlogSite.Bussiness.Models.Requests.Auth;
using BlogSite.Bussiness.Models.Requests.Content;
using BlogSite.Data;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Security;

namespace BlogSite.Bussiness.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        BLOG_DBEntities _context = new BLOG_DBEntities();
        public bool LoginControl(LoginRequest request)
        {
            var user = _context.USERS.FirstOrDefault(x => x.EMAIL == request.Email && x.PASSWORD == request.Password);
         if(user==null)
                return false;
            return true;
        }
        //register
        public bool RegisterInsert(RegisterRequest request)
        {

            try
            {
                var userControl = _context.USERS.FirstOrDefault(x => x.EMAIL == request.Email);
                if (userControl != null)
                    return false;

                USERS newuser = new USERS()
                {
                    BIRTHDATE= request.BirthDate,
                    FULLNAME = request.FullName,
                    EMAIL = request.Email,
                    PASSWORD = request.Password,
                    INSERTDATE=DateTime.Now,
                    STATUS=1
                };
                var user = _context.USERS.Add(newuser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }

    public interface IAuthRepository
    {
        bool RegisterInsert(RegisterRequest request);
        bool LoginControl(LoginRequest request);
        
    }
}
