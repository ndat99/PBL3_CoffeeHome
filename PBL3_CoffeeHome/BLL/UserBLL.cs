using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.BLL
{
    public class UserBLL
    {
        private readonly UserDAL _userDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
        }
        public List<User> GetALlUsers()
        {
            return _userDAL.GetAllUsers();
        }

        public bool AddUser(User _user, string password)
        {
            if (_userDAL.GetUserByName(_user.UserName) != null)
            {
                return false;
            }

            _user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            _userDAL.AddUser(_user);
            return true;
        }

        public void UpdateUser(User _user)
        {
            _userDAL.UpdateUser(_user);
        }

        public void DeleteUser(string _userId)
        {
            _userDAL.DeleteUser(_userId);
        }

        // Thêm các phương thức mới
        public User Login(string username, string password)
        {
            var user = _userDAL.GetUserByName(username);
            if (user != null && user.IsActive && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                user.LastLoginAt = DateTime.Now;
                _userDAL.UpdateUser(user);
                return user;
            }
            return null;
        }

        public User GetUserById(string userId)
        {
            return _userDAL.GetUserById(userId);
        }

        public bool ChangePassword(string userId, string oldPassword, string newPassword)
        {
            var user = _userDAL.GetUserById(userId);
            if (user != null && BCrypt.Net.BCrypt.Verify(oldPassword, user.PasswordHash))
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                _userDAL.UpdateUser(user);
                return true;
            }
            return false;
        }

        public List<User> GetUsersByRole(string role)
        {
            return _userDAL.GetUsersByRole(role);
        }

        public bool DeactivateUser(string userId)
        {
            var user = _userDAL.GetUserById(userId);
            if (user != null)
            {
                user.IsActive = false;
                _userDAL.UpdateUser(user);
                return true;
            }
            return false;
        }

        public bool ActivateUser(string userId)
        {
            var user = _userDAL.GetUserById(userId);
            if (user != null)
            {
                user.IsActive = true;
                _userDAL.UpdateUser(user);
                return true;
            }
            return false;
        }

        public bool UpdateUserInfo(string userId, string fullName, string email, string phone)
        {
            var user = _userDAL.GetUserById(userId);
            if (user != null)
            {
                user.FullName = fullName;
                user.Email = email;
                user.PhoneNumber = phone;
                _userDAL.UpdateUser(user);
                return true;
            }
            return false;
        }

        public bool ChangeUserRole(string userId, string newRole)
        {
            if (!new[] { "Admin", "Cashier", "Barista" }.Contains(newRole))
                return false;

            var user = _userDAL.GetUserById(userId);
            if (user != null)
            {
                user.Role = newRole;
                _userDAL.UpdateUser(user);
                return true;
            }
            return false;
        }
    }
}
