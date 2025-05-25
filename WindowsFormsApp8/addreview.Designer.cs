namespace WindowsFormsApp8
{
    partial class addreview
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxReviewID;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.RichTextBox textBoxComment;
        private System.Windows.Forms.Button buttonAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxReviewID = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxMenuItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.textBoxComment = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxReviewID
            // 
            this.textBoxReviewID.Location = new System.Drawing.Point(30, 30);
            this.textBoxReviewID.Name = "textBoxReviewID";
            this.textBoxReviewID.Size = new System.Drawing.Size(200, 22);
            this.textBoxReviewID.TabIndex = 0;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Location = new System.Drawing.Point(30, 70);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCustomer.TabIndex = 1;
            // 
            // comboBoxMenuItem
            // 
            this.comboBoxMenuItem.Location = new System.Drawing.Point(30, 110);
            this.comboBoxMenuItem.Name = "comboBoxMenuItem";
            this.comboBoxMenuItem.Size = new System.Drawing.Size(200, 24);
            this.comboBoxMenuItem.TabIndex = 2;
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Location = new System.Drawing.Point(30, 150);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownRate.TabIndex = 3;
            this.numericUpDownRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(30, 190);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(200, 80);
            this.textBoxComment.TabIndex = 4;
            this.textBoxComment.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Magenta;
            this.buttonAdd.Location = new System.Drawing.Point(30, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // addreview
            // 
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.textBoxReviewID);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.comboBoxMenuItem);
            this.Controls.Add(this.numericUpDownRate);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonAdd);
            this.Name = "addreview";
            this.Text = "Add Review";
            this.Load += new System.EventHandler(this.addreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
