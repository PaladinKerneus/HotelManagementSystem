 using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dene
{
    public partial class UserControl1 : UserControl
    {

        string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
        public void ekle()
        {
            string querry = "INSERT INTO `kullanicitablosu`(`kullanici_adi`, `kullanici_sifre`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataReader reader;
            try
            {


                giris.Open();
                
                reader = komut.ExecuteReader();

                goster();
                giris.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sil()
        {
            string querry = "DELETE FROM `kullanicitablosu` WHERE kullanici_adi='"+textBox4.Text+"'";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataReader reader;
            try
            {


                giris.Open();

                reader = komut.ExecuteReader();

                goster();
                giris.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void arama()
        {
            string querry = "SELECT * FROM `kullanicitablosu` WHERE kullanici_adi LIKE '%" + textBox3.Text + "%' ";
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
            string querry = "SELECT * FROM kullanicitablosu";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataAdapter dt=new MySqlDataAdapter(querry,giris);

            MySqlDataReader reader;



            try
            {


                giris.Open();
                DataTable dtbl=new DataTable();
                dt.Fill(dtbl);
                reader = komut.ExecuteReader();
                dataGridView1.DataSource = dtbl;
                dataGridView2.DataSource = dtbl;
                dataGridView3.DataSource = dtbl;
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
        public UserControl1()
        {
            InitializeComponent();
            goster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
            MessageBox.Show("Kişi Database'e yüklenmiştir.Eğer Listede Gözükmüyor ise yeniden başlatın");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
