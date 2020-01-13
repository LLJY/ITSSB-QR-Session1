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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //check if fields are filled
            if(!(string.IsNullOrEmpty(user_id_box.Text) && string.IsNullOrEmpty(password_box.Text))){
                //verify username and password
                using(var db = new Session1Entities1())
                {
                    var user = (from u in db.Users
                               where u.userId == user_id_box.Text
                               where u.userPw == password_box.Text
                               select new { u,u.User_Type.userTypeId }).ToList();
                    if (user.Count() > 0 && user.First().userTypeId == 2)
                    {
                        //username and password auth successful.
                        //launch next form
                        this.Hide();
                        var RMF = new ResourceManagementForm();
                        RMF.Closed += (s, args) => this.Close();
                        RMF.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username, Password or Unauthorised Access, this incident will be reported.");
                    }
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty!!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MM = new MainMenu();
            MM.Closed += (s, args) => this.Close();
            MM.Show();
        }
    }
}
