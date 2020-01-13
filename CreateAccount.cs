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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            using(var db = new Session1Entities())
            {
                usertype_combo.DataSource = (from t in db.User_Type select t.userTypeName).ToList();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MM = new MainMenu();
            MM.Closed += (s, args) => this.Close();
            MM.Show();
        }

        private async void create_button_Click(object sender, EventArgs e)
        {
            //first check if everything is filled in
            if(!(string.IsNullOrEmpty(username_box.Text) && string.IsNullOrEmpty(user_id_box.Text) && string.IsNullOrEmpty(password_box.Text) && string.IsNullOrEmpty(password_again_box.Text) && string.IsNullOrEmpty(password_box.Text) && (usertype_combo.SelectedItem == null)))
            {
                //if everything is filled in, proceed with other checks
                //check if both passwords are the same
                if(password_box.Text == password_again_box.Text)
                {
                    //check if user id exists in db
                    using(var db = new Session1Entities())
                    {
                        var query1 = (from u in db.Users
                                      where u.userId == user_id_box.Text
                                      select u).ToList();
                        if(query1.Count == 0)
                        {
                            var user = new User()
                            {
                                userId = user_id_box.Text,
                                userName = username_box.Text,
                                userPw = password_again_box.Text,
                                userTypeIdFK = (from t in db.User_Type where t.userTypeName == usertype_combo.SelectedItem.ToString() select t.userTypeId).First()
                            };
                            db.Users.Add(user);
                            await db.SaveChangesAsync();
                            MessageBox.Show("Added User!");
                        }
                        else
                        {
                            MessageBox.Show("UserID is taken!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!");
                }
            }
        }
    }
}
