namespace UserInfoApp
{
    partial class SecondForm
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
            this.SecondFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondFormLabel
            // 
            this.SecondFormLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondFormLabel.Location = new System.Drawing.Point(173, 171);
            this.SecondFormLabel.Name = "SecondFormLabel";
            this.SecondFormLabel.Size = new System.Drawing.Size(445, 128);
            this.SecondFormLabel.TabIndex = 0;
            this.SecondFormLabel.Text = "Second Form Output Goes Here";
            this.SecondFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondFormLabel);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label SecondFormLabel;
    }
}