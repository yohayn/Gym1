﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }


        private void btnGoTofrmSecretary_Click(object sender, EventArgs e)
        {
            frmSecretary frmSecretary = new frmSecretary();
            this.Hide();
            frmSecretary.ShowDialog();
            
        }

        private void btnGoTofrmManager_Click(object sender, EventArgs e)
        {
            
            frmManager frmManager = new frmManager();
            this.Hide();
            frmManager.ShowDialog();
            
        }

        private void btnGoTofrmTrainee_Click(object sender, EventArgs e)
        {
            
            frmTrainee frmTrainee = new frmTrainee();
            this.Hide();
            frmTrainee.ShowDialog();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
      

       
    
    
    }
}
