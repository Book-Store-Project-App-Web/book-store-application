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
        BookStoreDataContext dalcontext = new BookStoreDataContext();
        public DALUser() { }

        public User logInUser(string pMail)
        {
            return dalcontext.Users.SingleOrDefault(u => u.email == pMail);
        }
        public List<User> LoadUser() {
            return dalcontext.Users.Select(u => u).ToList<User>();
         }
        public List<UserDK> LoadUserDK()
        {
            return dalcontext.Users.Select(u => new UserDK { firstname = u.firstName, lastname = u.lastName, phone = u.phone, email = u.email, sex = u.sex }).ToList();
        }

        public void AddUser(User user)
        {
            dalcontext.Users.InsertOnSubmit(user);
            dalcontext.SubmitChanges();
        }

        public void UpdateUser(User user)
        {
            var existingUser = dalcontext.Users.SingleOrDefault(u => u.id == user.id);
            if (existingUser != null)
            {
                existingUser.firstName = user.firstName;
                existingUser.lastName = user.lastName;
                existingUser.phone = user.phone;
                existingUser.email = user.email;
                existingUser.password = user.password;
                existingUser.sex = existingUser.sex;
                existingUser.updatedAt = DateTime.Now;
                dalcontext.SubmitChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = dalcontext.Users.SingleOrDefault(u => u.id == id);
            if (user != null)
            {
                dalcontext.Users.DeleteOnSubmit(user);
                dalcontext.SubmitChanges();
            }
        }
    }
}
