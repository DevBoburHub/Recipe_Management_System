﻿
using System;

namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSearchRecipes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteMenuItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonDeletePayment = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonDeleteFeedback = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonDeleteInventory = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonDeleteReview = new System.Windows.Forms.Button();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.btnSearchRecipes = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.SearchId = new System.Windows.Forms.TextBox();
            this.Byname = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabSearchRecipes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSearchRecipes
            // 
            this.tabSearchRecipes.Controls.Add(this.tabPage1);
            this.tabSearchRecipes.Controls.Add(this.tabPage2);
            this.tabSearchRecipes.Controls.Add(this.tabPage3);
            this.tabSearchRecipes.Controls.Add(this.tabPage4);
            this.tabSearchRecipes.Controls.Add(this.tabPage5);
            this.tabSearchRecipes.Controls.Add(this.tabPage6);
            this.tabSearchRecipes.Controls.Add(this.tabPage7);
            this.tabSearchRecipes.Controls.Add(this.tabPage8);
            this.tabSearchRecipes.Location = new System.Drawing.Point(12, 85);
            this.tabSearchRecipes.Name = "tabSearchRecipes";
            this.tabSearchRecipes.SelectedIndex = 0;
            this.tabSearchRecipes.Size = new System.Drawing.Size(607, 346);
            this.tabSearchRecipes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(205, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete Customer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteOrder);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(185, 287);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(122, 31);
            this.buttonDeleteOrder.TabIndex = 2;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(483, 275);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteMenuItem);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(599, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Menu Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMenuItem
            // 
            this.buttonDeleteMenuItem.Location = new System.Drawing.Point(203, 295);
            this.buttonDeleteMenuItem.Name = "buttonDeleteMenuItem";
            this.buttonDeleteMenuItem.Size = new System.Drawing.Size(134, 23);
            this.buttonDeleteMenuItem.TabIndex = 2;
            this.buttonDeleteMenuItem.Text = "Delete Menu Item";
            this.buttonDeleteMenuItem.UseVisualStyleBackColor = true;
            this.buttonDeleteMenuItem.Click += new System.EventHandler(this.buttonDeleteMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(481, 275);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonDeletePayment);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(599, 317);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Payment";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // buttonDeletePayment
            // 
            this.buttonDeletePayment.Location = new System.Drawing.Point(34, 288);
            this.buttonDeletePayment.Name = "buttonDeletePayment";
            this.buttonDeletePayment.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePayment.TabIndex = 1;
            this.buttonDeletePayment.Text = "Delete Payment";
            this.buttonDeletePayment.UseVisualStyleBackColor = true;
            this.buttonDeletePayment.Click += new System.EventHandler(this.buttonDeletePayment_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(481, 274);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonDeleteFeedback);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(599, 317);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Feedback";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFeedback
            // 
            this.buttonDeleteFeedback.Location = new System.Drawing.Point(199, 287);
            this.buttonDeleteFeedback.Name = "buttonDeleteFeedback";
            this.buttonDeleteFeedback.Size = new System.Drawing.Size(135, 30);
            this.buttonDeleteFeedback.TabIndex = 2;
            this.buttonDeleteFeedback.Text = "Delete Feedback";
            this.buttonDeleteFeedback.UseVisualStyleBackColor = true;
            this.buttonDeleteFeedback.Click += new System.EventHandler(this.buttonDeleteFeedback_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Add Feedback";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(481, 275);
            this.dataGridView5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonDeleteInventory);
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(599, 317);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Inventory";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteInventory
            // 
            this.buttonDeleteInventory.Location = new System.Drawing.Point(225, 294);
            this.buttonDeleteInventory.Name = "buttonDeleteInventory";
            this.buttonDeleteInventory.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteInventory.TabIndex = 2;
            this.buttonDeleteInventory.Text = "Delete Inventory";
            this.buttonDeleteInventory.UseVisualStyleBackColor = true;
            this.buttonDeleteInventory.Click += new System.EventHandler(this.buttonDeleteInventory_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Add Item";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 6);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(481, 271);
            this.dataGridView6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonDeleteReview);
            this.tabPage7.Controls.Add(this.buttonAddReview);
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(599, 317);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Reviews";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteReview
            // 
            this.buttonDeleteReview.Location = new System.Drawing.Point(493, 270);
            this.buttonDeleteReview.Name = "buttonDeleteReview";
            this.buttonDeleteReview.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteReview.TabIndex = 2;
            this.buttonDeleteReview.Text = "DeleteReview";
            this.buttonDeleteReview.UseVisualStyleBackColor = true;
            this.buttonDeleteReview.Click += new System.EventHandler(this.buttonDeleteReview_Click);
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(388, 270);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReview.TabIndex = 1;
            this.buttonAddReview.Text = "Add Reviews";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(6, 6);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(345, 288);
            this.dataGridView7.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridView8);
            this.tabPage8.Controls.Add(this.btnSearchRecipes);
            this.tabPage8.Controls.Add(this.id);
            this.tabPage8.Controls.Add(this.SearchId);
            this.tabPage8.Controls.Add(this.Byname);
            this.tabPage8.Controls.Add(this.Name);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(599, 317);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Search by Recipes";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(9, 91);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(457, 182);
            this.dataGridView8.TabIndex = 5;
            this.dataGridView8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellContentClick);
            // 
            // btnSearchRecipes
            // 
            this.btnSearchRecipes.Location = new System.Drawing.Point(391, 287);
            this.btnSearchRecipes.Name = "btnSearchRecipes";
            this.btnSearchRecipes.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRecipes.TabIndex = 4;
            this.btnSearchRecipes.Text = "Search";
            this.btnSearchRecipes.UseVisualStyleBackColor = true;
            this.btnSearchRecipes.Click += new System.EventHandler(this.btnSearchRecipes_Click_1);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(6, 63);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(84, 16);
            this.id.TabIndex = 3;
            this.id.Text = "Search by ID";
            // 
            // SearchId
            // 
            this.SearchId.Location = new System.Drawing.Point(123, 63);
            this.SearchId.Name = "SearchId";
            this.SearchId.Size = new System.Drawing.Size(100, 22);
            this.SearchId.TabIndex = 2;
            // 
            // Byname
            // 
            this.Byname.AutoSize = true;
            this.Byname.Location = new System.Drawing.Point(6, 16);
            this.Byname.Name = "Byname";
            this.Byname.Size = new System.Drawing.Size(111, 16);
            this.Byname.TabIndex = 1;
            this.Byname.Text = "Search by Name:";
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Name.Location = new System.Drawing.Point(123, 16);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 22);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = " Recipe Management";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 2;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(670, 494);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabSearchRecipes);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSearchRecipes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSearchRecipes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label Byname;
        private new System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox SearchId;
        private System.Windows.Forms.Button btnSearchRecipes;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView dataGridView8;
        private EventHandler btnSearchRecipes_Click;
        private System.Windows.Forms.Button buttonAddReview;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeleteFeedback;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonDeletePayment;
        private System.Windows.Forms.Button buttonDeleteMenuItem;
        private System.Windows.Forms.Button buttonDeleteInventory;
        private System.Windows.Forms.Button buttonDeleteReview;
    }
}

