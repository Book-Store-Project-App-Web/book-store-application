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
        public string logInUser(string pMail, string pPass)
        {
            if (string.IsNullOrEmpty(pMail))
            {
                return "Email không được trống!";
            }

            if (string.IsNullOrEmpty(pPass))
            {
                return "Mật khẩu không được trống!";
            }
            try
            {
                var user = dalUser.logInUser(pMail,pPass);
                if (user != null)
                {
                    if (dalUser.checkPassUser(user.email, pPass) == true)
                    {
                        return "Đăng nhập thành công";
                    }
                    else
                    {
                        return "Sai mật khẩu";
                    }
                }
                else
                {
                    return "Sai tài khoản";
                }
            }
            catch (Exception ex)
            {
                // Log exception
                throw new Exception("Có lỗi xảy ra trong quá trình đăng nhập", ex);
            }

        }
        public List<User> LoadUser()
        {
            return dalUser.LoadUser();
        }

    }
}
