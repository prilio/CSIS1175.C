namespace PriscilaC_Assign2
{
    partial class Form1
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
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.LoadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.QtySoldLabel = new System.Windows.Forms.Label();
            this.QtySoldTextBox = new System.Windows.Forms.TextBox();
            this.UpdateQtySoldButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.QtyRestockedLabel = new System.Windows.Forms.Label();
            this.QtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.UpdateRestockedButton = new System.Windows.Forms.Button();
            this.SortItemButton = new System.Windows.Forms.Button();
            this.UpdateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.SaveSalesButton = new System.Windows.Forms.Button();
            this.SaveRestockButton = new System.Windows.Forms.Button();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputStatusLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.LoadDataGroupBox.SuspendLayout();
            this.UpdateDataGroupBox.SuspendLayout();
            this.SaveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.AutoSize = true;
            this.LoadDataButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadDataButton.Location = new System.Drawing.Point(50, 70);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(151, 57);
            this.LoadDataButton.TabIndex = 0;
            this.LoadDataButton.Text = "Load Grocery Data";
            this.LoadDataButton.UseVisualStyleBackColor = false;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // LoadDataGroupBox
            // 
            this.LoadDataGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadDataGroupBox.Controls.Add(this.LoadDataButton);
            this.LoadDataGroupBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataGroupBox.Location = new System.Drawing.Point(50, 370);
            this.LoadDataGroupBox.Name = "LoadDataGroupBox";
            this.LoadDataGroupBox.Size = new System.Drawing.Size(260, 198);
            this.LoadDataGroupBox.TabIndex = 1;
            this.LoadDataGroupBox.TabStop = false;
            this.LoadDataGroupBox.Text = "Load Data";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(485, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(606, 31);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "SUPER STORE GROCERY MANAGEMENT SYSTEM";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QtySoldLabel
            // 
            this.QtySoldLabel.AutoSize = true;
            this.QtySoldLabel.Location = new System.Drawing.Point(23, 34);
            this.QtySoldLabel.Name = "QtySoldLabel";
            this.QtySoldLabel.Size = new System.Drawing.Size(105, 14);
            this.QtySoldLabel.TabIndex = 3;
            this.QtySoldLabel.Text = "Quantity Sold:";
            this.QtySoldLabel.Click += new System.EventHandler(this.QtySoldLabel_Click);
            // 
            // QtySoldTextBox
            // 
            this.QtySoldTextBox.Location = new System.Drawing.Point(159, 34);
            this.QtySoldTextBox.Name = "QtySoldTextBox";
            this.QtySoldTextBox.Size = new System.Drawing.Size(143, 20);
            this.QtySoldTextBox.TabIndex = 4;
            // 
            // UpdateQtySoldButton
            // 
            this.UpdateQtySoldButton.AutoSize = true;
            this.UpdateQtySoldButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpdateQtySoldButton.Location = new System.Drawing.Point(26, 60);
            this.UpdateQtySoldButton.Name = "UpdateQtySoldButton";
            this.UpdateQtySoldButton.Size = new System.Drawing.Size(276, 44);
            this.UpdateQtySoldButton.TabIndex = 5;
            this.UpdateQtySoldButton.Text = "Update Sold Qty for Selected Item";
            this.UpdateQtySoldButton.UseVisualStyleBackColor = false;
            this.UpdateQtySoldButton.Click += new System.EventHandler(this.UpdateQtySoldButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.AutoSize = true;
            this.DeleteItemButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteItemButton.Location = new System.Drawing.Point(26, 110);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(276, 46);
            this.DeleteItemButton.TabIndex = 6;
            this.DeleteItemButton.Text = "Delete Selected Grocery Item";
            this.DeleteItemButton.UseVisualStyleBackColor = false;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // QtyRestockedLabel
            // 
            this.QtyRestockedLabel.AutoSize = true;
            this.QtyRestockedLabel.Location = new System.Drawing.Point(423, 40);
            this.QtyRestockedLabel.Name = "QtyRestockedLabel";
            this.QtyRestockedLabel.Size = new System.Drawing.Size(147, 14);
            this.QtyRestockedLabel.TabIndex = 7;
            this.QtyRestockedLabel.Text = "Quantity Restocked: ";
            // 
            // QtyRestockedTextBox
            // 
            this.QtyRestockedTextBox.Location = new System.Drawing.Point(595, 34);
            this.QtyRestockedTextBox.Name = "QtyRestockedTextBox";
            this.QtyRestockedTextBox.Size = new System.Drawing.Size(133, 20);
            this.QtyRestockedTextBox.TabIndex = 8;
            // 
            // UpdateRestockedButton
            // 
            this.UpdateRestockedButton.AutoSize = true;
            this.UpdateRestockedButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpdateRestockedButton.Location = new System.Drawing.Point(426, 60);
            this.UpdateRestockedButton.Name = "UpdateRestockedButton";
            this.UpdateRestockedButton.Size = new System.Drawing.Size(302, 44);
            this.UpdateRestockedButton.TabIndex = 9;
            this.UpdateRestockedButton.Text = "Update Restocked Qty for Selected Item";
            this.UpdateRestockedButton.UseVisualStyleBackColor = false;
            this.UpdateRestockedButton.Click += new System.EventHandler(this.UpdateRestockedButton_Click);
            // 
            // SortItemButton
            // 
            this.SortItemButton.AutoSize = true;
            this.SortItemButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SortItemButton.Location = new System.Drawing.Point(426, 110);
            this.SortItemButton.Name = "SortItemButton";
            this.SortItemButton.Size = new System.Drawing.Size(302, 46);
            this.SortItemButton.TabIndex = 10;
            this.SortItemButton.Text = "Sort Items Based on Sales";
            this.SortItemButton.UseVisualStyleBackColor = false;
            this.SortItemButton.Click += new System.EventHandler(this.SortItemButton_Click);
            // 
            // UpdateDataGroupBox
            // 
            this.UpdateDataGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateDataGroupBox.Controls.Add(this.SortItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateRestockedButton);
            this.UpdateDataGroupBox.Controls.Add(this.QtyRestockedTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.QtyRestockedLabel);
            this.UpdateDataGroupBox.Controls.Add(this.DeleteItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateQtySoldButton);
            this.UpdateDataGroupBox.Controls.Add(this.QtySoldTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.QtySoldLabel);
            this.UpdateDataGroupBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataGroupBox.Location = new System.Drawing.Point(363, 370);
            this.UpdateDataGroupBox.Name = "UpdateDataGroupBox";
            this.UpdateDataGroupBox.Size = new System.Drawing.Size(785, 198);
            this.UpdateDataGroupBox.TabIndex = 11;
            this.UpdateDataGroupBox.TabStop = false;
            this.UpdateDataGroupBox.Text = "Update Data";
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.AutoSize = true;
            this.SaveDataButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveDataButton.Location = new System.Drawing.Point(50, 19);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(204, 50);
            this.SaveDataButton.TabIndex = 12;
            this.SaveDataButton.Text = "Save Grocery Data";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // SaveSalesButton
            // 
            this.SaveSalesButton.AutoSize = true;
            this.SaveSalesButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveSalesButton.Location = new System.Drawing.Point(50, 75);
            this.SaveSalesButton.Name = "SaveSalesButton";
            this.SaveSalesButton.Size = new System.Drawing.Size(204, 47);
            this.SaveSalesButton.TabIndex = 13;
            this.SaveSalesButton.Text = "Save Sales Report";
            this.SaveSalesButton.UseVisualStyleBackColor = false;
            this.SaveSalesButton.Click += new System.EventHandler(this.SaveSalesButton_Click);
            // 
            // SaveRestockButton
            // 
            this.SaveRestockButton.AutoSize = true;
            this.SaveRestockButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveRestockButton.Location = new System.Drawing.Point(50, 128);
            this.SaveRestockButton.Name = "SaveRestockButton";
            this.SaveRestockButton.Size = new System.Drawing.Size(204, 45);
            this.SaveRestockButton.TabIndex = 14;
            this.SaveRestockButton.Text = "Save Restock Needs Report";
            this.SaveRestockButton.UseVisualStyleBackColor = false;
            this.SaveRestockButton.Click += new System.EventHandler(this.SaveRestockButton_Click);
            // 
            // SaveDataGroupBox
            // 
            this.SaveDataGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveDataGroupBox.Controls.Add(this.SaveRestockButton);
            this.SaveDataGroupBox.Controls.Add(this.SaveSalesButton);
            this.SaveDataGroupBox.Controls.Add(this.SaveDataButton);
            this.SaveDataGroupBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDataGroupBox.Location = new System.Drawing.Point(1206, 370);
            this.SaveDataGroupBox.Name = "SaveDataGroupBox";
            this.SaveDataGroupBox.Size = new System.Drawing.Size(315, 198);
            this.SaveDataGroupBox.TabIndex = 15;
            this.SaveDataGroupBox.TabStop = false;
            this.SaveDataGroupBox.Text = "Save Data";
            // 
            // OutputStatusLabel
            // 
            this.OutputStatusLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OutputStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputStatusLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputStatusLabel.Location = new System.Drawing.Point(311, 591);
            this.OutputStatusLabel.Name = "OutputStatusLabel";
            this.OutputStatusLabel.Size = new System.Drawing.Size(892, 73);
            this.OutputStatusLabel.TabIndex = 16;
            this.OutputStatusLabel.Text = "Operations Status Update Displayed Here";
            this.OutputStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 14;
            this.OutputListBox.Location = new System.Drawing.Point(50, 46);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1471, 312);
            this.OutputListBox.TabIndex = 17;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1563, 692);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.OutputStatusLabel);
            this.Controls.Add(this.SaveDataGroupBox);
            this.Controls.Add(this.UpdateDataGroupBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.LoadDataGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoadDataGroupBox.ResumeLayout(false);
            this.LoadDataGroupBox.PerformLayout();
            this.UpdateDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.PerformLayout();
            this.SaveDataGroupBox.ResumeLayout(false);
            this.SaveDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.GroupBox LoadDataGroupBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label QtySoldLabel;
        private System.Windows.Forms.TextBox QtySoldTextBox;
        private System.Windows.Forms.Button UpdateQtySoldButton;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Label QtyRestockedLabel;
        private System.Windows.Forms.TextBox QtyRestockedTextBox;
        private System.Windows.Forms.Button UpdateRestockedButton;
        private System.Windows.Forms.Button SortItemButton;
        private System.Windows.Forms.GroupBox UpdateDataGroupBox;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button SaveSalesButton;
        private System.Windows.Forms.Button SaveRestockButton;
        private System.Windows.Forms.GroupBox SaveDataGroupBox;
        private System.Windows.Forms.Label OutputStatusLabel;
        private System.Windows.Forms.ListBox OutputListBox;
    }
}

