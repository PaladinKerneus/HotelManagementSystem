using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dene.form
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }
        public void delete()
        {
            string querry1 = "DELETE FROM `reservasyon` WHERE Reservation_room_number='" + textBox3.Text + "'";
            string querry2 = "UPDATE `odalar` SET `oda_durum`='Bos' WHERE oda_no= '" + textBox3.Text + "' ";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry1, giris);
            MySqlCommand komut2 = new MySqlCommand(querry2, giris);
            MySqlDataReader reader;

            try
            {

                giris.Open();

                reader = komut2.ExecuteReader();
                giris.Close();

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
        public void kaydet()
        {
            string querry1 = "INSERT INTO `reservasyon`(`Reservation_type`, `Reservation_room_number`, `Reservation_client_id`, `Reservation_in`, `Reservation_out`) VALUES ('" + tipi.SelectedItem+ "' ,'"+comboBox2.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            string querry2 = "UPDATE `odalar` SET `oda_durum`='Dolu' WHERE oda_no= '" + comboBox2.Text+"' ";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            string querry3 = "SELECT Musteri_id FROM musteri_tablo WHERE Musteri_id='"+textBox2.Text+"'";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry1, giris);
            MySqlCommand komut2 = new MySqlCommand(querry2, giris);

            MySqlCommand komut3 = new MySqlCommand(querry3, giris);
            MySqlDataAdapter dt = new MySqlDataAdapter(querry3, giris);
           
            

            MySqlDataReader reader;
             

           

            try
            {
                
                giris.Open();

             
 

                reader = komut3.ExecuteReader();
               

                if (reader.HasRows)
                {
                    giris.Close();  
                    
                    giris.Open();
                    reader = komut2.ExecuteReader();
                    giris.Close();


                    giris.Open();
                    reader = komut.ExecuteReader();
                    giris.Close();
                }
                else
                {
                    MessageBox.Show("Hata!");
                }

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

        public void kaydet2()
        {



        }

        public void goster()
        {
            string querry = "SELECT * FROM `reservasyon` ;";
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
                dataGridView2.DataSource= dtbl;
                
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
        private void Reservation_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            kaydet();
            goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void tipi_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string querry = "SELECT oda_no FROM odalar WHERE oda_tipi='" + tipi.Text.ToString() + "' AND oda_durum='Bos'";

            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);

            MySqlDataAdapter da = new MySqlDataAdapter(querry, giris);
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "oda_no";
            comboBox2.ValueMember = "oda_no";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            goster();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
