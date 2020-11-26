using BlogSite.Bussiness.Models.Requests.Role;
using BlogSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace BlogSite.Bussiness.Repositories
{
    
    public class RoleRepository: IRoleRepository
    {
        BLOG_DBEntities _context = new BLOG_DBEntities();
        public void RoleInsert(RoleRequest role)
        {
            ROLES RoleInsert = new ROLES()
            {
               
                NAME=role.roleName,
                INSERTDATE=DateTime.Now,
                STATUS=1
            };
            _context.ROLES.Add(RoleInsert);
            _context.SaveChanges();
        }
        public GetUsersRolesModel UserRoleList()
        {
            List<USERS> users = _context.USERS.ToList();
            List<ROLES> roles = _context.ROLES.ToList();

            GetUsersRolesModel getUsersRolesModel = new GetUsersRolesModel()
            {
                Users = users,
                Roles = roles
            };
            return getUsersRolesModel;
               
        }
        public void RoleSelect(UserRoleRequest roleRequest)
        {
            USER_ROLE userRole = new USER_ROLE() {
                USERID= roleRequest.userId,
                ROLEID =roleRequest.roleId,
                STATUS = 1,
                INSERTDATE=DateTime.Now
            };
            _context.USER_ROLE.Add(userRole);
            _context.SaveChanges();

        }
        
    }
    
    public interface IRoleRepository
    {
        void RoleInsert(RoleRequest role);
        void RoleSelect(UserRoleRequest roleRequest);
        GetUsersRolesModel UserRoleList();

    }
}
