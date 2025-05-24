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

            // textBoxReviewID
            this.textBoxReviewID.Location = new System.Drawing.Point(30, 30);
            this.textBoxReviewID.Size = new System.Drawing.Size(200, 22);
            this.textBoxReviewID.Name = "textBoxReviewID";

            // comboBoxCustomer
            this.comboBoxCustomer.Location = new System.Drawing.Point(30, 70);
            this.comboBoxCustomer.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCustomer.Name = "comboBoxCustomer";

            // comboBoxMenuItem
            this.comboBoxMenuItem.Location = new System.Drawing.Point(30, 110);
            this.comboBoxMenuItem.Size = new System.Drawing.Size(200, 24);
            this.comboBoxMenuItem.Name = "comboBoxMenuItem";

            // numericUpDownRate
            this.numericUpDownRate.Location = new System.Drawing.Point(30, 150);
            this.numericUpDownRate.Minimum = 1;
            this.numericUpDownRate.Maximum = 10;
            this.numericUpDownRate.Value = 1;
            this.numericUpDownRate.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownRate.Name = "numericUpDownRate";

            // textBoxComment
            this.textBoxComment.Location = new System.Drawing.Point(30, 190);
            this.textBoxComment.Size = new System.Drawing.Size(200, 80);
            this.textBoxComment.Name = "textBoxComment";

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(30, 290);
            this.buttonAdd.Size = new System.Drawing.Size(200, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // addreview Form
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
