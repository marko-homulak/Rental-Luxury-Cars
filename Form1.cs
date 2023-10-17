using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;
using MySql.Data.MySqlClient;

namespace Rental_Luxury_Cars
{
    public partial class Form1 : Form
    {
        ToolTip toolTip = new ToolTip();
        ToolTip toolTip1 = new ToolTip();

        User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_box.Select();
            user = new User();
            user.usersList = new BindingList<User>();
            user.loadUserDataFromDatabase();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_box_Click(object sender, EventArgs e)
        {
            login_box.BackColor = Color.White;
            login_panel.BackColor = Color.White;
            password_box.BackColor = SystemColors.Control;
            password_panel.BackColor = SystemColors.Control;
        }

        private void password_box_Click(object sender, EventArgs e)
        {
            login_box.BackColor = SystemColors.Control;
            login_panel.BackColor = SystemColors.Control;
            password_box.BackColor = Color.White;
            password_panel.BackColor = Color.White;
        }

        private void password_picture_MouseDown(object sender, MouseEventArgs e)
        {
            password_box.UseSystemPasswordChar = false;
        }

        private void password_picture_MouseUp(object sender, MouseEventArgs e)
        {
            password_box.UseSystemPasswordChar = true;
        }

        private void password_picture_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(password_picture, "See password");
        }

        private void email_link_Click(object sender, EventArgs e)
        {
            string link = email_link.Text;
            Clipboard.SetText(link);
            toolTip1.SetToolTip(email_link, "Email copied");
            timerToSeeHint.Start();
        }

        private void timerToSeeHint_Tick(object sender, EventArgs e)
        {
            toolTip1.Hide(email_link);
            timerToSeeHint.Stop();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            avtorization();
        }

        private void forgotPassword_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact with your administrator!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void avtorization()
        {
            bool isAuthenticated = false; 

            if (login_box.Text != "" && password_box.Text != "")
            {
                if (login_box.Text == User.adminLogin && password_box.Text == User.adminPassword)
                {
                    isAuthenticated = true;

                    dataH.nameUser = User.adminLogin;

                    this.Hide();
                    Administration administration = new Administration();
                    administration.Show();
                }
                else
                {
                    foreach (User user in user.usersList)
                    {
                        if (String.Equals(login_box.Text.ToUpper(), user.Login.ToUpper()) &&
                            String.Equals(password_box.Text, user.Password))
                        {
                            isAuthenticated = true;

                            dataH.nameUser = user.Login;

                            this.Hide();
                            Cars cars = new Cars();
                            cars.Show();
                            break;
                        }
                    }
                }
                
                if (!isAuthenticated)
                {
                    MessageBox.Show("Invalid user or password!", "Authorization error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Authorization error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
