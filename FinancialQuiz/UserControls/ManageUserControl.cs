using FinancialQuiz.Controller;
using FinancialQuiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialQuiz.UserControls
{
    public partial class ManageUserControl : UserControl
    {
        private readonly UserController userController;
        private User user;
        private int userId;
        private ToolTip toolTip;
        private List<User> userList;

        public ManageUserControl()
        {
            InitializeComponent();
            this.userController = new UserController();
            this.user = new User();
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            txtSearch.Focus();
            userId = 0;
            toolTip = new ToolTip();
            userList = new List<User>();
        }

        private void ManageUserControl_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            cbxSearch.Focus();
        }

        /// <summary>
        /// Method that returns the currently selected user
        /// </summary>
        public User GetCurrentUser()
        {
            return this.user;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            userId = 0;
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            string searchString = txtSearch.Text;

            string errorMessage = "";
            if (searchString.Trim().Length == 0)
            {
                errorMessage = "Please enter " + searchCriteria;
                txtSearch.Focus();
            }

            else if (searchCriteria == "Username")
            {
                try
                {
                    string username = txtSearch.Text;
                    userList = this.userController.GetUsers("", username, -1);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid username.";
                    txtSearch.Focus();
                }
            }
            else if (searchCriteria == "User ID")
            {
                try
                {
                    int userId = Convert.ToInt32(txtSearch.Text);
                    if (userId < 0)
                    {
                        errorMessage = "Please enter valid user id!";
                        txtSearch.Focus();
                    }

                    userList = this.userController.GetUsers("", "", userId);
                }
                catch (FormatException)
                {
                    errorMessage = "Please enter valid user id!";
                    txtSearch.Focus();
                }
            }
            else
            {
                userList = this.userController.GetUsers(txtSearch.Text, "", 0);
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else if (userList.Count == 0)
            {
                MessageBox.Show("User doesn't exist. Please check your information.", "Error");
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else if (userList.Count == 1)
            {
                this.PopulateUserData(userList[0]);
      
            }
            else if (userList.Count > 1)
            {
                //TODO
            }

        }


        private void clearAllFields()
        {
            txtbxUserId.Text = "";
            txtSearch.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbBoxAdminStatus.SelectedIndex = -1;
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
        }


        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clearAllFields();
            txtSearch.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
        }


        private void PopulateUserData(User user)
        {
            btnRegister.Enabled = false;
            btnUpdate.Enabled = true;

            userId = user.UserID;
            txtbxUserId.Text = Convert.ToString(user.UserID);
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtAge.Text = Convert.ToString(user.Age);
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
            cbBoxAdminStatus.Text = user.AdminInd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
            cbxSearch.SelectedIndex = 0;

        }

        private bool HasValidFields()
        {
           
            if (txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtAge.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                cbBoxAdminStatus.Text == "")
            {
                MessageBox.Show("Please check your information - some fields are empty.");
                return false;
            }

            else if (txtFirstName.Text.Trim().Length > 45)
            {
                txtFirstName.Focus();
                MessageBox.Show("First Name cannot be longer than 45 characters.", "Invalid First Name");
                return false;
            }
            else if (txtLastName.Text.Trim().Length > 45)
            {
                txtLastName.Focus();
                MessageBox.Show("Last Name cannot be longer than 45 characters.", "Invalid Last Name");
                return false;
            }
            
            else if (lblAge.Text.Trim().Length == 0 ||
                lblAge.Text.Trim().Length < 3)
            {
                lblAge.Focus();
                MessageBox.Show("Please enter valid age.", "Invalid Age");
                return false;
            }
            else if (txtUsername.Text.Trim().Length > 45)
            {
                txtUsername.Focus();
                MessageBox.Show("Username cannot be longer than 45 characters", "Invalid Username");
                return false;
            }
            else if (txtPassword.Text.Trim().Length > 45)
            {
                txtPassword.Focus();
                MessageBox.Show("Password cannot be longer than 45 characters", "Invalid Password");
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean isExistingUsername(String username)
        {
            List<User> userList = this.userController.GetUsers("", username, -1);
            if (userList.Count > 0)
            {
                return true;
            }

            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            if (this.HasValidFields())
            {
                try
                {
                    User newUser = new User();
                    newUser.FirstName = txtFirstName.Text;
                    newUser.LastName = txtLastName.Text;
                    newUser.Age = Convert.ToInt32(txtAge.Text);
                    newUser.UserName = txtUsername.Text;
                    newUser.Password = txtPassword.Text;
                    newUser.AdminInd = cbBoxAdminStatus.SelectedItem.ToString();

                    String name = newUser.FirstName + " " + newUser.LastName;
                   
                    if (this.isExistingUsername(newUser.UserName))
                    {
                        MessageBox.Show("User " + newUser.UserName + " already exists!", "Error");
                        return;
                    }

                    bool isRegistered = this.userController.RegisterUser(newUser);

                    if (isRegistered)
                    {
                        MessageBox.Show(name + " has been created successfully. UserID: " + newUser.UserID, "Registration Complete");
                        btnRegister.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnClear.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("User could not be registered at this time");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.HasValidFields())
            {
                try
                {
                    User updatedUser = new User();
                    updatedUser.FirstName = txtFirstName.Text;
                    updatedUser.LastName = txtLastName.Text;
                    updatedUser.Age = Convert.ToInt32(txtAge.Text);
                    updatedUser.UserName = txtUsername.Text;
                    updatedUser.Password = txtPassword.Text;
                    updatedUser.AdminInd = cbBoxAdminStatus.SelectedItem.ToString();
                    String name = updatedUser.FirstName + " " + updatedUser.LastName;

                    bool isUpdated = UserController.UpdateUser(updatedUser);


                    if (isUpdated)
                    {
                        MessageBox.Show(name + " is updated successfully! UserID: " + updatedUser.UserID, "Success");
                    }
                    else
                    {
                        MessageBox.Show("Unable to update the user!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}

