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
    public partial class Dashboard : Form
    {

        private CarRentEntities db;
        private int UserId;

        public Dashboard(int userId)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.db = new CarRentEntities();
            this.UserId = userId;
            lblWelcome.Text += db.Workers.Find(userId).FirstName;
            FillDgv();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void CarIcon_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void ItemCars_Click(object sender, EventArgs e)
        {
            AddCars c = new AddCars(UserId);
            this.Hide();
            c.Show();
        }

        private void ItemClients_Click(object sender, EventArgs e)
        {
            AddClients c = new AddClients(UserId);
            this.Hide();
            c.Show();
        }

        private void ItemWorkers_Click(object sender, EventArgs e)
        {
            AddWorkers w = new AddWorkers(UserId);
            this.Hide();
            w.Show();
        }

        private void btnExOrder_Click(object sender, EventArgs e)
        {
            ExpiredOrders ex = new ExpiredOrders(UserId);
            this.Hide();
            ex.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder no = new NewOrder(UserId);
            this.Hide();
            no.Show();
        }

        private void FillDgv()
        {
            dgvLastTenOrders.Rows.Clear();
        
                foreach (Orders or in db.Orders.Take(10)) 
                {
                    dgvLastTenOrders.Rows.Add(or.Id,or.Clients.FirstName,or.Clients.LastName,or.Cars.Makes.Name,
                                              or.Cars.CarModels.Name,or.Cars.Colors.Name, or.Cars.Cities.Name,
                                               or.Cars.EngineCapacity,or.Cars.Year,or.Cars.Price,or.PickUpDate.Value.ToString("MM/dd/yyyy"),or.DropOffDate.Value.ToString("MM/dd/yyyy"));
                }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(UserId);
            this.Hide();
            r.Show();
        }
    }
}
