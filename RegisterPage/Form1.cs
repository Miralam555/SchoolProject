using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterPage
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextEnter(object sender, EventArgs e)
        {
            if (NameAd.Text == "Ad")
            {
                NameAd.Text = "";
                NameAd.ForeColor = Color.Black;
            }
        }

        private void Name_TextLeave(object sender, EventArgs e)
        {
            if (NameAd.Text == "")
            {
                NameAd.Text = "Ad";
                NameAd.ForeColor = Color.Silver;
            }
        }

        private void Surname_TextEnter(object sender, EventArgs e)
        {
            if (Surname.Text == "Soyad")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void Surname_textLeave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Soyad";
                Surname.ForeColor = Color.Silver;
            }
        }

        private void Fin_TextEnter(object sender, EventArgs e)
        {
            if (Fin.Text == "FİN")
            {
                Fin.Text = "";
                Fin.ForeColor = Color.Black;
            }
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fin_TextLeave(object sender, EventArgs e)
        {
            if (Fin.Text == "")
            {
                Fin.Text = "FİN";
                Fin.ForeColor = Color.Silver;
            }
        }

        private void Email_TextEnter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }

        private void Email_textLeave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Soyad";
                Email.ForeColor = Color.Silver;
            }
        }

        private void Telefon_textEnter(object sender, EventArgs e)
        {
            if (Telefon.Text == "Əlaqə Telefonu")
            {
                Telefon.Text = "";
                Telefon.ForeColor = Color.Black;
            }
        }

        private void Telefon_textLeave(object sender, EventArgs e)
        {
            if (Telefon.Text == "")
            {
                Telefon.Text = "Əlaqə Telefonu";
                Telefon.ForeColor = Color.Silver;
            }
        }

        private void İxtisas_TextEnter(object sender, EventArgs e)
        {
            if (ixtisas.Text == "İxtisası")
            {
                ixtisas.Text = "";
                ixtisas.ForeColor = Color.Black;
            }
        }

        private void İxtisas_TextLeave(object sender, EventArgs e)
        {
            if (ixtisas.Text == "")
            {
                ixtisas.Text = "İxtisası";
                ixtisas.ForeColor = Color.Silver;
            }
        }

        private void sinif_textEnter(object sender, EventArgs e)
        {
            if (sinif.Text == "Dərs keçdiyi sinif")
            {
                sinif.Text = "";
                sinif.ForeColor = Color.Black;
            }
        }

        private void sinif_TextChanged(object sender, EventArgs e)
        {

        }

        private void sinif_textLeave(object sender, EventArgs e)
        {
            if (sinif.Text == "")
            {
                sinif.Text = "Dərs keçdiyi sinif";
                sinif.ForeColor = Color.Silver;
            }
        }

        private void SagirdT_textEnter(object sender, EventArgs e)
        {
            if (SagirdT.Text == "Valideynin əlaqe telefonu")
            {
                SagirdT.Text = "";
                SagirdT.ForeColor = Color.Black;
            }
        }

        private void SagirdT_textLeave(object sender, EventArgs e)
        {
            if (SagirdT.Text == "")
            {
                SagirdT.Text = "Valideynin əlaqe telefonu";
                SagirdT.ForeColor = Color.Silver;
            }
        }

        private void SagirdS_textEnter(object sender, EventArgs e)
        {
            if (SagirdS.Text == "Oxuduğu sinif")
            {
                SagirdS.Text = "";
                SagirdS.ForeColor = Color.Black;
            }
        }

        private void SagirdS_textLeave(object sender, EventArgs e)
        {
            if (SagirdS.Text == "")
            {
                SagirdS.Text = "Oxuduğu sinif";
                SagirdS.ForeColor = Color.Silver;
            }
        }

        private void NameAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void SagirdT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
