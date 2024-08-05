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
            try
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
                if (user == null)
                {
                    MessageBox.Show("Sai tài khoản!");
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
            catch (Exception ex)
            {
                // Log exception
                throw new Exception("Có lỗi xảy ra trong quá trình đăng nhập", ex);
            }

        }
        public List<UserDK> LoadUserDK()
        {
            return dalUser.LoadUserDK();
        }

        public List<User> LoadUser()
        {
            return dalUser.LoadUser();
        }
        public void AddUser(User user)
        {
            dalUser.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            dalUser.UpdateUser(user);
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
