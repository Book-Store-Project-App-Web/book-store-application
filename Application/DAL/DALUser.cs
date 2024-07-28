using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DALUser
    {
        BookStoreDataContext bt = new BookStoreDataContext();
        public DALUser() { }

        public User logInUser(string pMail,string pPass)
        {
            return bt.Users.Where(u => u.email == pMail).FirstOrDefault();
        }
        public bool checkPassUser(string pMail, string pPass)
        {
            var passuser = bt.Users.Where(u => u.email == pMail).Select(u => new { u.password }).FirstOrDefault();
            if(passuser != null && Convert.ToString(passuser) == pPass)
            {
                return true;
            }
            return false;

        }
    }
}
