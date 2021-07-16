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
    public partial class GamesSummaryForm : Form
    {
        public GamesSummaryForm()
        {
            InitializeComponent();
        }

        private void GamesSummaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameSummaryDataSet.UserGames' table. You can move, or remove it, as needed.
            this.userGamesTableAdapter.Fill(this.gameSummaryDataSet.UserGames);

            this.reportViewer1.RefreshReport();
        }
    }
}
