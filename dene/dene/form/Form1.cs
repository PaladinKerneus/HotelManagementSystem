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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using dene.Properties ;
using dene;
 
namespace dene
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
             
        }
        string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
        public void login()
        {
            string querry = "SELECT * FROM kullanicitablosu WHERE kullanici_adi='" + kullaniciadi.Text + " 'AND  kullanici_sifre='" + kullanicisifre.Text + "'";
            string mysqlCon = "server=127.0.0.1;user=root;database=otelsistemi;password=";
            MySqlConnection giris = new MySqlConnection(mysqlCon);
            MySqlCommand komut = new MySqlCommand(querry, giris);
            MySqlDataReader reader;
          


            try
            {
                 

                giris.Open();
                reader= komut.ExecuteReader();
                if (reader.HasRows)
                {
                     

                    while (reader.Read())
                    {

                        FormDash frm2 = new FormDash();
                        frm2.Username = kullaniciadi.Text;
                        frm2.Show();
                        this.Hide(); 
                    }
                }
                else
                {
                    MessageBox.Show("bir problem oluþtu!");
                }
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

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sifreyigosterresmi_Click(object sender, EventArgs e)
        {
            if(kullanicisifre.UseSystemPasswordChar==false)
            {
                kullanicisifre.UseSystemPasswordChar = true;
            }
            else if (kullanicisifre.UseSystemPasswordChar == true)
            {
                kullanicisifre.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}