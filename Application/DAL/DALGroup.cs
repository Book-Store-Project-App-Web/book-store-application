using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

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
        public Group_User CheckExistGU(int groupId, int userId)
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

        public List<Group_Screen_DK> ConvertToGroupScreenList(List<dynamic> dynamicList)
        {
            var groupScreenList = new List<Group_Screen_DK>();

            foreach (var item in dynamicList)
            {
                groupScreenList.Add(new Group_Screen_DK
                {
                    id = item.id,
                    groupName = item.groupName,
                    screenName = item.screenName,
                    isRole = item.isRole,
                    groupId = item.groupId,
                    screenId = item.screenId
                });
            }

            return groupScreenList;
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
                          screenGroupScreen.screen,
                          screenGroupScreen.groupScreen,
                          group
                      })
                .Where(result => result.groupScreen.groupId == groupId)
                .Select(result => new
                {
                    result.groupScreen.id,
                    result.group.groupName,
                    result.groupScreen.isRole,
                    result.screen.screenName,
                    result.groupScreen.groupId,
                    result.groupScreen.screenId
                });

            return query.ToList<dynamic>();
        }
      
        public void UpdateIsRole(int groupId, int screenId, bool role)
        {
            var groupScreen = dalcontext.Group_Screens.SingleOrDefault(gs => gs.groupId == groupId && gs.screenId == screenId);
            if (groupScreen != null)
            {
                groupScreen.isRole = role;
                dalcontext.SubmitChanges();
            }
        }
        public Group_Screen CheckIsRoleExist(int groupid, int screenid)
        {
            return dalcontext.Group_Screens.SingleOrDefault(gs => gs.groupId == groupid && gs.screenId == screenid);
        }
        public void CreateRole(int groupId, int screenId, bool isRole)
        {
            Group_Screen _new_gs = new Group_Screen();
            _new_gs.groupId = groupId;
            _new_gs.screenId = screenId;
            _new_gs.isRole = isRole;
            _new_gs.createdAt = DateTime.Now;
            _new_gs.updatedAt = DateTime.Now;
            dalcontext.Group_Screens.InsertOnSubmit(_new_gs);
            dalcontext.SubmitChanges();
        }

        public List<int> GetGroupIdByUserId(int userId)
        {
            List<int> listGroupId = new List<int>();
            DataTable dataTable = new DataTable();

            string query = "SELECT groupId from Group_Users Where userId = '" + userId + "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, DAL.Properties.Settings.Default.Book_StoreConnectionString1);
            adapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int groupId = (int)dataTable.Rows[i][0];
                listGroupId.Add(groupId);
            }

            return listGroupId;
        }
        public DataTable GetScreen(int groupId)
        {
            DataTable dataTable = new DataTable();
            string query = "Select Screens.screenName,screenId,isRole,groupId from Group_Screens,Screens Where Group_Screens.screenId = Screens.id and groupId = '" + groupId + "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, DAL.Properties.Settings.Default.Book_StoreConnectionString1);
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
