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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        string con = "Data Source = arin.dyndns.org; Initial Catalog =db_apartment; User ID = sa; Password = o6Udojkiydot ";

        private void frmCustomer_Load(object sender, EventArgs e)
        {
        }
        // ปุ่มเรียกดูข้อมูลลูกค้าทั้งหมด
        private void btn1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }       
        // ค้นหาข้อมูลลูกค้า ด้วย รหัส และ ชื่อลูกค้า
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            if (radioButton1.Checked)                
            {               
                string s = "SELECT * FROM tb_Customer WHERE C_ID ='" + textBox1.Text + "' ";
                da = new SqlDataAdapter(s, con);                                          
                da.Fill(dt);
            }
            else 
            {                
                string s = "SELECT * FROM tb_Customer WHERE C_Name LIKE '%" + textBox1.Text + "%' ";
                da = new SqlDataAdapter(s, con);
                da.Fill(dt);
            }   
            
            if(dt.Rows.Count >= 1)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }

            }
        //ปุ่ม เพิ่ม 
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //ปุ่ม เคลียร์
        private void button5_Click(object sender, EventArgs e)
        {
            textbox3.Clear();
            textBox5.Clear();
            textBox9.Clear();
            textBox14.Clear();
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            textbox3.Enabled = true;
            maskedTextBox1.Enabled = true;
            textbox3.Focus();

        }
        // สงข้อมูลไปที่textbox
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.Rows.Count >= 1)
            {
                textbox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                maskedTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textbox3.Enabled = false;
                maskedTextBox1.Enabled = false;
            }
        }
    }
    }


