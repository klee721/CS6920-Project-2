using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinancialQuiz.Controller;
using FinancialQuiz.Model;

namespace FinancialQuiz.View
{
    public partial class MainMenu : Form
    {
        private readonly UserController userController;

        public MainMenu()
        {
            this.userController = new UserController();
            InitializeComponent();
            this.SetupComboBox();
           
        }


        /// <summary>
        /// Helper method that sets up the combo box to only display the two roles and prevent user custom inputs
        /// </summary>
        private void SetupComboBox()
        {
            Dictionary<string,string> comboSource = new Dictionary<string, string>();
            comboSource.Add("N", "Player");
            comboSource.Add("Y", "Administrator");
            this.UserTypeComboBox.DataSource = new BindingSource(comboSource,null);
            this.UserTypeComboBox.DisplayMember = "Value";
            this.UserTypeComboBox.ValueMember = "Key";
            this.UserTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Helper method for when the user clicks the X button to close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Exit button routine; closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Login routine when the Login button is clicked. Checks the DB for the entered username and password and warns the user if no one is found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<User> userList = new List<User>();

            userList = this.userController.UserLogin(this.UserNameTextBox.Text, this.PasswordTextBox.Text);

            if (userList.Count == 1)
            {
                User testUser = new User();
                testUser = userList[0];

                Console.WriteLine("You've logged in: " + testUser.FirstName + " " + testUser.LastName + " " + testUser.UserName + " " + testUser.Age);

            }else if (userList.Count > 1){
            MessageBox.Show("Duplicate users found. Please contact your system adminstrator ", "Login Failed");
            }else{
            MessageBox.Show("Username or Password is incorrect", "Login Failed");
            }
        }
    }
}
