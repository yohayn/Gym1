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

namespace Gym
{
    public partial class frmAddTrainee : Form
    {
        public frmAddTrainee()
        {
            InitializeComponent();
        }

      
        private void traineesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traineesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDataSet);

        }

        private void frmAddTrainee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Trainees' table. You can move, or remove it, as needed.
            this.traineesTableAdapter.Fill(this.gymDataSet.Trainees);

        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            frmSecretary frmSecretary = new frmSecretary();
            frmSecretary.Show();
            this.Close();
        }
    }
}
