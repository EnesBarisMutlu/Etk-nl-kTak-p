using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BL.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EtkınlıkTakıp
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        void HataGöster()
        {
            MessageBox.Show("Hata ayrıntıları\n" + BL.BL.error, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Listele()
        {
            foreach (var k in BL.BL.Etkinlikler)
            {
                EtkinlikListeyeEkle(k);
            }
        }

        private void EtkinlikEkle(object sender, EventArgs e)
        {
            FrmEtkinlik frm = new FrmEtkinlik()
            {
                Text = "Etkinlik Ekle",
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterParent

            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.BL.EtkinlikEkle(frm.Adi, frm.Tarih, frm.Yer, frm.Açıklama);
                if (res == false)
                    MessageBox.Show("Hata ayrıntıları:\n" + BL.BL.error, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    EtkinlikListeyeEkle(BL.BL.Etkinlikler[BL.BL.Etkinlikler.Count - 1]);
            }
        }

        private void EtkinlikDüzenle(object sender, EventArgs e)
        {
            if (listViewEtk.SelectedItems.Count == 0)
                return;

            var etkinlik = listViewEtk.SelectedItems[0];

            var k = etkinlik.Tag as Etkinlik;

            FrmEtkinlik frm = new FrmEtkinlik()
            {
                Text = "Etkinlik Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Adi = k.Adi,
                Tarih = k.Tarih,
                Yer = k.Yer,
                Açıklama = k.Açıklama

            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.BL.EtkinlikDuzenle(k.EID, frm.Adi, frm.Tarih, frm.Yer, frm.Açıklama);

            if (res == false)
                HataGöster();
            else
            {
                etkinlik.SubItems[0].Text = frm.Adi;
                etkinlik.SubItems[1].Text = frm.Tarih;
                etkinlik.SubItems[2].Text = frm.Yer;
                etkinlik.SubItems[3].Text = frm.Açıklama;
            }
        }

        private void EtkinlikSil(object sender, EventArgs e)
        {
            if (listViewEtk.SelectedItems.Count == 0)
                return;

            var sonuc = MessageBox.Show("Seçilen Etkinlik Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc != DialogResult.Yes)
                return;

            var etkinlik = listViewEtk.SelectedItems[0];
            var k = etkinlik.Tag as Etkinlik;

            var res = BL.BL.EtkinlikSil(k.EID);
            if (res == false)
                HataGöster();
            else
                listViewEtk.Items.Remove(etkinlik);
        }

        void EtkinlikListeyeEkle(Etkinlik e)
        {
            ListViewItem Etkinlik = new ListViewItem(new string[]
            {
                    e.Adi,
                    e.Tarih,
                    e.Yer,
                    e.Açıklama

            });

            Etkinlik.Tag = e;

            listViewEtk.Items.Add(Etkinlik);
        }

        private void EtkinlikleriListele(object sender, EventArgs e)
        {
            BL.BL.EtkinlikleriListele();

            Listele();
        }

        private void KatılımcıEkle(object sender, EventArgs e)
        {

            if (listViewEtk.SelectedItems.Count == 0)
                return;

            var etkinlik = listViewEtk.SelectedItems[0].Tag as Etkinlik;

            FrmKatılımcı frm = new FrmKatılımcı()
            {
                Text = "Katılımcı Ekle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var res = BL.BL.KatılımcıEkle(etkinlik.EID, frm.Adi, frm.Telefon);
                if (res == false)
                    HataGöster();
                else
                    KatılımcıListeyeEkle(etkinlik.Katılımcılar[etkinlik.Katılımcılar.Count - 1]);
            }
        }

        private void KatılımcıDüzenle(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            var katılımcı = listView2.SelectedItems[0];

            var k = katılımcı.Tag as Katılımcı;

            FrmKatılımcı frm = new FrmKatılımcı()
            {
                Text = "Katılımcı Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,

                Adi = k.Adi,
                Telefon = k.Telefon,
            };

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            var res = BL.BL.KatılımcıDuzenle(k.KEID, k.KID, frm.Adi, frm.Telefon);

            if (res == false)
                HataGöster();
            else
            {
                katılımcı.SubItems[0].Text = frm.Adi;
                katılımcı.SubItems[1].Text = frm.Telefon;
            }
        }

        private void KatılımcıSil(object sender, EventArgs e)
        {
            {
                if (listView2.SelectedItems.Count == 0)
                    return;

                var sonuc = MessageBox.Show("Seçilen Katılımcı Silinsin Mi?", "Silmeyi Onayla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (sonuc != DialogResult.Yes)
                    return;

                var katılımcı = listView2.SelectedItems[0];
                var b = katılımcı.Tag as Katılımcı;

                var res = BL.BL.KatılımcıSil(b.KEID, b.KID);
                if (res == false)
                    HataGöster();
                else
                    listView2.Items.Remove(katılımcı);
            }
        }

        void KatılımcıListeyeEkle(Katılımcı k)
        {

            ListViewItem katılımcı = new ListViewItem(new string[]
                {

                k.Adi,
                k.Telefon,

                });

            katılımcı.Tag = k;

            listView2.Items.Add(katılımcı);

        }

        void KatılımcıListele(Etkinlik e)
        {
            listView2.Items.Clear();
            foreach (var k in e.Katılımcılar)
                KatılımcıListeyeEkle(k);
        }

        private void KatılımcılarListele(object sender, EventArgs e)
        {

            listView2.Items.Clear();
            if (listViewEtk.SelectedItems.Count == 0)
            {
                return;
            }

            var etkinlik = listViewEtk.SelectedItems[0].Tag as Etkinlik;

            var res = BL.BL.EtkinlikKatılımcılarınıListele(etkinlik.EID);

            if (res == false)
                HataGöster();
            else
            {
                KatılımcıListele(etkinlik);
            }
        }
    }
}
