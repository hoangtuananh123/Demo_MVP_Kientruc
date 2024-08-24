using Demo_MVP_QL.Model;
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
    internal class AddMonan_Presenter
    {
        IaddMonan addMonanV; // khai báo 

        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public AddMonan_Presenter(IaddMonan addMonanV)
        {
            this.addMonanV = addMonanV;
        }

        public bool addMonan()
        {
           
            SqlConnection sqlcn = new SqlConnection(sqlcon);
            sqlcn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO  Food (name,idCategory,price) VALUES ( @namee,@idCategoryy,@pricee ) ;", sqlcn);


            cmd.Parameters.AddWithValue("@namee", addMonanV.MonAnName);
            cmd.Parameters.AddWithValue("@idCategoryy", addMonanV.IdCategory);
            cmd.Parameters.AddWithValue("@pricee", addMonanV.MonAnPrice);
  

            cmd.ExecuteNonQuery();
            sqlcn.Close();

            addMonanV.Message = String.Format("Thêm thành công");
            return true;

        }
    }
}
