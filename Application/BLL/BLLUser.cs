using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;


namespace BLL
{
    public class BLLUser
    {
        DALUser dalUser = new DALUser();
        public BLLUser()
        {
        }
        public User logInUser(string pMail, string pPass)
        {            
            if (string.IsNullOrEmpty(pMail))
            {
                MessageBox.Show("Email không được trống!");
            }
            if (string.IsNullOrEmpty(pPass))
            {
                MessageBox.Show("Mật khẩu không được trống!");
            }
            var user = dalUser.logInUser(pMail);
            if (!string.IsNullOrEmpty(pMail) && !string.IsNullOrEmpty(pPass) && user == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chinh xác!");
                return null;
            }

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(pPass, user.password);
            if (isPasswordValid)
            {
                return user;
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!");
                return null;
            }
        }
        public List<UserDK> LoadUserDK()
        {
            return dalUser.LoadUserDK();
        }

        public List<dynamic> LoadUser()
        {
            return dalUser.LoadUser();
        }
        public List<dynamic> SearchUser(string searchText)
        {
            return dalUser.SearchUser(searchText);
        }
        public void AddUser(User user)
        {
            User _user = new User();
            _user.firstName = user.firstName;
            _user.lastName = user.lastName;
            _user.email = user.email;
            _user.phone = user.phone;
            _user.sex = user.sex;
            _user.password = BCrypt.Net.BCrypt.HashPassword(user.password);
            _user.createdAt = DateTime.Now;
            _user.updatedAt = DateTime.Now;
            dalUser.AddUser(_user);
        }

        public void UpdateUser(int id,User user)
        {
            dalUser.UpdateUser(id,user);
        }

        public void DeleteUser(int id)
        {
            dalUser.DeleteUser(id);
        }
        public User GetUserById(int userId)
        {
            return dalUser.GetUserById(userId);
        }
    }
}
