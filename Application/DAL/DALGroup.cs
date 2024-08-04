using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALGroup
    {
        BookStoreDataContext dalcontext = new BookStoreDataContext();

        public DALGroup()
        {
        }
        public List<dynamic> LoadGroup()
        {
            return dalcontext.Groups.Select(result => new
            {
                result.id,
                result.groupName,
                result.description,
            }).ToList<dynamic>();
        }
        //public List<Group> LoadGroup()
        //{
        //    return dalcontext.Groups.Select(g => g).ToList<Group>();
        //}
        public List<dynamic> LoadGroup_User(int groupId)
        {
            var query = dalcontext.Group_Users
           .Join(dalcontext.Groups,
                 gr_u => gr_u.groupId,
                 gr => gr.id,
                 (gr_u, gr) => new { gr_u, gr })
           .Join(dalcontext.Users,
                 gr_u_gr => gr_u_gr.gr_u.userId,
                 u => u.id,
                 (gr_u_gr, u) => new
                 {
                     gr_u_gr.gr_u.id,
                     u.lastName,
                     gr_u_gr.gr.groupName,
                     gr_u_gr.gr_u.userId,
                     gr_u_gr.gr_u.groupId,
                 })
           .Where(result => result.groupId == groupId)
           .Select(result => new
           {
               result.id,
               result.lastName,
               result.groupName,
               result.userId,
               result.groupId
           });

            return query.ToList<dynamic>();
        }
        public Group_User CheckExistGU(int groupId,int userId)
        {
            return dalcontext.Group_Users.Where(g => g.groupId == groupId && g.userId == userId).FirstOrDefault();
        }
        public Group_User CreateGU(int groupId, int userId)
        {
            Group_User _new_gu = new Group_User();
            _new_gu.groupId = groupId;
            _new_gu.userId = userId;
            _new_gu.createdAt = DateTime.Now;
            _new_gu.updatedAt = DateTime.Now;
            dalcontext.Group_Users.InsertOnSubmit(_new_gu);
            dalcontext.SubmitChanges();
            return _new_gu;
        }

        public Group_User DeleteGU(int groupId, int userId)
        {
            var gu = dalcontext.Group_Users.SingleOrDefault(g => g.groupId == groupId && g.userId == userId);
            if (gu != null)
            {
                dalcontext.Group_Users.DeleteOnSubmit(gu);
                dalcontext.SubmitChanges();
                return gu;
            }
            return null;
        }

        public List<dynamic> LoadGroupScreen(int groupId)
        {
            var query = dalcontext.Screens
                .Join(dalcontext.Group_Screens,
                      screen => screen.id,
                      groupScreen => groupScreen.screenId,
                      (screen, groupScreen) => new { screen, groupScreen })
                .Join(dalcontext.Groups,
                      screenGroupScreen => screenGroupScreen.groupScreen.groupId,
                      group => group.id,
                      (screenGroupScreen, group) => new
                      {
                          screenGroupScreen.screen.id,
                          group.groupName,
                          screenGroupScreen.groupScreen.isRole,
                          screenGroupScreen.screen.screenName,
                          screenGroupScreen.groupScreen.groupId
                      })
                .Where(result => result.groupId == groupId)
                .Select(result => new
                {
                    result.id,
                    result.groupName,
                    result.isRole,
                    result.screenName
                });

            return query.ToList<dynamic>();
        }
    }
}
