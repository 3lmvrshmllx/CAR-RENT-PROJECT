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
    public partial class NewOrder : Form
    {
        private int selectedCarId;
        private int selectedClientId;
        private int userId;
        private CarRentEntities db;

        public NewOrder(int UserId)
        {
            InitializeComponent();
            this.Size = new Size(1030, 800);
            this.CenterToScreen();
            this.db = new CarRentEntities();
            this.userId = UserId;

            FillMakes();
            FillColors();
            FillCities();
            FillDgv(db.Cars.ToList());
            FillDgv(db.Clients.ToList());
        }

        private void NewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard(userId);
            this.Hide();
            d.Show();
        }

        private void FillMakes()
        {
            cmbMake.Items.Clear();
            cmbMake.Items.Add("Choose");
            cmbMake.SelectedItem = "Choose";

            foreach (Makes m in db.Makes)
            {
                cmbMake.Items.Add(m.Name);
            }
        }

        private void FillModels(int makeId)
        {
            cmbModel.Items.Clear();
            cmbModel.Items.Add("Choose");
            cmbModel.SelectedItem = "Choose";

            List<CarModels> cm = db.CarModels.Where(m => m.MakeId == makeId).ToList();

            foreach (CarModels c in cm)
            {
                cmbModel.Items.Add(c.Name);
            }
        }

        private void cmbMake_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (db.Makes.FirstOrDefault(m => m.Name == cmbMake.Text) != null)
            {
                int makeId = db.Makes.FirstOrDefault(m => m.Name == cmbMake.Text).Id;
                FillModels(makeId);
            }
        }


        private void FillColors()
        {
            cmbColor.Items.Clear();
            cmbColor.Items.Add("Choose");
            cmbColor.SelectedItem = "Choose";

            foreach (Colors c in db.Colors)
            {
                cmbColor.Items.Add(c.Name);
            }
        }

        private void FillCities()
        {
            cmbCity.Items.Clear();
            cmbCity.Items.Add("Choose");
            cmbCity.SelectedItem = "Choose";

            foreach (Cities c in db.Cities)
            {
                cmbCity.Items.Add(c.Name);
            }

        }

        private void FillDgv(List<Cars> cars)
        {
            dgvCars.Rows.Clear();

            foreach (Cars c in cars)
            {
                dgvCars.Rows.Add(c.Id, c.Makes.Name, c.CarModels.Name, c.Colors.Name, c.Cities.Name, c.EngineCapacity, c.Year, c.Price, c.IsInGarage);
            }
        }

        private void dgvCars_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (Convert.ToBoolean(dgvCars.CurrentRow.Cells[8].Value) != false)
            {
                    this.selectedCarId = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
                    cmbMake.Text = dgvCars.CurrentRow.Cells[1].Value.ToString();
                    cmbModel.Text = dgvCars.CurrentRow.Cells[2].Value.ToString();
                    cmbColor.Text = dgvCars.CurrentRow.Cells[3].Value.ToString();
                    cmbCity.Text = dgvCars.CurrentRow.Cells[4].Value.ToString();
                    txtEngine.Text = dgvCars.CurrentRow.Cells[5].Value.ToString();
                    numYear.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells[6].Value);
                    numPrice.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells[7].Value);
            }
            else 
            {
                MessageBox.Show("This car is not in garage!");
            }
        }



        private void FillDgv(List<Clients> cl)
        {
            dgvClients.Rows.Clear();

            foreach (Clients c in cl)
            {
                dgvClients.Rows.Add(c.Id, c.FirstName, c.LastName, c.BirthDate, c.CardId, c.PhoneNumber);
            }
        }

        private void dgvClients_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectedClientId = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);
            txtFname.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
        }


        private void Reset()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            cmbMake.SelectedItem = "Choose";
            cmbModel.SelectedItem = "Choose";
            cmbColor.SelectedItem = "Choose";
            cmbCity.SelectedItem = "Choose";
            numPrice.Value = 0;
            numYear.Value = 1980;
            txtEngine.Text = "";
        }


        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClients acl = new AddClients(userId);
            this.Hide();
            acl.Show();

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCars ac = new AddCars(userId);
            this.Hide();
            ac.Show();
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            
           if(!string.IsNullOrWhiteSpace(txtFname.Text)
           && !string.IsNullOrWhiteSpace(txtLname.Text)   
           && !string.IsNullOrWhiteSpace(cmbMake.Text)
           && !string.IsNullOrWhiteSpace(cmbModel.Text)
           && !string.IsNullOrWhiteSpace(cmbColor.Text)
           && !string.IsNullOrWhiteSpace(cmbCity.Text)
           && !string.IsNullOrWhiteSpace(txtEngine.Text)
           && !string.IsNullOrWhiteSpace(numPrice.Value.ToString()))
            {
                Orders o = new Orders();
           
                this.selectedCarId = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
                this.selectedClientId = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);

                o.CarId = this.selectedCarId;
                o.ClientId = this.selectedClientId;
                o.PickUpDate = dtpPickUp.Value;
                o.DropOffDate = dtpDropOff.Value;
                o.CarPrice = Convert.ToInt32(numPrice.Value);

                db.Orders.Add(o);
                db.SaveChanges();
                Reset();
                MessageBox.Show("Car rented successfully!");
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
        }

        private void txtSearchC_TextChanged(object sender, EventArgs e)
        {
            List<Cars> cars = new List<Cars>();

            if (!string.IsNullOrEmpty(txtSearchC.Text))
            {
                cars = db.Cars.Where(c =>

                                       (c.CarModels.Name.Contains(txtSearchC.Text)) ||
                                       (c.Makes.Name.Contains(txtSearchC.Text)) ||
                                       (c.Colors.Name.Contains(txtSearchC.Text)) ||
                                       (c.Cities.Name.Contains(txtSearchC.Text)) ||
                                       (c.Price.Value.ToString().Contains(txtSearchC.Text)) ||
                                       (c.Year.Value.ToString().Contains(txtSearchC.Text)) ||
                                       (c.EngineCapacity.Value.ToString().Contains(txtSearchC.Text))).ToList();

            }
            else
            {
                cars = db.Cars.ToList();
            }
            FillDgv(cars);
        }

        private void txtSearchCl_TextChanged(object sender, EventArgs e)
        {
            List<Clients> cl = new List<Clients>();

            if (!string.IsNullOrEmpty(txtSearchCl.Text))
            {
                cl = db.Clients.Where(c => (c.FirstName.Contains(txtSearchCl.Text)) ||
                                            (c.LastName.Contains(txtSearchCl.Text)) ||
                                            (c.BirthDate.Value.ToString("dd.MM.yyyy").Contains(txtSearchCl.Text)) ||
                                            (c.CardId.Contains(txtSearchCl.Text)) ||
                                            (c.PhoneNumber.Contains(txtSearchCl.Text))).ToList();

            }
            else
            {
                cl = db.Clients.ToList();
            }

            FillDgv(cl);
        }

        private void txtSearchC_Enter(object sender, EventArgs e)
        {
            txtSearchC.Text = "";
            txtSearchC.ForeColor = Color.Black;
        }

        private void txtSearchC_Leave(object sender, EventArgs e)
        {
            txtSearchC.Text = "Search";
            txtSearchC.ForeColor = Color.Gray;
            FillDgv(db.Cars.ToList());
        }

        private void txtSearchCl_Enter(object sender, EventArgs e)
        {
            txtSearchCl.Text = "";
            txtSearchCl.ForeColor = Color.Black;
        }

        private void txtSearchCl_Leave(object sender, EventArgs e)
        {
            txtSearchCl.Text = "Search";
            txtSearchCl.ForeColor = Color.Gray;
            FillDgv(db.Clients.ToList());
        }
    }
}
