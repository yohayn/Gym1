using Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym1.View
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmTrainee frmTrainee = new frmTrainee();
            frmTrainee.Show();
            this.Close();
        }

        private void itemsForSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsForSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDataSet);

        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.ItemsForSale' table. You can move, or remove it, as needed.
            this.itemsForSaleTableAdapter.Fill(this.gymDataSet.ItemsForSale);

        }
    }
}
