namespace KidzAlphabet
{
    partial class MainForm
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
            this.lblHurufKecil = new System.Windows.Forms.Label();
            this.lblHurufBesar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHurufKecil
            // 
            this.lblHurufKecil.AutoSize = true;
            this.lblHurufKecil.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurufKecil.Location = new System.Drawing.Point(12, 9);
            this.lblHurufKecil.Name = "lblHurufKecil";
            this.lblHurufKecil.Size = new System.Drawing.Size(321, 108);
            this.lblHurufKecil.TabIndex = 0;
            this.lblHurufKecil.Text = "[huruf]";
            // 
            // lblHurufBesar
            // 
            this.lblHurufBesar.AutoSize = true;
            this.lblHurufBesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurufBesar.Location = new System.Drawing.Point(12, 130);
            this.lblHurufBesar.Name = "lblHurufBesar";
            this.lblHurufBesar.Size = new System.Drawing.Size(321, 108);
            this.lblHurufBesar.TabIndex = 1;
            this.lblHurufBesar.Text = "[huruf]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.lblHurufBesar);
            this.Controls.Add(this.lblHurufKecil);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belajar Huruf Yuuuk!";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHurufKecil;
        private System.Windows.Forms.Label lblHurufBesar;
    }
}

