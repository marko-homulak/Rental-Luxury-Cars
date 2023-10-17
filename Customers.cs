using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rental_Luxury_Cars
{
    public partial class Customers : Form
    {
        Form form;
        Customer customer;

        public Customers()
        {
            InitializeComponent();    
        }

        private async void Customers_Load(object sender, EventArgs e)
        {
            customerName_box.Select();
            city_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            customer = new Customer();
            customer.customersList = new BindingList<Customer>();
            await customer.LoadJsonCustomers();
            customersList_dataGrid.DataSource = customer.customersList;

            customersList_dataGrid.ReadOnly = true;
            customersList_dataGrid.RowHeadersVisible = false;
            customersList_dataGrid.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in customersList_dataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            customersList_dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 56, 90);
            customersList_dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            customersList_dataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            customersList_dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            customersList_dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void customersList_dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customersList_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersList_dataGrid.Rows[e.RowIndex];
                if (row.Cells["fullName"].Value != null)
                {
                    phone_box.Enabled = false;
                    add_btn.Enabled = false;
                    customerName_box.Text = row.Cells["fullName"].Value.ToString();
                    city_comboBox.Text = row.Cells["address"].Value.ToString();
                    phone_box.Text = row.Cells["phoneNumber"].Value.ToString();
                }  
                else
                {
                    clear();
                }
            }
        }

        private void updateData()
        {
            customersList_dataGrid.DataSource = customer.customersList;
            customersList_dataGrid.Refresh();
            clear();
        }

        private bool nullValidate()
        {
            if (customerName_box.Text != "" && city_comboBox.Text != "" && phone_box.Text != "")
            {
                string fullName = customerName_box.Text.Trim();
                string phoneNumber = phone_box.Text.Trim();

                if (Regex.IsMatch(fullName, @"^[A-Z][a-z]* [A-Z][a-z]*$") &&
                    Regex.IsMatch(phoneNumber, @"^(050|066|095|099|067|068|096|097|098|063|073|093)\d{7}$"))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Fill in all fields correctly!\nCustomer Name should be in the format 'First Last' (e.g., Henry Ford).\nPhone Number should start with a valid prefix and be 10 digits long.", "Incorrect data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Incorrect data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void clear()
        {
            customerName_box.Text = "";
            city_comboBox.SelectedIndex = -1;
            phone_box.Text = "";

            customersList_dataGrid.ClearSelection();
            phone_box.Enabled = true;
            add_btn.Enabled = true;
        }        

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (nullValidate())
            {
                string fullName = customerName_box.Text;
                string address = city_comboBox.Text;
                string phoneNumber = phone_box.Text;

                if (MessageBox.Show("Want to add customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await customer.addCustomer(fullName, address, phoneNumber);
                    updateData();
                }                   
            }
        }
        
        private async void edit_btn_Click(object sender, EventArgs e)
        {
            if (nullValidate())
            {
                string fullName = customerName_box.Text;
                string address = city_comboBox.Text;
                string phoneNumber = phone_box.Text;

                if (MessageBox.Show("Want to edit customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await customer.editCustomer(phoneNumber, fullName, address);
                    updateData();                
                }                  
            }
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            string phoneNumber = phone_box.Text;

            if (MessageBox.Show("Want to delete customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await customer.deleteCustomer(phoneNumber);
                updateData();
            }                
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cars_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Cars();
            form.Show();
        }

        private void rent_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            form = new Rental();
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

    }
}
