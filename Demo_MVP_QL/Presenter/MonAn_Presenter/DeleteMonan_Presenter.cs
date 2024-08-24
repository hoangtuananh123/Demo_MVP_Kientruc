using Demo_MVP_QL.View.danhmuc;
using Demo_MVP_QL.View.Monan_View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVP_QL.Presenter.MonAn
{
    internal class DeleteMonan_Presenter
    {
        private readonly IDelete_Monan monanV;
        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public DeleteMonan_Presenter(IDelete_Monan monanV)
        {
            this.monanV = monanV;
        }

        public bool xoamonan()
        {

            SqlConnection sqlcn = new SqlConnection(sqlcon);
            sqlcn.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Food where id=@id ;", sqlcn);

            cmd.Parameters.AddWithValue("@id", monanV.MonAnId);
   


            cmd.ExecuteNonQuery();
            sqlcn.Close();

            monanV.Message = String.Format("xoá thành công");
            return true;

        }
    }
}
