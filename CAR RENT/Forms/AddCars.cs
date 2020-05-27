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
    public partial class AddCars : Form
    {
        private CarRentEntities db;
        private int selectedId;
        private int userId;

        public AddCars(int UserId)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.db = new CarRentEntities();
            FillMakes();
            FillColors();
            FillCities();
            FillDgv(db.Cars.ToList());

            this.userId = UserId;
          

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAddCar.Visible = true;

        }

        private void Cars_FormClosed(object sender, FormClosedEventArgs e)
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

            foreach (CarModels c in cm )
            {
                cmbModel.Items.Add(c.Name);
            }
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.Makes.FirstOrDefault(m=>m.Name==cmbMake.Text)!=null)
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

      private void  FillCities() 
      {
            cmbCity.Items.Clear();
            cmbCity.Items.Add("Choose");
            cmbCity.SelectedItem = "Choose";

            foreach (Cities c in db.Cities)
            {
                cmbCity.Items.Add(c.Name);
            }

      }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbMake.Text)
            && !string.IsNullOrWhiteSpace(cmbModel.Text)
            && !string.IsNullOrWhiteSpace(cmbColor.Text)
            && !string.IsNullOrWhiteSpace(cmbCity.Text)
            && !string.IsNullOrWhiteSpace(txtEngine.Text)
            && !string.IsNullOrWhiteSpace(numPrice.Value.ToString()))
            {
                Cars c = new Cars();
                if (db.Makes.FirstOrDefault(m=>m.Name==cmbMake.Text)!=null) 
                {
                    c.MakeId = db.Makes.FirstOrDefault(m => m.Name == cmbMake.Text).Id;
                }

                if (db.CarModels.FirstOrDefault(cm => cm.Name == cmbModel.Text) != null)
                {
                    c.CarModelId = db.CarModels.FirstOrDefault(cm => cm.Name == cmbModel.Text).Id;
                }

                if (db.Colors.FirstOrDefault(cl=> cl.Name == cmbColor.Text) != null)
                {
                    c.ColorId = db.Colors.FirstOrDefault(cl => cl.Name == cmbColor.Text).Id;
                }

                if (db.Cities.FirstOrDefault(ct => ct.Name == cmbCity.Text) != null)
                {
                    c.CityId = db.Cities.FirstOrDefault(ct => ct.Name == cmbCity.Text).Id;
                }

                c.EngineCapacity = Convert.ToDecimal(txtEngine.Text);
                c.Year = Convert.ToInt32(numYear.Value);
                c.Price = Convert.ToInt32(numPrice.Value);
                c.AddedDate = DateTime.Now;

                db.Cars.Add(c);
                db.SaveChanges();
                Reset();

                MessageBox.Show("Car added succesfully!");
                FillDgv(db.Cars.ToList());
            }
          
        }


        private void FillDgv(List<Cars> cars)
        {
            dgvCars.Rows.Clear();

            foreach (Cars c in cars)
            {
                dgvCars.Rows.Add(c.Id,c.Makes.Name,c.CarModels.Name,c.Colors.Name,c.Cities.Name,c.EngineCapacity,c.Year,c.Price);
            }
        }

        private void dgvCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedId = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            cmbMake.Text = dgvCars.CurrentRow.Cells[1].Value.ToString();
            cmbModel.Text = dgvCars.CurrentRow.Cells[2].Value.ToString();
            cmbColor.Text = dgvCars.CurrentRow.Cells[3].Value.ToString();
            cmbCity.Text = dgvCars.CurrentRow.Cells[4].Value.ToString();
            txtEngine.Text = dgvCars.CurrentRow.Cells[5].Value.ToString();
            numYear.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells[6].Value);
            numPrice.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells[7].Value);

            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAddCar.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cars c = db.Cars.Find(this.selectedId);

            if (db.Makes.FirstOrDefault(m => m.Name == cmbMake.Text) != null)
            {
                c.MakeId = db.Makes.FirstOrDefault(m => m.Name == cmbMake.Text).Id;
            }

            if (db.CarModels.FirstOrDefault(cm => cm.Name == cmbModel.Text) != null)
            {
                c.CarModelId = db.CarModels.FirstOrDefault(cm => cm.Name == cmbModel.Text).Id;
            }

            if (db.Colors.FirstOrDefault(cl => cl.Name == cmbColor.Text) != null)
            {
                c.ColorId = db.Colors.FirstOrDefault(cl => cl.Name == cmbColor.Text).Id;
            }

            if (db.Cities.FirstOrDefault(ct => ct.Name == cmbCity.Text) != null)
            {
                c.CityId = db.Cities.FirstOrDefault(ct => ct.Name == cmbCity.Text).Id;
            }

            c.EngineCapacity = Convert.ToDecimal(txtEngine.Text);
            c.Year = Convert.ToInt32(numYear.Value);
            c.Price = Convert.ToInt32(numPrice.Value);
            c.AddedDate = DateTime.Now;

           
            db.SaveChanges();
            Reset();


            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAddCar.Visible = true;


            MessageBox.Show("Car updated succesfully!");
            FillDgv(db.Cars.ToList());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cars c = db.Cars.Find(this.selectedId);
            db.Cars.Remove(c);
            db.SaveChanges();
            Reset();

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAddCar.Visible = true;

            MessageBox.Show("Car deleted succesfully");
            FillDgv(db.Cars.ToList());

        }

       private void Reset()
        {
            cmbMake.SelectedItem = "Choose";
            cmbModel.SelectedItem = "Choose";
            cmbCity.SelectedItem = "Choose";
            cmbColor.SelectedItem = "Choose";
            txtEngine.Text = "";
            numYear.Value = 1980;
            numPrice.Value = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Cars> cars = new List<Cars>();

            if (!string.IsNullOrEmpty(txtSearch.Text)) 
            {
                cars = db.Cars.Where(c =>

                                       (c.CarModels.Name.Contains(txtSearch.Text)) ||
                                       (c.Makes.Name.Contains(txtSearch.Text)) ||
                                       (c.Colors.Name.Contains(txtSearch.Text)) ||
                                       (c.Cities.Name.Contains(txtSearch.Text)) ||
                                       (c.Price.Value.ToString().Contains(txtSearch.Text)) ||
                                       (c.Year.Value.ToString().Contains(txtSearch.Text)) ||
                                       (c.EngineCapacity.Value.ToString().Contains(txtSearch.Text))).ToList();

            }
            else 
            {
                cars = db.Cars.ToList();
            }
            FillDgv(cars);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search";
            txtSearch.ForeColor = Color.Gray;
            FillDgv(db.Cars.ToList());
        }
    }
}
