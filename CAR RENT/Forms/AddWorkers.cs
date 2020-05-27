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
    public partial class AddWorkers : Form
    {
        private int selectedId;
        private int userId;
        private CarRentEntities db;

        public AddWorkers(int UserId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.userId = UserId;
            this.CenterToScreen();

            btnDeleteW.Visible = false;
            btnUpdateW.Visible = false;
            btnAddW.Visible = true;
            FillDgv(db.Workers.ToList());
        }

        private void Workers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard(userId);
            this.Hide();
            d.Show();
        }

        private void btnAddW_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFwname.Text)
          && !string.IsNullOrWhiteSpace(txtLwname.Text)
          && !string.IsNullOrWhiteSpace(dtpwBirthDate.Text)
          && !string.IsNullOrWhiteSpace(txtwCardId.Text)
          && !string.IsNullOrWhiteSpace(txtwPhoneNumber.Text))
            {
                Workers wr = new Workers();


                wr.FirstName = txtFwname.Text;
                wr.LastName = txtLwname.Text;
                wr.BirthDate = dtpwBirthDate.Value;
                wr.CardId = txtwCardId.Text;
                wr.PhoneNumber = txtwPhoneNumber.Text;
                wr.Email = txtEmail.Text;
                wr.AddedDate = DateTime.Now;

                db.Workers.Add(wr);
                db.SaveChanges();
                Reset();

                MessageBox.Show("Client added succesfully!");
                FillDgv(db.Workers.ToList());
            }
        
        }

        private void FillDgv(List<Workers> wr)
        {
            dgvWorkers.Rows.Clear();

            foreach (Workers w in wr)
            {
                dgvWorkers.Rows.Add(w.Id, w.FirstName, w.LastName,w.BirthDate.Value.ToString("MM/dd/yyyy"), w.CardId, w.PhoneNumber,w.Email);
            }
        }


        private void Reset()
        {
            txtFwname.Text = "";
            txtLwname.Text = "";
            dtpwBirthDate.Value = DateTime.Now;
            txtwCardId.Text = "";
            txtwPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void dgvWorkers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectedId = Convert.ToInt32(dgvWorkers.CurrentRow.Cells[0].Value);
            txtFwname.Text = dgvWorkers.CurrentRow.Cells[1].Value.ToString();
            txtLwname.Text = dgvWorkers.CurrentRow.Cells[2].Value.ToString();
            dtpwBirthDate.Value = Convert.ToDateTime(dgvWorkers.CurrentRow.Cells[3].Value);
            txtwCardId.Text = dgvWorkers.CurrentRow.Cells[4].Value.ToString();
            txtwPhoneNumber.Text = dgvWorkers.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvWorkers.CurrentRow.Cells[6].Value.ToString();

            btnAddW.Visible = false;
            btnUpdateW.Visible = true;
            btnDeleteW.Visible = true;
        }

        private void btnDeleteW_Click(object sender, EventArgs e)
        {
            Workers wr = db.Workers.Find(this.selectedId);
            db.Workers.Remove(wr);
            db.SaveChanges();
            Reset();


            btnDeleteW.Visible = false;
            btnUpdateW.Visible = false;
            btnAddW.Visible = true;

            MessageBox.Show("Worker info deleted succesfully!");
            FillDgv(db.Workers.ToList());

        }

        private void btnUpdateW_Click(object sender, EventArgs e)
        {
            Workers wr = db.Workers.Find(this.selectedId);

            wr.FirstName = txtFwname.Text;
            wr.LastName = txtLwname.Text;
            wr.BirthDate = dtpwBirthDate.Value;
            wr.CardId = txtwCardId.Text;
            wr.PhoneNumber = txtwPhoneNumber.Text;
            wr.Email = txtEmail.Text;
            wr.AddedDate = DateTime.Now;


            db.SaveChanges();
            Reset();


            btnDeleteW.Visible = false;
            btnUpdateW.Visible = false;
            btnAddW.Visible = true;


            MessageBox.Show("Worker info updated succesfully!");
            FillDgv(db.Workers.ToList());
        }

        private void txtSearchW_TextChanged(object sender, EventArgs e)
        {
            List<Workers> wr = new List<Workers>();

            if (!string.IsNullOrEmpty(txtSearchW.Text))
            {
                wr = db.Workers.Where(c =>  (c.FirstName.Contains(txtSearchW.Text))||
                                            (c.LastName.Contains(txtSearchW.Text)) ||
                                            (c.BirthDate.Value.ToString("dd.MM.yyyy").Contains(txtSearchW.Text)) ||
                                            (c.CardId.Contains(txtSearchW.Text)) ||
                                            (c.Email.Contains(txtSearchW.Text))   ||
                                            (c.PhoneNumber.Contains(txtSearchW.Text))).ToList();

            }
            else
            {
                wr = db.Workers.ToList();
            }

            FillDgv(wr);
        }

        private void txtSearchW_Enter(object sender, EventArgs e)
        {
            txtSearchW.Text = "";
            txtSearchW.ForeColor = Color.Black;
        }

        private void txtSearchW_Leave(object sender, EventArgs e)
        {
            txtSearchW.Text = "Search";
            txtSearchW.ForeColor = Color.Gray;
            FillDgv(db.Workers.ToList());
        }
    }
}

