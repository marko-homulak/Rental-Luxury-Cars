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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rental_Luxury_Cars
{
    public partial class Cars : Form
    {
        bool comboBoxUpdating = false;
        Form form;
        Car car;

        public Cars()
        {
            InitializeComponent();
        }

        private async void Cars_Load(object sender, EventArgs e)
        {
            regNumber_box.Select();
            brand_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            model_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            color_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carStatus_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            model_comboBox.Enabled = false;

            car = new Car();
            car.carsList = new BindingList<Car>();
            await car.LoadJsonCars();
            carsList_DataGrid.DataSource = car.carsList;

            carsList_DataGrid.ReadOnly = true;
            carsList_DataGrid.RowHeadersVisible = false;
            carsList_DataGrid.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in carsList_DataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            carsList_DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 56, 90);
            carsList_DataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            carsList_DataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            carsList_DataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            carsList_DataGrid.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void carsList_DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carsList_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carsList_DataGrid.Rows[e.RowIndex];
                if (row.Cells["registrationNumber"].Value != null)
                {
                    regNumber_box.Enabled = false;
                    regNumber_box.Text = row.Cells["registrationNumber"].Value.ToString();
                    brand_comboBox.Text = row.Cells["brand"].Value.ToString();
                    model_comboBox.Text = row.Cells["model"].Value.ToString();
                    color_comboBox.Text = row.Cells["color"].Value.ToString();
                    price_box.Text = row.Cells["pricePerDay"].Value.ToString();
                    carStatus_comboBox.Text = row.Cells["CarStatus"].Value.ToString();
                    if (row.Cells["CarStatus"].Value.ToString() == "RENTED")
                    {
                        brand_comboBox.Enabled = false;
                        model_comboBox.Enabled = false;
                        price_box.Enabled = false;
                        color_comboBox.Enabled = false;
                        carStatus_comboBox.Enabled = false;

                        add_btn.Enabled = false;
                        edit_btn.Enabled = false;
                        delete_btn.Enabled = false;
                    }
                    else
                    {
                        brand_comboBox.Enabled = true;
                        model_comboBox.Enabled = true;
                        price_box.Enabled = true;
                        color_comboBox.Enabled = true;
                        carStatus_comboBox.Enabled = true;

                        add_btn.Enabled = false;
                        edit_btn.Enabled = true;
                        delete_btn.Enabled = true;
                    }                   
                }  
                else
                {
                    clear();
                }
            }
        }

        public void updateData()
        {
            carsList_DataGrid.DataSource = car.carsList;
            carsList_DataGrid.Refresh();   
            clear();
        }

        private bool nullValidate()
        {
            if (regNumber_box.Text != "" && brand_comboBox.Text != "" && model_comboBox.Text != "" && price_box.Text != "" && color_comboBox.Text != "" && carStatus_comboBox.Text != "")
            {
                string regNumberPattern = @"^[A-Z]{2}\d{4}[A-Z]{2}$";

                if (Regex.IsMatch(regNumber_box.Text, regNumberPattern))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Enter a valid Reg Number (e.g., AA0000AA)", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Incorrect data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void clear()
        {
            regNumber_box.Text = "";
            brand_comboBox.SelectedIndex = -1;
            model_comboBox.SelectedIndex = -1;
            model_comboBox.Enabled = false;
            price_box.Text = "";
            color_comboBox.SelectedIndex = -1;
            carStatus_comboBox.SelectedIndex = -1;

            carsList_DataGrid.ClearSelection();
            regNumber_box.Enabled = true;
            brand_comboBox.Enabled = true;
            model_comboBox.Enabled = true;
            price_box.Enabled = true;
            color_comboBox.Enabled = true;
            carStatus_comboBox.Enabled = true;

            add_btn.Enabled = true;
            edit_btn.Enabled = true;
            delete_btn.Enabled = true;
        }        

        private async void add_btn_Click(object sender, EventArgs e)
        {
            string registrationNumber = regNumber_box.Text;
            string brand = brand_comboBox.Text;
            string model = model_comboBox.Text;
            string color = color_comboBox.Text;
            string pricePerDay = price_box.Text;

            if (nullValidate())
            {
                if (MessageBox.Show("Want to add car?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await car.addCar(registrationNumber, brand, model, color, pricePerDay);
                    updateData();
                }                    
            }           
        }        

        private async void edit_btn_Click(object sender, EventArgs e)
        {
            string registrationNumber = regNumber_box.Text;
            string brand = brand_comboBox.Text;
            string model = model_comboBox.Text;
            string color = color_comboBox.Text;
            string pricePerDay = price_box.Text;
            string carStatus = carStatus_comboBox.Text;

            if (MessageBox.Show("Want to edit car?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await car.editCar(registrationNumber, brand, model, color, pricePerDay, carStatus);
                updateData();
            }                          
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            string registrationNumber = regNumber_box.Text;

            if (MessageBox.Show("Want to delete car?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await car.deleteCar(registrationNumber);
                updateData();
            }             
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void carStatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carStatus_comboBox.SelectedItem != null && carStatus_comboBox.SelectedItem.ToString() == "RENTED")
            {
                if(carStatus_comboBox.Enabled)
                {
                    carStatus_comboBox.SelectedIndex = -1;
                }  
            }
        }

        private void brand_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdating) return;

            comboBoxUpdating = true;

            string selectedBrand = brand_comboBox.SelectedItem?.ToString();
            string selectedModel = model_comboBox.SelectedItem?.ToString();

            model_comboBox.Items.Clear();

            if (selectedBrand == "Rolls Royce")
            {
                model_comboBox.Items.Add("Ghost EWB 2021");
                model_comboBox.Items.Add("Phantom 2019");
            }
            else if (selectedBrand == "Aston Martin")
            {
                model_comboBox.Items.Add("DB11");
                model_comboBox.Items.Add("DBX 707");
            }
            else if (selectedBrand == "Bugatti")
            {
                model_comboBox.Items.Add("Veyron 2020");
            }
            else if (selectedBrand == "Bentley")
            {
                model_comboBox.Items.Add("Continental GT 2019");
                model_comboBox.Items.Add("Continental GT 2020");
            }
            else if (selectedBrand == "Maserati")
            {
                model_comboBox.Items.Add("Ghibli 2014");
                model_comboBox.Items.Add("Ghibli 2017");
                model_comboBox.Items.Add("Quattroporte 2017");
            }
            else if (selectedBrand == "Ferrari")
            {
                model_comboBox.Items.Add("F70");
                model_comboBox.Items.Add("812 Superfast 2018");
            }
            else if (selectedBrand == "Porsche")
            {
                model_comboBox.Items.Add("Cayenne 2019");
                model_comboBox.Items.Add("Cayenne 2020");
                model_comboBox.Items.Add("Panamera 2021");
                model_comboBox.Items.Add("Taycan 4S 2023");
            }

            if (!string.IsNullOrEmpty(selectedModel) && model_comboBox.Items.Contains(selectedModel))
            {
                model_comboBox.SelectedItem = selectedModel;
            }
            else
            {
                model_comboBox.SelectedIndex = -1; 
            }

            model_comboBox.Enabled = true;

            comboBoxUpdating = false;
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
