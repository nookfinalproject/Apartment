using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApartment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        string con = "Data Source = arin.dyndns.org; Initial Catalog =db_apartment; User ID = sa; Password = o6Udojkiydot";
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb_User Where UserName = '" + textBox1.Text + "'And Password = '" + textBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1 )
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านผิด");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ต้องการปิดโปรแกรมใช่หรือไม่","ผลการทำงาน",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
