using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialQuiz.View
{
    public partial class UserTableView : Form
    {
        public UserTableView()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CS6920_Team4DataSetUsers);

        }

        private void UserTableView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CS6920_Team4DataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._CS6920_Team4DataSetUsers.Users);

        }
    }
}
