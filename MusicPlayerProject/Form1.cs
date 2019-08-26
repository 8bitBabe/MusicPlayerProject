using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //choose song
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            Player.URL = textBox1.Text;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //play song
            Player.Ctlcontrols.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            //pause song
            Player.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //stop song
            Player.Ctlcontrols.stop();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close player
            Close();
        }
    }
}
