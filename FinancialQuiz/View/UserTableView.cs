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

namespace FinancialQuiz.View
{
    public partial class UserTableView : Form
    {
        private int selectedRowIndex = -1;

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
            this.usersTableAdapter.Fill(this._CS6920_Team4DataSetUsers.Users);
            usersDataGridView.ClearSelection();
        }

        /// <summary>
        /// Updates data in the view.
        /// </summary>
        /// <param name="userList"></param>
        public void RefreshUsersDataView(List<User> userList)
        {
            this.usersDataGridView.DataSource = userList;
        }

        /// <summary>
        /// Returns the current selected index.
        /// </summary>
        /// <returns>selectedRowIndex</returns>
        public int GetSelectedRowIndex()
        {
            return selectedRowIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = usersDataGridView.CurrentRow.Index;
        }

    }
}
