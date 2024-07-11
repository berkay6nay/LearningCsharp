using NTierArchHw.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw.Facade
{
	internal class FOgretimElemani
	{
		public static int ogretimElemaniEkle(EOgretimElemanı oe)
		{
			Connection.connect();

			string sorgu = "SP_EkleOgretimElemani";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("ogretimElemaniAdi", oe.ogretimElemaniAdi);
			cmd.Parameters.AddWithValue("ogretimElemaniSoyadi", oe.ogretimElemaniSoyadi);
			cmd.Parameters.AddWithValue("unvan", oe.unvan);

			int x = cmd.ExecuteNonQuery();
			Connection.disconnect();

			return x;
		}

		public static int ogretimElemaniSil(int ogretimElemaniID)
		{
			Connection.connect();
			string sorgu = "SP_OgretimElemaniSil";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogretimElemaniID", ogretimElemaniID);
			int x = cmd.ExecuteNonQuery();
			Connection.disconnect();
			return x;
		}

		public static int ogretimElemaniGuncelle(int id, string yeni_isim, string yeni_soyisim,string yeni_unvan)
		{
			Connection.connect();
			string sorgu = "SP_OgretimElemaniGuncelle";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogretimElemaniID", id);
			cmd.Parameters.AddWithValue("ogretimElemaniAdi", yeni_isim);
			cmd.Parameters.AddWithValue("ogretimElemaniSoyadi", yeni_soyisim);
			cmd.Parameters.AddWithValue("unvan", yeni_unvan);
			int x = cmd.ExecuteNonQuery();
			cmd.ExecuteNonQuery();
			Connection.disconnect();
			return x;
		}

		public static List<EOgretimElemanı> ogretimElemaniBul(string isim)
		{
			Connection.connect();
			List<EOgretimElemanı> list = null;
			string sorgu = "SP_AraOgretimElemani";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogretimElemaniAdi", isim);
			SqlDataReader rdr = cmd.ExecuteReader();
			if (rdr.HasRows)
			{
				list = new List<EOgretimElemanı>();
				while (rdr.Read())
				{
					EOgretimElemanı eOgretimElemanı = new EOgretimElemanı();

					eOgretimElemanı.ogretimElemaniID = Convert.ToInt32(rdr.GetValue(0));
					eOgretimElemanı.ogretimElemaniAdi = rdr.GetValue(1).ToString();
					eOgretimElemanı.ogretimElemaniSoyadi = rdr.GetValue(2).ToString();
					eOgretimElemanı.unvan= rdr.GetValue(3).ToString();
					list.Add(eOgretimElemanı);
				}
				rdr.Close();
			}
			Connection.disconnect();
			return list;
		}

		public static List<EOgretimElemanı> ogretimElemaniListele()
		{
			List<EOgretimElemanı> list = null;
			Connection.connect();
			string sorgu = "SP_ListOgretimElemani";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataReader rdr = cmd.ExecuteReader();
			if (rdr.HasRows)
			{
				list = new List<EOgretimElemanı>();
				while (rdr.Read())
				{
					EOgretimElemanı eOgretimElemanı = new EOgretimElemanı();

					eOgretimElemanı.ogretimElemaniID = Convert.ToInt32(rdr.GetValue(0));
					eOgretimElemanı.ogretimElemaniAdi = rdr.GetValue(1).ToString();
					eOgretimElemanı.ogretimElemaniSoyadi = rdr.GetValue(2).ToString();
					eOgretimElemanı.unvan = rdr.GetValue(3).ToString();
					list.Add(eOgretimElemanı);
				}
				rdr.Close();
			}
			Connection.disconnect();
			return list;
		}



	}
}
