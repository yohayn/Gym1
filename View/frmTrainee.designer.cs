namespace Gym
{
    partial class frmTrainee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainee));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnGoToFrmShop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(22, 392);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnGoToFrmShop
            // 
            this.btnGoToFrmShop.Location = new System.Drawing.Point(217, 34);
            this.btnGoToFrmShop.Name = "btnGoToFrmShop";
            this.btnGoToFrmShop.Size = new System.Drawing.Size(152, 60);
            this.btnGoToFrmShop.TabIndex = 1;
            this.btnGoToFrmShop.Text = "מוצרים לרכישה";
            this.btnGoToFrmShop.UseVisualStyleBackColor = true;
            this.btnGoToFrmShop.Click += new System.EventHandler(this.btnGoToFrmShop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "עדכון נתונים אישיים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "ניהול תכנית אימונים";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "צפייה בפעילויות חדר הכושר";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 427);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoToFrmShop);
            this.Controls.Add(this.btnGoBack);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrainee";
            this.Text = "Trainee Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnGoToFrmShop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}