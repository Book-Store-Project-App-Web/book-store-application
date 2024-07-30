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

        public User logInUser(string pMail)
        {
            return bt.Users.SingleOrDefault(u => u.email == pMail);
        }
        public bool checkPassUser(string pMail, string pPass)
        {
            var user = bt.Users.Where(u => u.email == pMail).Select(u => new { u.password }).FirstOrDefault();
            if (user != null && user.password == pPass)
            {
                return true;
            }
            return false;

        }

        public List<UserDK> LoadUser()
        {
            return bt.Users.Select(u => new UserDK { firstname = u.firstName, lastname = u.lastName, phone = u.phone, email = u.email, sex = u.sex }).ToList();
        }
    }
}
