using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkınlıkTakıp
{
    public partial class FrmEtkinlik : Form
    {
        public FrmEtkinlik()
        {
            InitializeComponent();
        }

        public string Adi
        {
            get => txtAd.Text;
            set => txtAd.Text = value;
        }

        public string Tarih
        {
            get => txtTarih.Text;
            set => txtTarih.Text = value;
        }

        public string Yer
        {
            get => txtYer.Text;
            set => txtYer.Text = value;
        }

        public string Açıklama
        {
            get => txtAçıklama.Text;
            set => txtAçıklama.Text = value;
        }

        private void Tamam(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void İptal(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
