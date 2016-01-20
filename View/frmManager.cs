using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDataSet);

        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.gymDataSet.Classes);

        }
    }
}
