using Demo_MVP_QL.View.danhmuc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MVP_QL.Model;

namespace Demo_MVP_QL.Presenter
{
     class AddDanhmuc_Precenter
    {
        IAddDanhmuc addDanhmuc; // khai báo 
       
        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

        public AddDanhmuc_Precenter(IAddDanhmuc addDanhmuc)
        {
            this.addDanhmuc = addDanhmuc;
        }

        public bool adddanhmuc()
        {
            danhmuc dm = new danhmuc();
            dm.danhmucID=addDanhmuc.danhmucID;
            dm.danhmucName=addDanhmuc.danhmucName;
            SqlConnection sqlcn = new SqlConnection(sqlcon);
            sqlcn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO  FoodCategory (name) VALUES ( @namee ) ;", sqlcn);
           
            cmd.Parameters.AddWithValue("@namee", addDanhmuc.danhmucName);


            cmd.ExecuteNonQuery();
            sqlcn.Close();
         
            addDanhmuc.Message = String.Format("Thêm thành công");
            return true;

        }



  









    }
}
