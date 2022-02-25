﻿using Kutuphane07.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici kullanici;

        public KutuphaneForm(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
            cboTurler.DataSource = Enum.GetNames(typeof(KitapTurEnum));
        }

        private void tsmiCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            new HesabimForm(kullanici).ShowDialog();
        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bf = new BagisForm();
            bf.BagisYapildi += Bf_BagisYapildi;
            bf.ShowDialog();
        }

        private void Bf_BagisYapildi(object sender, EventArgs e)
        {
            dgvKitapDetaylari.DataSource = null;
            dgvKitapDetaylari.DataSource = KutuphaneYoneticisi.KitapListesi;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
                dgvKitapDetaylari.DataSource = KutuphaneYoneticisi.KitapListesi;
            else
                dgvKitapDetaylari.DataSource = KutuphaneYoneticisi.KitapListesi.Where(x => x.Ad.ToLower().Contains(txtAra.Text.ToLower()) || x.YazarAdi.ToLower().Contains(txtAra.Text.ToLower())).ToList();
        }

        private void cboTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTurler.SelectedIndex == 0)
                dgvKitapDetaylari.DataSource = KutuphaneYoneticisi.KitapListesi;
            else
                dgvKitapDetaylari.DataSource = KutuphaneYoneticisi.SeciliTurdekiKitaplariDondur((KitapTurEnum)(cboTurler.SelectedIndex));
        }
    }
}