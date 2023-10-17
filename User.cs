using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Luxury_Cars
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static string adminLogin = "admin";
        public static string adminPassword = "admin";

        public BindingList<User> usersList = new BindingList<User>();

        public User()
        {
            usersList = new BindingList<User>();
        }

        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }

        public void loadUserDataFromDatabase()
        {
            usersList.Clear();  
            try
            {
                DataTable dataTable = dataH.myfunDt("SELECT * FROM users");

                foreach (DataRow row in dataTable.Rows)
                {
                    User user = new User
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Login = row["Login"].ToString(),
                        Password = row["Password"].ToString()
                    };

                    usersList.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool isLoginUpperUnique(string login)
        {
            foreach (User user in usersList)
            {
                if (String.Equals(login.ToUpper(), user.Login.ToUpper()))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isLoginUpperUnique(string login, string id)
        {
            foreach (User user in usersList)
            {
                if (user.Id.ToString() == id)
                {
                    continue;
                }

                if (String.Equals(login.ToUpper(), user.Login.ToUpper()))
                {
                    return false;
                }
            }
            return true;
        }

        public bool doesUserExist(string login)
        {
            foreach (User user in usersList)
            {
                if (String.Equals(login.ToUpper(), user.Login.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        public void addUser(string login, string password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(dataH.ConStr))
                {
                    string insertQuery = "INSERT INTO users (Login, Password) VALUES (@login, @password)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@login", login);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    insertCmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void editUser(string login, string password, string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(dataH.ConStr))
                {
                    string updateQuery = "UPDATE users SET Login = @login, Password = @password WHERE Id = @id";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@login", login);
                    updateCmd.Parameters.AddWithValue("@password", password);
                    updateCmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    updateCmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record update successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void deleteUser(string login) 
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(dataH.ConStr))
                {
                    string deleteQuery = "DELETE FROM users WHERE Login = @login";

                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);

                    deleteCmd.Parameters.AddWithValue("@login", login);

                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
