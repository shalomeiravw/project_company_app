
namespace App_Perusahaan
{
    partial class Form2
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
            this.gBoxLaporan = new System.Windows.Forms.GroupBox();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.cBoxLaporan = new System.Windows.Forms.ComboBox();
            this.gBoxLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxLaporan
            // 
            this.gBoxLaporan.Controls.Add(this.dgvLaporan);
            this.gBoxLaporan.Controls.Add(this.cBoxLaporan);
            this.gBoxLaporan.Location = new System.Drawing.Point(12, 70);
            this.gBoxLaporan.Name = "gBoxLaporan";
            this.gBoxLaporan.Size = new System.Drawing.Size(1267, 601);
            this.gBoxLaporan.TabIndex = 0;
            this.gBoxLaporan.TabStop = false;
            this.gBoxLaporan.Text = "LAPORAN";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(15, 79);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(728, 499);
            this.dgvLaporan.TabIndex = 1;
            // 
            // cBoxLaporan
            // 
            this.cBoxLaporan.FormattingEnabled = true;
            this.cBoxLaporan.Location = new System.Drawing.Point(15, 37);
            this.cBoxLaporan.Name = "cBoxLaporan";
            this.cBoxLaporan.Size = new System.Drawing.Size(196, 24);
            this.cBoxLaporan.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 683);
            this.Controls.Add(this.gBoxLaporan);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gBoxLaporan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLaporan;
        private System.Windows.Forms.ComboBox cBoxLaporan;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}