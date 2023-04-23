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

namespace dene.form
{
    public partial class UserControl2 : UserControl
    {

        string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
        public UserControl2()
        {
            InitializeComponent();
        }
        public void arama()
        {
            string querry = "SELECT * FROM `musteri_tablo` WHERE musteri_adi LIKE '%" + aranan_musteri.Text + "%' ";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataAdapter dt = new MySqlDataAdapter(querry, giris);

            MySqlDataReader reader;



            try
            {


                giris.Open();
                DataTable dtbl = new DataTable();
                dt.Fill(dtbl);
                reader = komut.ExecuteReader();
                dataGridView1.DataSource = dtbl;
                dataGridView2.DataSource = dtbl;
                giris.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                giris.Close();
            }
        }
        public void goster()
        {
            string querry = "SELECT * FROM `musteri_tablo` ;";
             
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataAdapter dt = new MySqlDataAdapter(querry, giris);

            MySqlDataReader reader;



            try
            {


                giris.Open();
                DataTable dtbl = new DataTable();
                dt.Fill(dtbl);
                reader = komut.ExecuteReader();
                dataGridView1.DataSource = dtbl;
                dataGridView2.DataSource = dtbl;
                giris.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                giris.Close();
            }
        }

        public void kaydet()
        {
            string querry = "INSERT INTO `musteri_tablo`(`Musteri_adi`, `musteri_adresi`, `musteri_tc_kimlik`) VALUES ('"+textBox2.Text+"','"+textBox4.Text+"','"+textBox3.Text+"' )";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataAdapter dt = new MySqlDataAdapter(querry, giris);

            MySqlDataReader reader;



            try
            {


                giris.Open();
                 
                
                reader = komut.ExecuteReader();
                
                giris.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                giris.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            arama();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kaydet();
            goster();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
