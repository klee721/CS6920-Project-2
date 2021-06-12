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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
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
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtAge.Text = Convert.ToString(user.Age);
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
            cbBoxAdminStatus.Text = user.AdminInd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
        }
    }
}
