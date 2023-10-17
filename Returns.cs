using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rental_Luxury_Cars
{
    public partial class Returns : Form
    {  
        Form form;
        Return ret;
        Rent rent;
        Car car;

        int index;
        string returnDate;
        int delayValue;
        string finalPrice;
        string carReg;

        public Returns()
        {
            InitializeComponent();
        }

        private async void Returns_Load(object sender, EventArgs e)
        {
            car = new Car();
            car.carsList = new BindingList<Car>();
            await car.LoadJsonCars();

            rent = new Rent();
            rent.rentalsList = new BindingList<Rent>();
            await rent.LoadJsonRentals();
            rentalsList_dataGrid.DataSource = rent.rentalsList;
            
            rentalsList_dataGrid.ReadOnly = true;
            rentalsList_dataGrid.RowHeadersVisible = false;
            rentalsList_dataGrid.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in rentalsList_dataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            rentalsList_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 56, 90);
            rentalsList_dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            rentalsList_dataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            rentalsList_dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            rentalsList_dataGrid.RowsDefaultCellStyle.BackColor = Color.White;

            endOfRentalTime();

            ret = new Return();
            ret.returnsList = new BindingList<Return>();
            await ret.LoadJsonRentRecords();
            returnsList_dataGrid.DataSource = ret.returnsList;

            returnsList_dataGrid.ReadOnly = true;
            returnsList_dataGrid.RowHeadersVisible = false;
            returnsList_dataGrid.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in returnsList_dataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            returnsList_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 56, 90);
            returnsList_dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            returnsList_dataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            returnsList_dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            returnsList_dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void rentalsList_dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rentalsList_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = rentalsList_dataGrid.Rows[e.RowIndex];
                index = row.Index;
                if (row.Cells["carRegistrationNumber"].Value != null)
                {
                    carReg_box.Text = row.Cells["carRegistrationNumber"].Value.ToString();
                    customerPhone_box.Text = row.Cells["tenantPhoneNumber"].Value.ToString();
                    returnDate_box.Text = DateTime.Now.ToString("dd.MM.yyyy");
                    returnDate = row.Cells["returnDate"].Value.ToString();
                    finalPrice = row.Cells["finalPrice"].Value.ToString();
                }
                else
                {
                    clear();
                }
            }
        }

        private void updateData()
        {
            rentalsList_dataGrid.DataSource = rent.rentalsList;
            rentalsList_dataGrid.Refresh();
            returnsList_dataGrid.DataSource = ret.returnsList;
            returnsList_dataGrid.Refresh();
            clear();
            endOfRentalTime();
        }

        private void clear()
        {
            carReg_box.Text = "";
            customerPhone_box.Text = "";
            returnDate_box.Text = "";
            delay_box.Text = "";
            fine_box.Text = "";

            rentalsList_dataGrid.ClearSelection();
        }

        //private void calculateDelay()
        //{
        //    DateTime todayDate = DateTime.Now;
        //    DateTime dateValue = DateTime.Parse(returnDate);
        //    string formattedDate = dateValue.ToString("dd.MM.yyyy");
        //    DateTime returnsDate = DateTime.Parse(formattedDate);

        //    TimeSpan difference = todayDate - returnsDate;
        //    delayValue = difference.Days;

        //    if (delayValue > 0)
        //    {
        //        delay_box.Text = $"{delayValue}";
        //    }
        //    else
        //    {
        //        delay_box.Text = "0";
        //    }
        //}

        //private void calculateFine()
        //{
        //    carReg = carReg_box.Text;

        //    double fineValue = 0.0f;
        //    double feesValue = double.Parse(fees);
        //    double priceValue = car.getCarRentalPrice(carReg);

        //    fineValue = feesValue + (delayValue * priceValue);

        //    fine_box.Text = fineValue.ToString();
        //}       

        private async void returnRentalCar()
        {
            string carRegistrationNumber = carReg_box.Text;
            string statusA = "AVAILABLE";
            string statusM = "MAINTENANCE";

            if (rent.isRented(carRegistrationNumber))
            {
                if (MessageBox.Show("Confirm return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Choose whether the car will be status\nfor rental upon return", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await ret.addRentRecord(carRegistrationNumber, statusA);
                        updateData();
                    }
                    else
                    {
                        await ret.addRentRecord(carRegistrationNumber, statusM);
                        updateData();
                    }
                }
                else
                {
                    clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error, the car is not rented yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                return;
            }
        }       

        private async void revokeRentalCar()
        {
            string carRegistrationNumber = carReg_box.Text;
            if (!rent.isRented(carRegistrationNumber))
            {
                if (MessageBox.Show("Are you sure you want to revoke the car?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await rent.deleteRental(carRegistrationNumber);
                    await car.editCar(carRegistrationNumber, "AVAILABLE");
                    MessageBox.Show("The car rental has been revoked!");
                    updateData();
                }
            }
            else
            {
                MessageBox.Show("Error, the car is already rented!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (carReg_box.Text != "")
            {
                returnRentalCar();
            }
            else
            {
                MessageBox.Show("Record does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void revoke_btn_Click(object sender, EventArgs e)
        {
            if (carReg_box.Text != "")
            {
                revokeRentalCar();
            }
            else
            {
                MessageBox.Show("Record does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cars_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Cars();
            form.Show();
        }

        private void customers_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Customers();
            form.Show();
        }

        private void rent_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Rental();
            form.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                form = new Form1();
                form.Show();
            }
        }

        private void endOfRentalTime()
        {
            DateTime todayDate = DateTime.Now;

            foreach (DataGridViewRow row in rentalsList_dataGrid.Rows)
            {
                if (row.Cells["returnDate"].Value != null)
                {
                    DateTime returnDate = Convert.ToDateTime(row.Cells["returnDate"].Value);

                    if (returnDate <= todayDate)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red; 
                        row.DefaultCellStyle.ForeColor = Color.White;
                        MessageBox.Show($"Car with CarReg [{row.Cells["carRegistrationNumber"].Value}] must be returned!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = rentalsList_dataGrid.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = rentalsList_dataGrid.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }        

    }
}
