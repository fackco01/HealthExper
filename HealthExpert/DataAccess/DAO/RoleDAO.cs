using BussinessObject.ContextData;
using BussinessObject.Model;
using BussinessObject.Model.Authen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class RoleDAO
    {
        //GET LIST OF ROLE
        public static List<Role> GetListRoles()
        {
            List<Role> roleList = new List<Role>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    roleList = ctx.Roles.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return roleList;
        }
    }
}
