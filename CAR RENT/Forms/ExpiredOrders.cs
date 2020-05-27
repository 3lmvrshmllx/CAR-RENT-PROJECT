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
    public partial class ExpiredOrders : Form
    {
        
        private int userId;
        private CarRentEntities db;
        private int selectedId;

        public ExpiredOrders(int UserId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.userId = UserId;
            this.Size = new Size(1450, 650);
            this.CenterToScreen();
            FillDgv();
        }


        private void ExpiredOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard(userId);
            this.Hide();
            d.Show();
        }

       private void FillDgv() 
       {
            dgvExOrders.Rows.Clear();

   
            foreach(Orders or in db.Orders) 
            {
                dgvExOrders.Rows.Add(or.Id, or.Clients.FirstName, or.Clients.LastName, or.Cars.Makes.Name,
                                            or.Cars.CarModels.Name, or.Cars.Colors.Name, or.Cars.Cities.Name,
                                            or.Cars.EngineCapacity, or.Cars.Year, or.Cars.Price, or.PickUpDate.Value.ToString("MM/dd/yyyy"),
                                            or.DropOffDate.Value.ToString("MM/dd/yyyy"),(or.DeliveryDate != null)?or.DeliveryDate.Value.ToString("MM/dd/yyyy"): "", or.PenaltyPrice,or.TotalPrice);
            }

       }

        private void dgvExOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = Convert.ToInt32(dgvExOrders.CurrentRow.Cells[0].Value);

            DeliveryDate d = new DeliveryDate(selectedId,userId);
            this.Hide();
            d.Show();
        }
    }
}
