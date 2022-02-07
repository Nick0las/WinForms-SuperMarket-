namespace Laba_4
{
    partial class DetailsProd
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.labelNameProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(432, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(346, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(13, 92);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ReadOnly = true;
            this.textBoxDetail.Size = new System.Drawing.Size(413, 346);
            this.textBoxDetail.TabIndex = 1;
            // 
            // labelNameProd
            // 
            this.labelNameProd.AutoSize = true;
            this.labelNameProd.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelNameProd.ForeColor = System.Drawing.Color.Black;
            this.labelNameProd.Location = new System.Drawing.Point(42, 42);
            this.labelNameProd.Name = "labelNameProd";
            this.labelNameProd.Size = new System.Drawing.Size(88, 32);
            this.labelNameProd.TabIndex = 2;
            this.labelNameProd.Text = "label1";
            // 
            // DetailsProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNameProd);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.pictureBox);
            this.Name = "DetailsProd";
            this.Text = "DetailsProd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.TextBox textBoxDetail;
        public System.Windows.Forms.Label labelNameProd;
    }
}