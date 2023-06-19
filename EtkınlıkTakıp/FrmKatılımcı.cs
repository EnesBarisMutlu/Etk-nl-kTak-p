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
    public partial class FrmKatılımcı : Form
    {
        public FrmKatılımcı()
        {
            InitializeComponent();
        }

        public string Adi
        {
            get => txtAdı.Text;
            set => txtAdı.Text = value;
        }

        public string Telefon
        {
            get => txtTel.Text;
            set => txtTel.Text = value;
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
