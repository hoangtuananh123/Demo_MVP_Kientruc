using Demo_MVP_QL.Presenter;
using Demo_MVP_QL.Presenter.Danhmuc_Presenter;
using Demo_MVP_QL.View.danhmuc;
using Demo_MVP_QL.View.Monan_View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MVP_QL.View
{
    public partial class fAdmin : Form, IAddDanhmuc, IUpdateDanhmuc, IshowDanhmuc, ISelectDanhmuc,IaddMonan
    {
        string sqlcon = @"Data Source=DESKTOP-4KBKTDB;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        public int MonAnId
        {
            get { return int.Parse(txtidmon.Text); }
            set { txtidmon.Text = value.ToString(); }
        }

        public string MonAnName
        {
            get { return txtnamemon.Text; }
            set { txtnamemon.Text = value; }
        }

        public float MonAnPrice
        {
            get { return float.Parse(txtgia.Text); }
            set { txtgia.Text = value.ToString(); }
        }

        public int IdCategory
        {
            get { return int.Parse(txtiddanhmuc.Text); }
            set { txtiddanhmuc.Text = value.ToString(); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        public int SelectedRowIndex => dataGridViewdanhmuc.CurrentRow?.Index ?? -1;

        public string DanhmucId
        {
            get => txtid_danhmuc.Text;
            set => txtid_danhmuc.Text = value;
        }

        public string DanhmucName
        {
            get => txt_name_danhmuc.Text;
            set => txt_name_danhmuc.Text = value;
        }

        public DataGridView DataGridViewDanhmuc => dataGridViewdanhmuc;
        public DataTable DanhmucData
        {
            get => (DataTable)dataGridViewdanhmuc.DataSource;
            set => dataGridViewdanhmuc.DataSource = value;
        }
        public void HienThi()
        {
            dataGridViewdanhmuc.DataSource = DanhmucData;
        }
        public int danhmucID
        {
            //get => throw new NotImplementedException();
            //set => throw new NotImplementedException();
            get
            {
                // Convert the string to an int
                if (int.TryParse(txtid_danhmuc.Text, out int result))
                {
                    return result;
                }
                else
                {
                    // Handle the case where the conversion fails
                    return 0; // Or throw an exception, depending on your needs
                }
            }
            set
            {
                // Convert the int to a string
                txtid_danhmuc.Text = value.ToString();
            }
        }
        public string danhmucName
        {
            //get => throw new NotImplementedException();
            //set => throw new NotImplementedException();
            get
            {
                // Chuyển đổi trực tiếp từ string sang int
                return txt_name_danhmuc.Text;
            }
            set
            {
                // Chuyển đổi từ int sang string
                txt_name_danhmuc.Text = value;
            }
        }
  

        //public DataGridView DataGridViewDanhmuc => throw new NotImplementedException();

       

        public fAdmin()
        {
            InitializeComponent();
        }

        private void dateTimePickerBill_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tcFood_Click(object sender, EventArgs e)
        {

        }

        private void dtgvFood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcTableFood_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDanhmuc_Precenter pre = new AddDanhmuc_Precenter(this);
            pre.adddanhmuc();
          Showdanhmuc presenter = new Showdanhmuc(this);
            presenter.HienThiDanhmuc();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            Showdanhmuc presenter = new Showdanhmuc(this);
            presenter.HienThiDanhmuc();
        }

        private void dataGridViewdanhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitridanhmuc_presenter presenter = new vitridanhmuc_presenter(this);
            presenter.HienThiChiTietDanhmuc();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateDanhmuc_Precenter dm = new UpdateDanhmuc_Precenter (this);
            dm.suadanhmuc();
            Showdanhmuc presenter = new Showdanhmuc(this);
            presenter.HienThiDanhmuc();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteDanhmuc_Precenter dm = new DeleteDanhmuc_Precenter(this);
            dm.xoadanhmuc();
            Showdanhmuc presenter = new Showdanhmuc(this);
            presenter.HienThiDanhmuc();
        }
    }
}
