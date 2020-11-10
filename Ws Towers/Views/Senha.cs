using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ws_Towers.Views
{
    public partial class Senha : Form
    {
        private string Email;
        private string senha = "";
        int count = 0;

        public Senha(string email)
        {
            Email = email;
            InitializeComponent();
        }

        private void Senha_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ponto(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ponto(2);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Ponto(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Ponto(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Ponto(5);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Ponto(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Ponto(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ponto(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ponto(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ponto(0);
        }

        private void Ponto(int num)
        {
            senha += senha.Insert(senha.Length, num.ToString());

            if (count == 0)
               Ponto1.BackColor = Color.Yellow;
            if (count == 1)
                Ponto2.BackColor = Color.Yellow;
            if (count == 2)
                Ponto3.BackColor = Color.Yellow;
            if (count == 3)
                Ponto4.BackColor = Color.Yellow;
            if (count == 4)
                Ponto5.BackColor = Color.Yellow;
            if (count == 5)
                Ponto6.BackColor = Color.Yellow;

            if(count >= 5)
            {
                Ponto1.BackColor = Color.Blue;
                Ponto2.BackColor = Color.Blue;
                Ponto3.BackColor = Color.Blue;
                Ponto4.BackColor = Color.Blue;
                Ponto5.BackColor = Color.Blue;
                Ponto6.BackColor = Color.Blue;

                System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

                t.Interval = 3000;
                t.Tick += new EventHandler(timer_Tick);
                t.Start();    
            }

            count++;
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Ponto1.BackColor = Color.White;
            Ponto2.BackColor = Color.White;
            Ponto3.BackColor = Color.White;
            Ponto4.BackColor = Color.White;
            Ponto5.BackColor = Color.White;
            Ponto6.BackColor = Color.White;
        }
    }
}

