using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DcentralizationClass
    {
        public DcentralizationClass()
        {

        }

        //public List<string> GetMaNhomNguoiDung(string pTenDN)
        //{
        //    List<string> dsNhomND = new List<string>();

        //    QL_NguoiDungNhomNguoiDungTableAdapter tblAdapter = new QL_NguoiDungNhomNguoiDungTableAdapter();

        //    BUOI_6.QLDN.QL_NguoiDungNhomNguoiDungDataTable data = tblAdapter.GetData(pTenDN);

        //    for (int i = 0; i < data.Rows.Count; i++)
        //    {
        //        string maNhomND = data.Rows[i][0].ToString();
        //        dsNhomND.Add(maNhomND);
        //    }
        //    return dsNhomND;
        //}

        //public DataTable GetMaManHinh(string pMaNhomND)
        //{
        //    QL_PhanQuyen_GetMaMHTableAdapter mhAdapter = new QL_PhanQuyen_GetMaMHTableAdapter();
        //    DataTable data = mhAdapter.GetData(pMaNhomND);
        //    return data;
        //}
    }
}
