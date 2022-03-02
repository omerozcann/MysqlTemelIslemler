using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysqlbaglanti
{
    public partial class kayitfrm : Form
    {
        public kayitfrm()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            durumlbl.Text = "";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server = localhost; Database = kayitdb; Uid = dbuser; Pwd = 12345678;";
            mycon.Open();
            String sql = "insert into kayit(adi,eposta) values('" + aditxt.Text + "','" + epostatxt.Text + "')";
            MySqlCommand mycom = new MySqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = sql;
            mycom.ExecuteNonQuery();
            durumlbl.Text = "Kaydedildi.";
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server = localhost; Database = kayitdb; Uid = dbuser; Pwd = 12345678;";
            mycon.Open();
            String sql = "select * from kayit";
            DataSet ds = new DataSet();
            MySqlDataAdapter mdata = new MySqlDataAdapter(sql, mycon);
            mdata.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            durumlbl.Text = "";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server = localhost; Database = kayitdb; Uid = dbuser; Pwd = 12345678;";
            mycon.Open();
            String sql = "delete from kayit where id="+dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            MySqlCommand mycom = new MySqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = sql;
            mycom.ExecuteNonQuery();
            durumlbl.Text = "Silindi.";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aditxt.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            epostatxt.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            aditxt.Clear();
            epostatxt.Clear();
            dataGridView1.DataSource = null;
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            durumlbl.Text = "";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = "Server = localhost; Database = kayitdb; Uid = dbuser; Pwd = 12345678;";
            mycon.Open();
            String sql = "update kayit set adi='"+aditxt.Text+"',eposta='"+epostatxt.Text+"' where id=" + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            MySqlCommand mycom = new MySqlCommand();
            mycom.Connection = mycon;
            mycom.CommandText = sql;
            mycom.ExecuteNonQuery();
            durumlbl.Text = "Güncellendi.";
        }
    }
}
