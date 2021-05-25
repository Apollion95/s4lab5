using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //zaloguj login
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Rejestracja haslo
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           //rejestracja powtowrz haslo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("RODO Musi być zaznaczone");
            }

            if (textBox3.Text != textBox5.Text)
            {
                MessageBox.Show("Hasla nie pasuja do siebie");
            }else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Pole haslo nie moze być puste!");
            }else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Pole haslo nie moze być puste!");
            }else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Pole login nie moze być puste!");
            }
            else
            {
                Uzytkownicy uzytkownicy = new Uzytkownicy(textBox2.Text, textBox1.Text);
                Uzytkownicy.DodajDoListy(uzytkownicy);
                MessageBox.Show("Zarejestrowano pomyslnie");
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //rejestracja login
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //zaloguj haslo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uzytkownicy.ListaOsob.Exists(x=>x.Login==textBox1.Text && x.Haslo == textBox2.Text))            {
                MessageBox.Show("Haslo lub login poprawny");
            }
            else
            {
                MessageBox.Show("zalogowano");
            }
           }
    }
}
