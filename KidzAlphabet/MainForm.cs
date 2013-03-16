using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KidzAlphabet
{
    public partial class MainForm : Form
    {
        SoundPlayer player;
        public MainForm()
        {
            InitializeComponent();
            lblHurufKecil.Text = "";
            lblHurufBesar.Text = "";
            lblNama.Text = "";
            player = new SoundPlayer();
            lblHurufBesar.Visible = false;
            picGambar.Visible = false;
        }

        
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!lblHurufBesar.Visible)
            {
                lblHurufBesar.Visible = true;
                picGambar.Visible = true;
                BackgroundImage = null;
            }
            try
            {
                
                lblHurufKecil.Text = e.KeyChar.ToString().ToLower();
                lblHurufBesar.Text = e.KeyChar.ToString().ToUpper();
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\suara\\" + lblHurufKecil.Text + ".wav";
                picGambar.Load(Application.StartupPath + "\\gambar\\" + lblHurufKecil.Text + ".png");
                switch (lblHurufKecil.Text)
                {
                    case "a" :
                        lblNama.Text = "Apel";
                        break;
                    case "b":
                        lblNama.Text = "Beruang";
                        break;
                    case "c":
                        lblNama.Text = "Cacing";
                        break;
                    case "d":
                        lblNama.Text = "Domba";
                        break;
                    case "e":
                        lblNama.Text = "Elang";
                        break;
                    case "f":
                        lblNama.Text = "Foto";
                        break;
                    case "g":
                        lblNama.Text = "Gajah";
                        break;
                    case "h":
                        lblNama.Text = "Harimau";
                        break;
                    case "i":
                        lblNama.Text = "Ikan";
                        break;
                    case "j":
                        lblNama.Text = "Jerapah";
                        break;
                    case "k":
                        lblNama.Text = "Kancil";
                        break;
                    case "l":
                        lblNama.Text = "Layang-layang";
                        break;
                    case "m":
                        lblNama.Text = "Monyet";
                        break;
                    case "n":
                        lblNama.Text = "Nanas";
                        break;
                    case "o":
                        lblNama.Text = "Obat";
                        break;
                    case "p":
                        lblNama.Text = "Pisang";
                        break;
                    case "q":
                        lblNama.Text = "Quran";
                        break;
                    case "r":
                        lblNama.Text = "Ranting";
                        break;
                    case "s":
                        lblNama.Text = "Semut";
                        break;
                    case "t":
                        lblNama.Text = "Tikus";
                        break;
                    case "u":
                        lblNama.Text = "Uang";
                        break;
                    case "v":
                        lblNama.Text = "Vas";
                        break;
                    case "w":
                        lblNama.Text = "Wajah";
                        break;
                    case "x":
                        lblNama.Text = "Xylophone";
                        break;
                    case "z":
                        lblNama.Text = "Zebra";
                        break;
                }
            }
            catch (Exception ex)
            {   
                lblHurufKecil.Text = "";
                lblHurufBesar.Text = ex.Message;
            }
        }
    }
}
