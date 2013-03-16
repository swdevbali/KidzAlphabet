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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHurufKecil = new System.Windows.Forms.Label();
            this.lblHurufBesar = new System.Windows.Forms.Label();
            this.picGambar = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHurufKecil
            // 
            this.lblHurufKecil.AutoSize = true;
            this.lblHurufKecil.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurufKecil.Location = new System.Drawing.Point(306, 9);
            this.lblHurufKecil.Name = "lblHurufKecil";
            this.lblHurufKecil.Size = new System.Drawing.Size(321, 108);
            this.lblHurufKecil.TabIndex = 0;
            this.lblHurufKecil.Text = "[huruf]";
            this.lblHurufKecil.Visible = false;
            // 
            // lblHurufBesar
            // 
            this.lblHurufBesar.AutoSize = true;
            this.lblHurufBesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurufBesar.Location = new System.Drawing.Point(12, 9);
            this.lblHurufBesar.Name = "lblHurufBesar";
            this.lblHurufBesar.Size = new System.Drawing.Size(321, 108);
            this.lblHurufBesar.TabIndex = 1;
            this.lblHurufBesar.Text = "[huruf]";
            // 
            // picGambar
            // 
            this.picGambar.Location = new System.Drawing.Point(30, 131);
            this.picGambar.Name = "picGambar";
            this.picGambar.Size = new System.Drawing.Size(486, 285);
            this.picGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGambar.TabIndex = 2;
            this.picGambar.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(558, 163);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblNama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(52, 19);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(177, 55);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "[nama]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KidzAlphabet.Properties.Resources.Gambar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.picGambar);
            this.Controls.Add(this.lblHurufBesar);
            this.Controls.Add(this.lblHurufKecil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belajar Huruf Yuuuk!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHurufKecil;
        private System.Windows.Forms.Label lblHurufBesar;
        private System.Windows.Forms.PictureBox picGambar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNama;
    }
}

