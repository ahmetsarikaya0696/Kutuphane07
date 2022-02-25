using Kutuphane07.DATA;
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
    public partial class BagisForm : Form
    {
        public event EventHandler BagisYapildi;
        public BagisForm()
        {
            InitializeComponent();
            cboKitapTuru.DataSource = Enum.GetNames(typeof(KitapTurEnum)).Where(x => x != "Tüm_Kitaplar").ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtKitapAdi.Text) || string.IsNullOrEmpty(txtYazarAdi.Text)))
            {
                KutuphaneYoneticisi.KitapBagisla
                    (txtKitapAdi.Text, dtpBasimTarihi.Value, (KitapTurEnum)(cboKitapTuru.SelectedIndex + 1), txtYazarAdi.Text, (int)(nudSayfaSayisi.Value), txtAciklama.Text);
                MessageBox.Show("Bagis yapıldi");
                if (BagisYapildi != null) BagisYapildi(this, e);
            }
        }
    }
}
