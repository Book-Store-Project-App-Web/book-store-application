using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class BLLGroup
    {
        DALGroup dalGr = new DALGroup();
        public BLLGroup()
        {
        }

        public List<dynamic> LoadGroup()
        {
            return dalGr.LoadGroup();
        }

        public List<dynamic> LoadGroup_User(int groupId)
        {
            return dalGr.LoadGroup_User(groupId);
        }
        public bool CheckExistGU(int groupId, int userId)
        {
            var gu = dalGr.CheckExistGU(groupId, userId);
            if (gu != null)
            {
                MessageBox.Show("User đã được thêm vào Group");
                return true;
            }
            return false;
        }

        public Group_User CreateGU(int groupId, int userId)
        {
            return dalGr.CreateGU(groupId, userId);
        }

        public Group_User DeleteGU(int groupId, int userId)
        {
            return dalGr.DeleteGU(groupId, userId);
        }

        public List<dynamic> LoadGroupScreen(int groupId)
        {
            return dalGr.LoadGroupScreen(groupId);
        }
        public List<Group_Screen_DK> ConvertToGroupScreenList(List<dynamic> dynamicList)
        {
            return dalGr.ConvertToGroupScreenList(dynamicList);
        }
        public void UpdateIsRole(int groupId,int screenId, bool role)
        {
            dalGr.UpdateIsRole(groupId,screenId,role);
        }

        public Group_Screen CheckIsRoleExist(int groupId, int screenId)
        {
            return dalGr.CheckIsRoleExist(groupId, screenId);
        }
        public void CreateRole(int groupId, int screenId,bool isRole)
        {
            dalGr.CreateRole(groupId, screenId, isRole);
        }

        public List<int> GetGroupIdByUserId(int userId)
        {
            return dalGr.GetGroupIdByUserId(userId);
        }
        public DataTable GetScreen(int groupId)
        {
            return dalGr.GetScreen(groupId);
        }
    }
}
