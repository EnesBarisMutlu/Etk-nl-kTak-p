using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Entity;

using DL;

namespace BL
{
    public static class BL
    {
        public static List<Etkinlik> Etkinlikler = new List<Etkinlik>();
        public static string error = "";

        public static bool EtkinlikEkle(string Adi, string Tarih, string Yer, string Açıklama)
        {
            Etkinlik e = new Etkinlik()
            {
                EID = Guid.NewGuid().ToString(),
                Adi = Adi,
                Tarih = Tarih,
                Yer = Yer,
                Açıklama = Açıklama
            };

            int res = DL.DL.EtkinlikEkle(e.EID, e.Adi, e.Tarih, e.Yer, e.Açıklama, out error);
            if (res > 0)
            {
                Etkinlikler.Add(e);
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool EtkinlikDuzenle(string EID, string Ad, string Tarih, string Yer, string Açıklama)
        {
            Etkinlik e = Etkinlikler.Find(o => o.EID == EID);
            if (e != null)
            {
                int res = DL.DL.EtkinlikDuzenle(e.EID, Ad, Tarih, Yer, Açıklama, out error);
                if (res > 0)
                {
                    e.Adi = Ad;
                    e.Tarih = Tarih;
                    e.Yer = Yer;
                    e.Açıklama = Açıklama;

                    return true;
                }
                else
                    return false;

            }
            return true;
        }

        public static bool EtkinlikSil(string EID)
        {
            int res = DL.DL.EtkinlikSil(EID, out error);
            if (res > 0)
            {
                Etkinlik e = Etkinlikler.Find(o => o.EID == EID);
                Etkinlikler.Remove(e);
                return true;
            }
            else
                return false;
        }

        public static bool KatılımcıEkle(string KEID, string Adi, string Telefon)
        {
            Etkinlik e = Etkinlikler.Find(o => o.EID == KEID);
            Katılımcı k = new Katılımcı()
            {
                KID = Guid.NewGuid().ToString(),
                Adi = Adi,
                Telefon = Telefon
            };

            int res = DL.DL.KatılımcıEkle(k.KID, KEID, Adi, Telefon ,out error);
            if (res > 0)
            {
                e.Katılımcılar.Add(k);
                return true;

            }
            else
                return false;
        }

        public static bool KatılımcıDuzenle(string KID, string KEID, string Ad, string Telefon)
        {
            Etkinlik e = Etkinlikler.Find(o => o.EID == KEID);
            int res = DL.DL.KatılımıcıDuzenle(KID, Ad, Telefon, out error);
            if (res > 0)
            {
                Katılımcı k = e.Katılımcılar.Find(o => o.KID == KID);
                    k.Adi = Ad;
                    k.Telefon = Telefon;
                return true;
            }

            else return false;
        }

        public static bool KatılımcıSil(string KEID, string KID)
        {
            Etkinlik e = Etkinlikler.Find(o => o.EID == KEID);
            int res = DL.DL.KatılımcıSil(KID, out error);
            if (res > 0)
            {
                Katılımcı k = e.Katılımcılar.Find(o => o.KID == KID);
                e.Katılımcılar.Remove(k);
                return true;
            }
            else return false;

        }

        public static bool EtkinlikleriListele()
        {
            var list = DL.DL.EtkinlikleriListele(out error);
            if (list == null)
                return false;

            Etkinlikler = new List<Etkinlik>();
            foreach(var e in list)
            {
                Etkinlikler.Add(new Etkinlik()
                {
                    EID = e.EID,
                    Adi = e.Adi,
                    Tarih = e.Tarih,
                    Yer = e.Yer,
                    Açıklama = e.Açıklama
                });
            }
            return true;
        }

        public static bool EtkinlikKatılımcılarınıListele(string KEID)
        {
            var list = DL.DL.EtkinlikKatılımcılarıListele(KEID, out error);
            if (list == null)
                return false;

            var etkinlik = Etkinlikler.Find(o=>o.EID == KEID);
            etkinlik.Katılımcılar = new List<Katılımcı>();

            foreach (var e in list)
            {
                etkinlik.Katılımcılar.Add(new Katılımcı()
                {
                    KID = e.KID,
                    KEID = KEID,
                    Adi = e.Adi,
                    Telefon = e.Telefon,

                });
            }
            return true;
        }
    }
}
