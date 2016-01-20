using Gym1.View;
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
    public partial class frmSecretary : Form
    {
        public frmSecretary()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnGoToFrmAddTrainee_Click(object sender, EventArgs e)
        {

            TraineesManagement traineesManagement = new TraineesManagement();
            traineesManagement.Show();
            this.Close();
        }
    }
}
