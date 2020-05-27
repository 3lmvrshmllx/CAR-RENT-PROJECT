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
    public partial class DeliveryDate : Form
    {
        
        CarRentEntities db;
        private int selectedId;
        private int userId;

        public DeliveryDate(int SelectedId,int UserId)
        {
            InitializeComponent();
            this.db = new CarRentEntities();
            this.selectedId =  SelectedId;
            this.userId = UserId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Orders o = db.Orders.Find(selectedId);
            o.DeliveryDate = dtpDeliveryDate.Value;
            o.Id = selectedId;

            if (o.DropOffDate.Value < o.DeliveryDate.Value)
            {
                int days = Convert.ToInt32((o.DropOffDate - o.PickUpDate).Value.TotalDays);
                int penDays = Convert.ToInt32((o.DeliveryDate.Value - o.DropOffDate).Value.TotalDays);
                int price = Convert.ToInt32(o.Cars.Price.Value * days);
                int penPrice = Convert.ToInt32((o.Cars.Price.Value * 120 / 100)* penDays);
                int totalPrice = penPrice + price;

                if (dtpDeliveryDate.Value != null) 
                {
                    o.Cars.IsInGarage = true;
                }

                o.CarPrice = price;
                o.PenaltyPrice = penPrice;
                o.TotalPrice = totalPrice;
            }
            db.SaveChanges();
            this.Close();
            ExpiredOrders ex = new ExpiredOrders(userId);
            ex.Show();
            MessageBox.Show("Delivery Accepted!");
            

        }

    }
}
