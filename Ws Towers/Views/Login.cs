using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ws_Towers.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Senha pass = new Senha(Email.Text);
            this.Hide();
            pass.Closed += (s, args) => this.Close();
            pass.Show();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            Email.CharacterCasing = CharacterCasing.Lower;
            string pattern = "[^a-zA-Z0-9 -]";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(Email.Text))
            {
                this.ActiveControl = null;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
