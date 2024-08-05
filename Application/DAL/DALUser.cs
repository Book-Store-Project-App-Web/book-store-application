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
        public List<dynamic> LoadUser() {
            return dalcontext.Users.Select(u => new
            {
                u.id,
                u.lastName,
                u.firstName,
                u.email,
                u.phone,
                u.sex,
                u.createdAt
            }
            ).ToList<dynamic>();
         }
        public List<dynamic> SearchUser(string searchText)
        {
            return dalcontext.Users.Where(u => u.email.Contains(searchText) || u.lastName.Contains(searchText)).Select(u => new
            {
                u.id,
                u.lastName,
                u.firstName,
                u.email,
                u.phone,
                u.sex,
                u.createdAt
            }
            ).ToList<dynamic>();
        }

        public List<UserDK> LoadUserDK()
        {
            return dalcontext.Users.Select(u => new UserDK { id = u.id, firstname = u.firstName, lastname = u.lastName, phone = u.phone, email = u.email, sex = u.sex }).ToList();
        }

        public void AddUser(User user)
        {
            dalcontext.Users.InsertOnSubmit(user);
            dalcontext.SubmitChanges();
        }

        public void UpdateUser(int id,User user)
        {
            var existingUser = dalcontext.Users.SingleOrDefault(u => u.id == id);
            if (existingUser != null)
            {
                existingUser.firstName = user.firstName;
                existingUser.lastName = user.lastName;
                existingUser.phone = user.phone;
                existingUser.email = user.email;
                existingUser.sex = user.sex;
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
