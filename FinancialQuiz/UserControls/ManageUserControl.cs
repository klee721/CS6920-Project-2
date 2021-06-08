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
        public ManageUserControl()
        {
            InitializeComponent();
            this.userController = new UserController();
            this.user = new User();
            txtSearch.Focus();
            userId = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
