﻿using BussinessObject.Model.Authen;
using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUserRepository
    {
        User Authenticate(UserLogin login);
        void CreateUser(User user);
        void UpdateUser(Guid id, User user);
        User GetUserById(Guid id);
        void DeleteUser(User user);
        List<User> GetAllUsers();
    }
}
