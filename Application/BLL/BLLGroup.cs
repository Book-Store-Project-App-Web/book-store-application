using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class BLLGroup
    {
        DALGroup dalGr = new DALGroup();
        public BLLGroup()
        {
        }

        public List<Group> LoadGroup()
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
    }
}
