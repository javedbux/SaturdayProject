using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;

namespace HRMExpress.Service
{
   public interface IUserService
    {
        IQueryable<User> GetUsers();
        User GetUser(long id);        
        void InsertUser(User user);
        void UpdateUser(User updateUser);
        void DeleteUser(User deleteUser);
    }
}
