using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.DAL.Repository
{
    public class UserDAL
    {
        private readonly CoffeeDbContext _context;

        public UserDAL()
        {
            _context = new CoffeeDbContext();
        }

        // Giữ nguyên các phương thức hiện có
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserByName(string _name)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == _name);
        }

        public void AddUser(User _user)
        {
            try
            {
                _context.Users.Add(_user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateUser(User _user)
        {
            try
            {
                var existingUser = _context.Users.Find(_user.UserID);
                if (existingUser != null)
                {
                    _context.Entry(existingUser).CurrentValues.SetValues(_user);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUser(string _userID)
        {
            try
            {
                var user = _context.Users.Find(_userID);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Thêm các phương thức mới
        public User GetUserById(string userId)
        {
            return _context.Users
                .Include(u => u.Orders)
                .Include(u => u.BaristaQueues)
                .FirstOrDefault(u => u.UserID == userId);
        }

        public List<User> GetUsersByRole(string role)
        {
            return _context.Users
                .Where(u => u.Role == role && u.IsActive)
                .ToList();
        }

        public List<User> GetActiveUsers()
        {
            return _context.Users
                .Where(u => u.IsActive)
                .ToList();
        }

        public List<User> SearchUsers(string searchTerm)
        {
            return _context.Users
                .Where(u => u.UserName.Contains(searchTerm) ||
                           u.FullName.Contains(searchTerm) ||
                           u.Email.Contains(searchTerm))
                .ToList();
        }

        public List<User> SearchUsers(string searchTerm, string role)
        {
            return _context.Users
                .Where(u => (string.IsNullOrEmpty(searchTerm) ||
                             u.UserName.Contains(searchTerm) ||
                             u.FullName.Contains(searchTerm) ||
                             u.Email.Contains(searchTerm)) &&
                            u.Role.Contains(role))
                .ToList();
        }
    }
}
