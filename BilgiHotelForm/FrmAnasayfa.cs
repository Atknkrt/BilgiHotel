﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelForm
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void müsteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            FrmMüsteriEkle fme = new FrmMüsteriEkle();
            fme.MdiParent = this;
            fme.Show();
        }

        private void misafirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            FrmMisafirEkle fme = new FrmMisafirEkle();
            fme.MdiParent = this;
            fme.Show();
        }

        private void odaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaDurumBilgileri fme = new OdaDurumBilgileri();
            fme.MdiParent = this;
            fme.Show();
        }

		private void rezervasyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmRezervasyonBilgileri frb = new FrmRezervasyonBilgileri();
            frb.MdiParent = this;
            frb.Show();
		}
	}
}