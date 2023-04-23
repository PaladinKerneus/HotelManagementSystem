using dene.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dene
{
    
    public partial class FormDash : Form
    {
        public string Username;
        public FormDash()
        {
            InitializeComponent();
        }
        private void panelhareket(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelhareket(buttonDashboard);
            reserve.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            panelhareket(buttonClient);
            userSettings.Hide();
            userodalar.Hide();
            reserve.Hide();


            userMusteri.Show();

        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            panelhareket(buttonRoom);
            userSettings.Hide();
            userMusteri.Hide();
             reserve.Hide();
 
            userodalar.Show();

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            reserve.Hide();

            userodalar.Hide();
            userMusteri.Hide();
            panelhareket(buttonSetting);
            
            userSettings.Show();

        }

        private void FormDash_Load(object sender, EventArgs e)
        {
            UserControl1 userSettings = new UserControl1();
            UserControl2 userMusteri= new UserControl2();
            Rooms userodalar= new Rooms();
            Reservation reserve = new Reservation();

            kisi.Text = Username;
            userodalar.Hide();
            userSettings.Hide();
            userMusteri.Hide();
            reserve.Hide();
         }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {
         }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            userSettings.Hide();
            userMusteri.Hide();
            reserve.Show();
             


        }

        private void reserve_Load(object sender, EventArgs e)
        {

        }
    }
}
