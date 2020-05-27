using CAR_RENT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RENT.Forms
{
    public partial class Login : Form
    {
        private CarRentEntities db;
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.db = new CarRentEntities();
            pbx.Visible = false;
            pbx2.Visible = false;
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            pbx.Visible = true;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            pbx.Visible = false;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            pbx2.Visible = true;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            pbx2.Visible = false;
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            pbx.Visible = false;
        }

        private void pbx2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            pbx2.Visible = false;
            
        }
        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && (!string.IsNullOrWhiteSpace(txtPass.Text)))
            {
                if (db.Workers.FirstOrDefault(w => w.Username == txtUsername.Text && w.PassWord == txtPass.Text) != null)
                {

                    int userId = db.Workers.FirstOrDefault(w => w.Username == txtUsername.Text).Id;
                    Dashboard d = new Dashboard(userId);
                    this.Hide();
                    d.Show();
                    
                }
                else 
                {
                    MessageBox.Show("Please enter correct username or password");
                }
            }
            else 
            {
                MessageBox.Show("Please enter your username or password");
            }
            

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
