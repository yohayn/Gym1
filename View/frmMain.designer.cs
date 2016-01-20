namespace Gym
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGoTofrmSecretary = new System.Windows.Forms.Button();
            this.btnGoTofrmManager = new System.Windows.Forms.Button();
            this.btnGoTofrmTrainee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoTofrmSecretary
            // 
            this.btnGoTofrmSecretary.Image = global::Gym1.Properties.Resources.secretary;
            this.btnGoTofrmSecretary.Location = new System.Drawing.Point(42, 173);
            this.btnGoTofrmSecretary.Name = "btnGoTofrmSecretary";
            this.btnGoTofrmSecretary.Size = new System.Drawing.Size(258, 198);
            this.btnGoTofrmSecretary.TabIndex = 1;
            this.btnGoTofrmSecretary.UseVisualStyleBackColor = true;
            this.btnGoTofrmSecretary.Click += new System.EventHandler(this.btnGoTofrmSecretary_Click);
            // 
            // btnGoTofrmManager
            // 
            this.btnGoTofrmManager.Image = global::Gym1.Properties.Resources.Manager;
            this.btnGoTofrmManager.Location = new System.Drawing.Point(591, 163);
            this.btnGoTofrmManager.Name = "btnGoTofrmManager";
            this.btnGoTofrmManager.Size = new System.Drawing.Size(188, 247);
            this.btnGoTofrmManager.TabIndex = 2;
            this.btnGoTofrmManager.UseVisualStyleBackColor = true;
            this.btnGoTofrmManager.Click += new System.EventHandler(this.btnGoTofrmManager_Click);
            // 
            // btnGoTofrmTrainee
            // 
            this.btnGoTofrmTrainee.Image = global::Gym1.Properties.Resources.Trainee;
            this.btnGoTofrmTrainee.Location = new System.Drawing.Point(342, 129);
            this.btnGoTofrmTrainee.Name = "btnGoTofrmTrainee";
            this.btnGoTofrmTrainee.Size = new System.Drawing.Size(204, 314);
            this.btnGoTofrmTrainee.TabIndex = 3;
            this.btnGoTofrmTrainee.Text = "Trainee";
            this.btnGoTofrmTrainee.UseVisualStyleBackColor = true;
            this.btnGoTofrmTrainee.Click += new System.EventHandler(this.btnGoTofrmTrainee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome WorkIT Gym application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please choose wanted interface";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secretary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trainee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manager";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(42, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoTofrmTrainee);
            this.Controls.Add(this.btnGoTofrmManager);
            this.Controls.Add(this.btnGoTofrmSecretary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Work IT - Gym Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoTofrmSecretary;
        private System.Windows.Forms.Button btnGoTofrmManager;
        private System.Windows.Forms.Button btnGoTofrmTrainee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnExit;

    }
}

