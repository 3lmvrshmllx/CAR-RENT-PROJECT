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
    public partial class AddClients : Form
    {
        private int selectedId;
        private int userId;
        private CarRentEntities db;

        public AddClients(int UserId)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.db = new CarRentEntities();
            this.userId = UserId;


            btnDeleteCl.Visible = false;
            btnUpdateCl.Visible = false;
            btnAddCl.Visible = true;
            FillDgv(db.Clients.ToList());

        }

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard(userId);
            this.Hide();
            d.Show();

        }

        private void btnAddCl_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtFname.Text)
           && !string.IsNullOrWhiteSpace(txtLname.Text)
           && !string.IsNullOrWhiteSpace(dtpBirthDate.Text)
           && !string.IsNullOrWhiteSpace(txtCardId.Text)
           && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                Clients cl = new Clients();


                cl.FirstName = txtFname.Text;
                cl.LastName = txtLname.Text;
                cl.BirthDate = dtpBirthDate.Value;
                cl.CardId = txtCardId.Text;
                cl.PhoneNumber = txtPhoneNumber.Text;
                cl.AddedDate = DateTime.Now;
                 
                db.Clients.Add(cl);
                db.SaveChanges();
                Reset();

                MessageBox.Show("Client added succesfully!");
                FillDgv(db.Clients.ToList());
            }
          
        }


        private void FillDgv(List<Clients>cl) 
        {
            dgvClients.Rows.Clear();

            foreach (Clients c in cl) 
            {
                dgvClients.Rows.Add(c.Id,c.FirstName,c.LastName,c.BirthDate.Value.ToString("MM/dd/yyyy"),c.CardId,c.PhoneNumber);
            }
        }

        private void Reset()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtCardId.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void dgvClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectedId = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);
            txtFname.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
            dtpBirthDate.Value = Convert.ToDateTime(dgvClients.CurrentRow.Cells[3].Value);
            txtCardId.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();

            btnAddCl.Visible = false;
            btnUpdateCl.Visible = true;
            btnDeleteCl.Visible = true;

        }

        private void btnUpdateCl_Click(object sender, EventArgs e)
        {
            Clients c = db.Clients.Find(this.selectedId);

            c.FirstName = txtFname.Text;
            c.LastName = txtLname.Text;
            c.BirthDate = dtpBirthDate.Value;
            c.CardId = txtCardId.Text;
            c.PhoneNumber = txtPhoneNumber.Text;
            c.AddedDate = DateTime.Now;

           
            db.SaveChanges();
            Reset();


            btnDeleteCl.Visible = false;
            btnUpdateCl.Visible = false;
            btnAddCl.Visible = true;


            MessageBox.Show("Client info updated succesfully!");
            FillDgv(db.Clients.ToList());
        }

        private void btnDeleteCl_Click(object sender, EventArgs e)
        {
            Clients c = db.Clients.Find(this.selectedId);
            db.Clients.Remove(c);
            db.SaveChanges();
            Reset();


            btnDeleteCl.Visible = false;
            btnUpdateCl.Visible = false;
            btnAddCl.Visible = true;


            MessageBox.Show("Client info deleted succesfully!");
            FillDgv(db.Clients.ToList());

        }

        private void txtSearchCl_TextChanged(object sender, EventArgs e)
        {
            List<Clients> cl = new List<Clients>();

            if (!string.IsNullOrEmpty(txtSearchCl.Text))
            {
                cl = db.Clients.Where(c =>  (c.FirstName.Contains(txtSearchCl.Text))||
                                            (c.LastName.Contains(txtSearchCl.Text)) ||
                                            (c.BirthDate.Value.ToString("MM.dd.yyyy").Contains(txtSearchCl.Text)) ||
                                            (c.CardId.Contains(txtSearchCl.Text)) ||
                                            (c.PhoneNumber.Contains(txtSearchCl.Text))).ToList();

            }
            else 
            {
                cl = db.Clients.ToList();
            }

            FillDgv(cl);
        }

   
        private void txtSearchCl_Enter_1(object sender, EventArgs e)
        {
            txtSearchCl.Text = "";
            txtSearchCl.ForeColor = Color.Black;
        }

        private void txtSearchCl_Leave_1(object sender, EventArgs e)
        {
            txtSearchCl.Text = "Search";
            txtSearchCl.ForeColor = Color.Gray;
            FillDgv(db.Clients.ToList());
        }
    }


}

    

