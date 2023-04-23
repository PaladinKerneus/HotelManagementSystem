
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
    public partial class Rooms : UserControl
    {
        string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";

        public Rooms()
        {
            InitializeComponent();

        }
        public string bosmu;
        public void kaydet()
        {
            

            string querry = "INSERT INTO `odalar`(`oda_no`, `oda_tipi`, `oda_durum`) VALUES ('" + textBox1.Text + "','" + comboBox3.Text.ToString() + "','" +comboBox1.Text.ToString()+ "' )";
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
        public void update()
        {


            string querry = "  UPDATE `odalar` SET   `oda_no`='"+textBox3.Text+"',`oda_tipi`='"+comboBox4.Text+"',`oda_durum`='"+ comboBox2.Text+   "' WHERE oda_no='"+textBox3.Text+"'   ";
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
        public void arama()
        {
            string querry = "SELECT * FROM `odalar` WHERE oda_no LIKE '%" + textBox2.Text + "%' ";
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
            string querry = "SELECT * FROM `odalar` ;";

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
                dataGridView3.DataSource= dtbl;
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
        public void delete(){
             
            
                string querry = "DELETE  FROM `odalar` WHERE oda_no ="+textBox3.Text+"";
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

        private void button4_Click(object sender, EventArgs e)
        {
            kaydet();
            goster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            goster();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            goster() ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
