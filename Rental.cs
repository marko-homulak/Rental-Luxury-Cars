using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rental_Luxury_Cars
{
    public partial class Rental : Form
    {
        Form form;
        Rent rent;
        Car car;
        Customer customer;

        public Rental()
        {
            InitializeComponent();
        }

        private async void Rent_Load(object sender, EventArgs e)
        {
            regNumber_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            custPhone_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rent_dateTimePicker.MinDate = DateTime.Today;
            return_dateTimePicker.MinDate = DateTime.Today;

            car = new Car();
            car.carsList = new BindingList<Car>();
            await car.LoadJsonCars();
            car.uploadAvailableCars(regNumber_comboBox);

            customer = new Customer();
            customer.customersList = new BindingList<Customer>();
            await customer.LoadJsonCustomers();
            customer.uploadCustomersPhones(custPhone_comboBox);

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
        }
         
        private void rentalsList_dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rentalsList_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void updateData()
        {
            rentalsList_dataGrid.DataSource = rent.rentalsList;
            rentalsList_dataGrid.Refresh();
            clear();
            if (regNumber_comboBox.Items.Contains(regNumber_comboBox.Text))
            {
                regNumber_comboBox.Items.Remove(regNumber_comboBox.Text);
            }
            endOfRentalTime();
        }

        private bool nullValidate()
        {
            if ((regNumber_comboBox.Text != "" || regNumber_comboBox.Text != "Error") && custPhone_comboBox.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clear()
        {
            regNumber_comboBox.SelectedIndex = -1;
            custPhone_comboBox.SelectedIndex = -1;
            rent_dateTimePicker.Value = DateTime.Today;
            return_dateTimePicker.Value = DateTime.Today;
            custName_box.Text = "";

            rentalsList_dataGrid.ClearSelection();
        }

        private bool IsReturnDateValid()
        {
            DateTime selectedRentDate = rent_dateTimePicker.Value.Date;
            DateTime selectedReturnDate = return_dateTimePicker.Value.Date;

            if (selectedReturnDate <= selectedRentDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            DateTime rentDateValue = rent_dateTimePicker.Value.Date;
            DateTime returnDateValue = return_dateTimePicker.Value.Date;

            string carRegistrationNumber = regNumber_comboBox.Text;
            string tenantPhoneNumber = custPhone_comboBox.Text;
            string rentDate = rentDateValue.ToString("yyyy-MM-dd'T'HH:mm:ss");
            string returnDate = returnDateValue.ToString("yyyy-MM-dd'T'HH:mm:ss");

            if (!nullValidate())
            {
                MessageBox.Show("Fill in all fields!", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!rent.isPhoneUpperUnique(tenantPhoneNumber))
                {
                    MessageBox.Show("A Сustomer with the same CustPhone already exists!", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsReturnDateValid())
                {
                    MessageBox.Show("Return Date entered incorrectly!\nThe return date cannot be earlier than tomorrow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Want to rent car?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await rent.addRental(carRegistrationNumber, tenantPhoneNumber, rentDate, returnDate);
                    updateData();
                }
                else
                {
                    return;
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void custPhone_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerPhone = custPhone_comboBox.Text;
            customer.getCustomerFullName(customerPhone, custName_box);
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

        private void return_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Returns();
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
            Color selectionBackColor = Color.Red;
            Color selectionForeColor = Color.White;

            foreach (DataGridViewRow row in rentalsList_dataGrid.Rows)
            {
                if (row.Cells["returnDate"].Value != null)
                {
                    DateTime returnDate = Convert.ToDateTime(row.Cells["returnDate"].Value);

                    if (returnDate <= todayDate)
                    {
                        row.DefaultCellStyle.BackColor = selectionBackColor;
                        row.DefaultCellStyle.ForeColor = selectionForeColor;
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
