using Demo_MVP_QL.Model;
using Demo_MVP_QL.View.danhmuc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVP_QL.Presenter.Danhmuc_Presenter
{
    internal class DeleteDanhmuc_Precenter
    {
        private readonly IUpdateDanhmuc _Updatedanhmuc;
        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public DeleteDanhmuc_Precenter(IUpdateDanhmuc Updatedanhmuc)
        {
            _Updatedanhmuc = Updatedanhmuc;
        }

        public bool xoadanhmuc()
        {
          
            SqlConnection sqlcn = new SqlConnection(sqlcon);
            sqlcn.Open();
            SqlCommand cmd = new SqlCommand("Delete from  FoodCategory WHERE id=@id ;", sqlcn);
            cmd.Parameters.AddWithValue("@id", _Updatedanhmuc.danhmucID);
        


            cmd.ExecuteNonQuery();
            sqlcn.Close();

            _Updatedanhmuc.Message = String.Format("xoá thành công");
            return true;

        }
    }
}
