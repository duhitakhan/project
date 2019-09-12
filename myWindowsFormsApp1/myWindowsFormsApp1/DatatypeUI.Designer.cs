namespace myWindowsFormsApp1
{
    partial class DatatypeUI
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
            this.itemComboBox1 = new System.Windows.Forms.ComboBox();
            this.showButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemComboBox1
            // 
            this.itemComboBox1.FormattingEnabled = true;
            this.itemComboBox1.Items.AddRange(new object[] {
            "pen",
            "book",
            "notebook",
            "none"});
            this.itemComboBox1.Location = new System.Drawing.Point(48, 33);
            this.itemComboBox1.Name = "itemComboBox1";
            this.itemComboBox1.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox1.TabIndex = 0;
            // 
            // showButton1
            // 
            this.showButton1.Location = new System.Drawing.Point(214, 83);
            this.showButton1.Name = "showButton1";
            this.showButton1.Size = new System.Drawing.Size(75, 23);
            this.showButton1.TabIndex = 1;
            this.showButton1.Text = "show";
            this.showButton1.UseVisualStyleBackColor = true;
            this.showButton1.Click += new System.EventHandler(this.showButton1_Click);
            // 
            // DatatypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 155);
            this.Controls.Add(this.showButton1);
            this.Controls.Add(this.itemComboBox1);
            this.Name = "DatatypeUI";
            this.Text = "DatatypeUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemComboBox1;
        private System.Windows.Forms.Button showButton1;
    }
}