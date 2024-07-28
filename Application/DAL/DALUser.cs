using System;
using System.Collections.Generic;
using System.Data;
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
            //return bt.Users.Where(u => u.email == pMail).FirstOrDefault();
            return bt.Users.SingleOrDefault(u => u.email == pMail);
        }
        public bool checkPassUser(string pMail, string pPass)
        {
            //var passuser = bt.Users.Where(u => u.email == pMail).Select(u => new { u.password }).FirstOrDefault();
            //if(passuser != null && Convert.ToString(passuser) == pPass)
            //{
            //    return true;
            //}
            //return false;
            var user = bt.Users.Where(u => u.email == pMail).Select(u => new { u.password }).FirstOrDefault();
            if (user != null && user.password == pPass)
            {
                return true;
            }
            return false;

        }

        public List<User> LoadUser()
        {
            return bt.Users.Select(id => id).ToList<User>();
        }
    }
}
