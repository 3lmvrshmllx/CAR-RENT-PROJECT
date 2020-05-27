using CAR_RENT.Models;
using ClosedXML.Excel;
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
    public partial class Reports : Form
    {
        List<Orders> or;
        private CarRentEntities db;
        private int userId;

        public Reports(int UserId)
        {
            InitializeComponent();
            this.Size = new Size(1430, 650);
            this.CenterToScreen();
            this.db = new CarRentEntities();
            this.userId = UserId;
            FillDgv(db.Orders.ToList());
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard d = new Dashboard(userId);
            d.Show();
        }

        private void FillDgv(List<Orders> or) 
        {
            dgvReports.Rows.Clear();

            foreach (Orders o in or)
            {
                if (o.Cars.IsInGarage.Value == true)
                {
                    dgvReports.Rows.Add(o.Id,o.Clients.FirstName,o.Clients.LastName,o.Cars.Makes.Name,o.Cars.CarModels.Name,o.Cars.Colors.Name,o.Cars.Cities.Name,o.Cars.EngineCapacity,o.Cars.Year,o.Cars.Price,o.PickUpDate.Value.ToString("MM/dd/yyyy"), o.DropOffDate.Value.ToString("MM/dd/yyyy"), o.DeliveryDate.Value.ToString("MM/dd/yyyy"), o.PenaltyPrice,o.TotalPrice);
                }
            }
        }


        private void txtSearchR_TextChanged(object sender, EventArgs e)
        {
            List<Orders> or = new List<Orders>();
            if (!string.IsNullOrEmpty(txtSearchR.Text))
            {
                or = db.Orders.Where(o =>
                                    (o.Clients.FirstName.Contains(txtSearchR.Text)) ||
                                    (o.Clients.LastName.Contains(txtSearchR.Text)) ||
                                      (o.Cars.Makes.Name.Contains(txtSearchR.Text)) ||
                                    (o.Cars.CarModels.Name.Contains(txtSearchR.Text)) ||
                                       (o.Cars.Colors.Name.Contains(txtSearchR.Text)) ||
                                       (o.Cars.Cities.Name.Contains(txtSearchR.Text)) ||
                                       (o.Cars.Price.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.Cars.Year.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.Cars.EngineCapacity.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.PickUpDate.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.DropOffDate.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.DeliveryDate.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.PenaltyPrice.Value.ToString().Contains(txtSearchR.Text)) ||
                                       (o.TotalPrice.Value.ToString().Contains(txtSearchR.Text))).ToList();
            }

            else 
            {
                or = db.Orders.ToList();
            }
            FillDgv(or);
              
        }

        private void txtSearchR_Leave(object sender, EventArgs e)
        {
            txtSearchR.Text = "Search";
            txtSearchR.ForeColor = Color.Gray;
            FillDgv(db.Orders.ToList());
        }

        private void txtSearchR_Enter(object sender, EventArgs e)
        {
            txtSearchR.Text = "";
            txtSearchR.ForeColor = Color.Black;   
        }

      

        private void DownloadToExcel(List<Orders> or)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Car Rent Reports");

            ws.Row(1).Height = 5;
            ws.Row(2).Height = 30;

            ws.Column("A").Width = 0.5;
            ws.Column("B").Width = 10;
            ws.Column("C").Width = 15;
            ws.Column("D").Width = 25;
            ws.Column("E").Width = 20;

            ws.Range("B2:O2").Merge();

            ws.Range("B2:O2").Value = "Reports";
            ws.Range("B2:O2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("B2:O2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("B2:O2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("B2:O2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Range("B2:O2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Range("B2:O2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Range("B2:O2").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Range("B2:O2").Style.Font.FontColor = XLColor.White;
            ws.Range("B2:O2").Style.Font.Bold = true;

            ws.Cell("B3").Value = "First Name";
            ws.Cell("B3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("B3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("B3").Style.Font.FontColor = XLColor.White;
            ws.Cell("B3").Style.Font.Bold = true;
            ws.Cell("B3").Style.Font.Italic = true;

            ws.Cell("C3").Value = "Last Name";
            ws.Cell("C3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("C3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("C3").Style.Font.FontColor = XLColor.White;
            ws.Cell("C3").Style.Font.Bold = true;
            ws.Cell("C3").Style.Font.Italic = true;

            ws.Cell("D3").Value = "Make";
            ws.Cell("D3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("D3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("D3").Style.Font.FontColor = XLColor.White;
            ws.Cell("D3").Style.Font.Bold = true;
            ws.Cell("D3").Style.Font.Italic = true;

            ws.Cell("E3").Value = "Model";
            ws.Cell("E3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("E3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("E3").Style.Font.FontColor = XLColor.White;
            ws.Cell("E3").Style.Font.Bold = true;
            ws.Cell("E3").Style.Font.Italic = true;

            ws.Cell("F3").Value = "Color";
            ws.Cell("F3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("F3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("F3").Style.Font.FontColor = XLColor.White;
            ws.Cell("F3").Style.Font.Bold = true;
            ws.Cell("F3").Style.Font.Italic = true;

            ws.Cell("G3").Value = "City";
            ws.Cell("G3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("G3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("G3").Style.Font.FontColor = XLColor.White;
            ws.Cell("G3").Style.Font.Bold = true;
            ws.Cell("G3").Style.Font.Italic = true;

            ws.Cell("H3").Value = "Engine";
            ws.Cell("H3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("H3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("H3").Style.Font.FontColor = XLColor.White;
            ws.Cell("H3").Style.Font.Bold = true;
            ws.Cell("H3").Style.Font.Italic = true;

            ws.Cell("I3").Value = "Year";
            ws.Cell("I3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("I3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("I3").Style.Font.FontColor = XLColor.White;
            ws.Cell("I3").Style.Font.Bold = true;
            ws.Cell("I3").Style.Font.Italic = true;

            ws.Cell("J3").Value = "Price";
            ws.Cell("J3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("J3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("J3").Style.Font.FontColor = XLColor.White;
            ws.Cell("J3").Style.Font.Bold = true;
            ws.Cell("J3").Style.Font.Italic = true;

            ws.Cell("K3").Value = "Pick Up Date";
            ws.Cell("K3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("K3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("K3").Style.Font.FontColor = XLColor.White;
            ws.Cell("K3").Style.Font.Bold = true;
            ws.Cell("K3").Style.Font.Italic = true;


            ws.Cell("L3").Value = "Drop Off Date";
            ws.Cell("L3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("L3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("L3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("L3").Style.Font.FontColor = XLColor.White;
            ws.Cell("L3").Style.Font.Bold = true;
            ws.Cell("L3").Style.Font.Italic = true;


            ws.Cell("M3").Value = "Delivery Date";
            ws.Cell("M3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("M3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("M3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("M3").Style.Font.FontColor = XLColor.White;
            ws.Cell("M3").Style.Font.Bold = true;
            ws.Cell("M3").Style.Font.Italic = true;

            ws.Cell("N3").Value = "Penalty Price";
            ws.Cell("N3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("N3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("N3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("N3").Style.Font.FontColor = XLColor.White;
            ws.Cell("N3").Style.Font.Bold = true;
            ws.Cell("N3").Style.Font.Italic = true;

            ws.Cell("O3").Value = "Total Price";
            ws.Cell("O3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("O3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("O3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("O3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("O3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("O3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("O3").Style.Fill.BackgroundColor = XLColor.DarkOrange;
            ws.Cell("O3").Style.Font.FontColor = XLColor.White;
            ws.Cell("O3").Style.Font.Bold = true;
            ws.Cell("O3").Style.Font.Italic = true;

            int i = 4;
            foreach (Orders o in or)
            {
                ws.Cell("B" + i + "").Value = o.Clients.FirstName;
                ws.Cell("B" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("B" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("c" + i + "").Value = o.Clients.LastName;
                ws.Cell("c" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("c" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("c" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("c" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("c" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("c" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("d" + i + "").Value = o.Cars.Makes.Name; 
                ws.Cell("d" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("d" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("d" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("d" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("d" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("d" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("e" + i + "").Value = o.Cars.CarModels.Name;
                ws.Cell("e" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("e" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("e" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("e" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("e" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("e" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("F" + i + "").Value = o.Cars.Colors.Name;
                ws.Cell("F" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("F" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("G" + i + "").Value = o.Cars.Cities.Name;
                ws.Cell("G" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("G" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("H" + i + "").Value = o.Cars.EngineCapacity.Value;
                ws.Cell("H" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("H" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("I" + i + "").Value = o.Cars.Year.Value;
                ws.Cell("I" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("I" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("J" + i + "").Value = o.Cars.Price;
                ws.Cell("J" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("J" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("K" + i + "").Value = o.PickUpDate;
                ws.Cell("K" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("K" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("L" + i + "").Value = o.DropOffDate;
                ws.Cell("L" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("L" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("L" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("L" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("L" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("L" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("M" + i + "").Value = o.DeliveryDate;
                ws.Cell("M" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("M" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("M" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("M" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("M" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("M" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("N" + i + "").Value = o.PenaltyPrice;
                ws.Cell("N" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("N" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("N" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("N" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("N" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("N" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("O" + i + "").Value = o.TotalPrice;
                ws.Cell("O" + i + "").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("O" + i + "").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("O" + i + "").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("O" + i + "").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("O" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("O" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                i++;
            }

            wb.SaveAs(@"C:\Users\Elmar\Desktop\Car Rent Reports.xlsx");
        }


        private void pbx_Click(object sender, EventArgs e)
        {
            if (this.or != null)
            {
                DownloadToExcel(this.or);
              
            }
            else
            {
                DownloadToExcel(db.Orders.ToList());
            }
            MessageBox.Show("Download successful!");
        }

        private void lblToExcel_Click(object sender, EventArgs e)
        {
            if (this.or != null)
            {
                DownloadToExcel(this.or);
               
            }
            else
            {
                DownloadToExcel(db.Orders.ToList());
            }
            MessageBox.Show("Download successful!");
        }
    }
}
