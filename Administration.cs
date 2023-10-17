using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rental_Luxury_Cars
{
    public partial class Administration : Form
    {
        int index;
        Form form;
        User user;

        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            user_label.Text = dataH.nameUser;
            userName_box.Select();

            user = new User();
            user.usersList = new BindingList<User>();
            user.loadUserDataFromDatabase();
            usersList_DataGrid.DataSource = user.usersList;

            usersList_DataGrid.ReadOnly = true;
            usersList_DataGrid.RowHeadersVisible = false;
            usersList_DataGrid.EnableHeadersVisualStyles = false;

            usersList_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            usersList_DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 56, 90);
            usersList_DataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            usersList_DataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            usersList_DataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            usersList_DataGrid.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void usersList_DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usersList_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usersList_DataGrid.Rows[e.RowIndex];

                index = row.Index;

                userName_box.Text = row.Cells["Login"].Value.ToString();
                password_box.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void updateData()
        {
            user.loadUserDataFromDatabase();
            usersList_DataGrid.DataSource = user.usersList;
        }

        private bool nullValidate()
        {
            if (userName_box.Text != "" && password_box.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Incorrect data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void clear()
        {
            userName_box.Text = "";
            password_box.Text = "";

            usersList_DataGrid.ClearSelection();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (nullValidate())
            {
                string tb1 = userName_box.Text;
                string tb2 = password_box.Text;

                if (!user.isLoginUpperUnique(tb1))
                {
                    MessageBox.Show("A User with the same UserName already exists!", "Duplicate Record!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.addUser(tb1, tb2);
                updateData();
                clear();
            }
        }        

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (nullValidate())
            {
                string tb1 = userName_box.Text;
                string tb2 = password_box.Text;
                string tb0 = usersList_DataGrid.Rows[index].Cells[0].Value.ToString();

                if (!user.isLoginUpperUnique(tb1, tb0))
                {
                    MessageBox.Show("A User with the same UserName already exists!", "Duplicate Record!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.editUser(tb1, tb2, tb0);
                updateData();
                clear();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (nullValidate())
            {
                string tb1 = userName_box.Text;

                if (user.doesUserExist(tb1))
                {
                    if (MessageBox.Show("Are you sure you want to delete the entry?", "Removal",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.deleteUser(tb1);
                        updateData();
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Record does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
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
