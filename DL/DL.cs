#define MySQL


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#if (MSSQL)

#elif (MySQL)
using MDbConnection = MySql.Data.MySqlClient.MySqlConnection;
using MDbConnectionStringBuilder = MySql.Data.MySqlClient.MySqlConnectionStringBuilder;
using MDbCommand = MySql.Data.MySqlClient.MySqlCommand;
using MDbDataReader = MySql.Data.MySqlClient.MySqlDataReader;

#elif(ACCESS)

#endif

namespace DL
{
   
    public static class DL
    {
        static MDbConnection baglanti = new MDbConnection(
            new MDbConnectionStringBuilder()
            {
#if MySQL
                Server = "localhost",
                Database = "etkinlik",
                UserID = "root",
                Password = "cv2001enes2000",
#elif MSSQL
#elif ACCESS
#endif


            }.ConnectionString);
        public static int EtkinlikEkle(string EID, string Adi, string Tarih, string Yer, string Açıklama, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("EtkinlikEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@EID", EID);
                komut.Parameters.AddWithValue("@Adi", Adi);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@Yer", Yer);
                komut.Parameters.AddWithValue("@Aciklama", Açıklama);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int EtkinlikDuzenle(string EID, string Adi, string Tarih, string Yer, string Açıklama, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("EtkinlikDuzenle" ,baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@EID", EID);
                komut.Parameters.AddWithValue("@Adi", Adi);
                komut.Parameters.AddWithValue("@Tarih", Tarih);
                komut.Parameters.AddWithValue("@Yer", Yer);
                komut.Parameters.AddWithValue("@Aciklama", Açıklama);
                error = "";
                return komut.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int EtkinlikSil(string EID, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("EtkinlikSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@EID", EID);
                error = "";
                return komut.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KatılımcıEkle(string KID, string KEID, string Adi, string Telefon, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KatılımcıEkle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@KID", KID);
                komut.Parameters.AddWithValue("@KEID", KEID);
                komut.Parameters.AddWithValue("@Adi", Adi);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                error = "";
                return komut.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KatılımıcıDuzenle(string KID, string Adi, string Telefon, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KatılımcıDüzenle", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@KID", KID);
                komut.Parameters.AddWithValue("@Adi", Adi);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                error = "";
                return komut.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KatılımcıSil(string KID, out string error)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("KatılımcıSil", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@KID", KID);
                error = "";
                return komut.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<(string EID, string Adi, string Tarih, string Yer, string Açıklama)> EtkinlikleriListele(out string error)
        {
            List<(string, string, string, string, string)> list = new List<(string, string, string, string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("EtkinlikleriListele", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString())

                        );
                }
                error = "";
                return list;

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static List<(string KID, string Adi, string Telefon  )> EtkinlikKatılımcılarıListele(string KEID, out string error) 
        {
            List<(string, string, string)> list = new List<(string, string, string)>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MDbCommand komut = new MDbCommand("EtkinlikKatılımcılarınıListele", baglanti) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@KEID", KEID);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString())
                        );
                }
                error = "";
                return list;

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }       
    }
}
