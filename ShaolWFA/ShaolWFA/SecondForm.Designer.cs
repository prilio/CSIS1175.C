namespace ShaolWFA
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
            this.goodByeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goodByeLabel
            // 
            this.goodByeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodByeLabel.Location = new System.Drawing.Point(259, 132);
            this.goodByeLabel.Name = "goodByeLabel";
            this.goodByeLabel.Size = new System.Drawing.Size(229, 89);
            this.goodByeLabel.TabIndex = 0;
            this.goodByeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodByeLabel);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label goodByeLabel;
    }
}