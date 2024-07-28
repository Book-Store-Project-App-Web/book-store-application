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
        public void logInUser(string pMail, string pPass)
        {
            if(string.IsNullOrEmpty(pMail) && string.IsNullOrEmpty(pPass))
            {
                MessageBox.Show("Email và mật khẩu không được trống !");
                return;
            }
            var user = dalUser.logInUser(pMail, pPass);
            if (user != null)
            {
                if (dalUser.checkPassUser(user.email, pPass) == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");

                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản");
            }
        }
    }
}
