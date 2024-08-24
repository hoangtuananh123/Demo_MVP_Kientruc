using Demo_MVP_QL.View.Monan_View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVP_QL.Presenter.MonAn
{
    internal class UpdateMonan_Presenter
    {
        Iupdate_monan monanV;// khai báo 

        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public UpdateMonan_Presenter(Iupdate_monan monanV)
        {
            this.monanV = monanV;
        }

        public bool Updatemonan()
        {

            SqlConnection sqlcn = new SqlConnection(sqlcon);
            sqlcn.Open();
            SqlCommand cmd = new SqlCommand("Update Food SET name=@namee,idCategory=@idCategoryy,price=@pricee where id=@id ;", sqlcn);

            cmd.Parameters.AddWithValue("@id", monanV.MonAnId);
            cmd.Parameters.AddWithValue("@namee", monanV.MonAnName);
            cmd.Parameters.AddWithValue("@idCategoryy", monanV.IdCategory);
            cmd.Parameters.AddWithValue("@pricee", monanV.MonAnPrice);


            cmd.ExecuteNonQuery();
            sqlcn.Close();

            monanV.Message = String.Format("sửa thành công");
            return true;

        }
    }
}
