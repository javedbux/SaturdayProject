using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;
using HRMExpress.Data;

namespace HRMExpress.Service
{
    public class UserService : IUserService
    {
    
        private IRepository<User> userRepository;
        //private IRepository<Department> departmentRepository;


        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
            //this.departmentRepository = departmentRepository;
        }
        public IQueryable<User> GetUsers()
        {
            return userRepository.Table;
        }

        public User GetUser(long id)
        {
            return userRepository.GetById(id);
        }

        //public User GetUserLogin(User  user)
        //{
        //    return userRepository.GetById(id);
        //}

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }
    }
}
