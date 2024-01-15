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

        //GET LIST OF USER
        public static List<User> GetListUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    userList = ctx.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return userList;
        }

        //GET USER BY ID
        public static User GetUserByID(Guid id)
        {
            var user = new User();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    user = ctx.Users.FirstOrDefault(o => o.userId == id);
                }
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }

            return user;
        }
        //ADD USER
        public static void AddUser(User user)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //UPDATE USER
        public static void UpdateUser(Guid id, User user)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    if (GetUserByID(id) != null)
                    {
                        ctx.Users.Add(user);
                        ctx.Entry(user).State =
                            Microsoft.EntityFrameworkCore.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //DELETE USER
        public static void DeleteUser(User user)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var p1 = ctx.Users.SingleOrDefault(
                        x => x.userId == user.userId);
                    ctx.Users.Remove(p1);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
