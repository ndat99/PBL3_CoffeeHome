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
                _userDAL.UpdateUser(user);
                return user;
            }
            return null;
        }

        public User GetUserById(string userId)
        {
            return _userDAL.GetUserById(userId);
        }

        public User GetUserByName(string username)
        {
            return _userDAL.GetUserByName(username);
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

        public List<User> SearchUsers(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _userDAL.GetAllUsers(); 
            }
            return _userDAL.SearchUsers(searchTerm);
        }

        public List<User> SearchUsers(string searchTerm , string Role)
        {
            return _userDAL.SearchUsers(searchTerm,Role);
        }

        // Thêm các phương thức validation
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) return true;
            return phoneNumber.All(char.IsDigit);
        }

        public bool IsValidRole(string role)
        {
            string[] validRoles = { "Admin", "Cashier", "Barista" };
            return validRoles.Contains(role);
        }

        public bool IsUsernameExists(string username)
        {
            return GetUserByName(username) != null;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return true; // Email không bắt buộc

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                // Kiểm tra thêm các điều kiện cần thiết
                var parts = email.Split('@');
                var domain = parts[1];

                // Kiểm tra domain không bắt đầu/kết thúc bằng dấu chấm
                if (domain.StartsWith(".") || domain.EndsWith("."))
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }


        // Validate tổng hợp
        public void ValidateUserData(string username, string role, string phoneNumber, string email)
        {
            if (IsUsernameExists(username))
            {
                throw new ArgumentException("Tên đăng nhập đã tồn tại!");
            }

            if (!IsValidRole(role))
            {
                throw new ArgumentException("Vai trò phải là một trong các giá trị: Admin, Cashier, Barista!");
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Số điện thoại chỉ được chứa các chữ số!");
            }

            if(!IsValidEmail(email))
            {
                throw new ArgumentException("Email không hợp lệ!");
            }
        }

        public string GenerateNewUserId()
        {
            try
            {
                var users = GetALlUsers();
                if (!users.Any())
                {
                    return "USR001";
                }

                // Lấy số thứ tự lớn nhất hiện tại
                var maxId = users
                    .Select(u => int.Parse(u.UserID.Substring(3)))
                    .Max();

                // Tạo ID mới với số thứ tự tăng thêm 1
                return $"USR{(maxId + 1):D3}";
            }
            catch (Exception)
            {
                throw new Exception("Không thể tạo mã người dùng mới!");
            }
        }
    }
}
