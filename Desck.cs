using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlayingCards
{
    public partial class Desck : Form
    {
        private string folderPath = null;
        private string[] fileNames = null ;

        public Desck()
        {
            InitializeComponent();
            InitializeDesck();
        }

        private void InitializeDesck()
        {
            this.BackColor = Color.Green;
        }

        private void LoadCards_Click(object sender, EventArgs e)
        {
            folderPath = @"C:\Users\Андрей\Downloads\Playing Cards\playing_card_images\face";
            fileNames = Directory.GetFiles(folderPath);
        }
    }
}
