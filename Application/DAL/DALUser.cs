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
        public List<UserDK> LoadUser()
        {
            return bt.Users.Select(u => new UserDK { firstname = u.firstName, lastname = u.lastName, phone = u.phone, email = u.email, sex = u.sex }).ToList();
        }
    }
}
