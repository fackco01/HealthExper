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
    public class UserDAO
    {
        //GET USER
        public static User GetUser(UserLogin login)
        {
            var user = new User();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    user = ctx.Users.FirstOrDefault(o => o.userName == login.userName && o.password == login.password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return user;
        }

        //GET USER BY ID
        public static User GetUserByID(Guid id)
        {
            var user = new User();

            return user;
        }
        //ADD USER
        //UPDATE USER
        //DELETE USER
    }
}
