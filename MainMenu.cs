using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CA = new CreateAccount();
            CA.Closed += (s, args) => this.Close();
            CA.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new LoginPage();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }
    }
}
