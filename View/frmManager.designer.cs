﻿namespace Gym
{
    partial class frmManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label class_NameLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label hourLabel;
            System.Windows.Forms.Label guideLabel;
            this.btnGoBack = new System.Windows.Forms.Button();
            this.gymDataSet = new Gym1.GymDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Gym1.GymDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager = new Gym1.GymDataSetTableAdapters.TableAdapterManager();
            this.classesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.classesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDTextBox = new System.Windows.Forms.TextBox();
            this.class_NameTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.guideTextBox = new System.Windows.Forms.TextBox();
            classIDLabel = new System.Windows.Forms.Label();
            class_NameLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            hourLabel = new System.Windows.Forms.Label();
            guideLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).BeginInit();
            this.classesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(39, 477);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.gymDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.ItemsForSaleTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.TraineesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gym1.GymDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classesBindingNavigator
            // 
            this.classesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classesBindingNavigator.BindingSource = this.classesBindingSource;
            this.classesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.classesBindingNavigatorSaveItem});
            this.classesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classesBindingNavigator.Name = "classesBindingNavigator";
            this.classesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classesBindingNavigator.Size = new System.Drawing.Size(1057, 25);
            this.classesBindingNavigator.TabIndex = 2;
            this.classesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // classesBindingNavigatorSaveItem
            // 
            this.classesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classesBindingNavigatorSaveItem.Image")));
            this.classesBindingNavigatorSaveItem.Name = "classesBindingNavigatorSaveItem";
            this.classesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.classesBindingNavigatorSaveItem.Text = "Save Data";
            this.classesBindingNavigatorSaveItem.Click += new System.EventHandler(this.classesBindingNavigatorSaveItem_Click);
            // 
            // classesDataGridView
            // 
            this.classesDataGridView.AutoGenerateColumns = false;
            this.classesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.classesDataGridView.DataSource = this.classesBindingSource;
            this.classesDataGridView.Location = new System.Drawing.Point(202, 311);
            this.classesDataGridView.Name = "classesDataGridView";
            this.classesDataGridView.Size = new System.Drawing.Size(752, 134);
            this.classesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Class Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn3.HeaderText = "Day";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hour";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Guide";
            this.dataGridViewTextBoxColumn5.HeaderText = "Guide";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(274, 81);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 3;
            classIDLabel.Text = "Class ID:";
            // 
            // classIDTextBox
            // 
            this.classIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "ClassID", true));
            this.classIDTextBox.Location = new System.Drawing.Point(346, 78);
            this.classIDTextBox.Name = "classIDTextBox";
            this.classIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.classIDTextBox.TabIndex = 4;
            // 
            // class_NameLabel
            // 
            class_NameLabel.AutoSize = true;
            class_NameLabel.Location = new System.Drawing.Point(274, 107);
            class_NameLabel.Name = "class_NameLabel";
            class_NameLabel.Size = new System.Drawing.Size(66, 13);
            class_NameLabel.TabIndex = 5;
            class_NameLabel.Text = "Class Name:";
            // 
            // class_NameTextBox
            // 
            this.class_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Class Name", true));
            this.class_NameTextBox.Location = new System.Drawing.Point(346, 104);
            this.class_NameTextBox.Name = "class_NameTextBox";
            this.class_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_NameTextBox.TabIndex = 6;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(274, 133);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(29, 13);
            dayLabel.TabIndex = 7;
            dayLabel.Text = "Day:";
            // 
            // dayTextBox
            // 
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Day", true));
            this.dayTextBox.Location = new System.Drawing.Point(346, 130);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 8;
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Location = new System.Drawing.Point(274, 159);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new System.Drawing.Size(33, 13);
            hourLabel.TabIndex = 9;
            hourLabel.Text = "Hour:";
            // 
            // hourTextBox
            // 
            this.hourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Hour", true));
            this.hourTextBox.Location = new System.Drawing.Point(346, 156);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourTextBox.TabIndex = 10;
            // 
            // guideLabel
            // 
            guideLabel.AutoSize = true;
            guideLabel.Location = new System.Drawing.Point(274, 185);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new System.Drawing.Size(38, 13);
            guideLabel.TabIndex = 11;
            guideLabel.Text = "Guide:";
            // 
            // guideTextBox
            // 
            this.guideTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Guide", true));
            this.guideTextBox.Location = new System.Drawing.Point(346, 182);
            this.guideTextBox.Name = "guideTextBox";
            this.guideTextBox.Size = new System.Drawing.Size(100, 20);
            this.guideTextBox.TabIndex = 12;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 532);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(this.classIDTextBox);
            this.Controls.Add(class_NameLabel);
            this.Controls.Add(this.class_NameTextBox);
            this.Controls.Add(dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(hourLabel);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(guideLabel);
            this.Controls.Add(this.guideTextBox);
            this.Controls.Add(this.classesDataGridView);
            this.Controls.Add(this.classesBindingNavigator);
            this.Controls.Add(this.btnGoBack);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManager";
            this.Text = "Manager Interface";
            this.Load += new System.EventHandler(this.frmManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).EndInit();
            this.classesBindingNavigator.ResumeLayout(false);
            this.classesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private Gym1.GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private Gym1.GymDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private Gym1.GymDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton classesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView classesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox classIDTextBox;
        private System.Windows.Forms.TextBox class_NameTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox guideTextBox;
    }
}