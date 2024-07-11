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
	internal class FOgrenci
	{

		public static int ogrenciEkle(EOgrenci o)
		{
			int x = 0;
			Connection.connect();
			string sorgu = "SP_EkleOgrenci";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogrenciAdi", o.ogrenciAdi);
			cmd.Parameters.AddWithValue("ogrenciSoyadi", o.ogrenciSoyadi);
			x = cmd.ExecuteNonQuery();
			Connection.disconnect();
			return x;
		}


		public static int ogrenciSil(int ogrenciID)
		{
			Connection.connect();
			string sorgu = "SP_OgrenciSil";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogrenciID" , ogrenciID);
			int x = cmd.ExecuteNonQuery();
			Connection.disconnect();
			return x;
		}

		public static int ogrenciGuncelle(int id , string yeni_isim , string yeni_soyisim)
		{
			Connection.connect();
			string sorgu = "SP_OgrenciGuncelle";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType= CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogrenciID" , id);
			cmd.Parameters.AddWithValue("ogrenciAdi", yeni_isim);
			cmd.Parameters.AddWithValue("ogrenciSoyadi", yeni_soyisim);
			int x = cmd.ExecuteNonQuery();
			cmd.ExecuteNonQuery();
			Connection.disconnect();
			return x;
		}

		public static List<EOgrenci> ogrenciBul(string isim)
		{
			Connection.connect();
			List<EOgrenci> list = null;
			string sorgu = "SP_AraOgrenciler";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ogrenciAdi", isim);
			SqlDataReader rdr = cmd.ExecuteReader();
			if (rdr.HasRows)
			{
				list = new List<EOgrenci>();
				while (rdr.Read())
				{
					EOgrenci eOgrenci = new EOgrenci();
					eOgrenci.ogrenciID = Convert.ToInt32(rdr.GetValue(0));
					eOgrenci.ogrenciAdi = rdr.GetValue(1).ToString();
					eOgrenci.ogrenciSoyadi = rdr.GetValue(2).ToString();
					list.Add(eOgrenci);
				}
				rdr.Close();
			}
			Connection.disconnect();
			return list;
		}

		public static List<EOgrenci> ogrencileriListele()
		{
			List<EOgrenci> list = null;
			Connection.connect();
			string sorgu = "SP_ListOgrenciler";
			SqlCommand cmd = new SqlCommand(sorgu, Connection.con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataReader rdr = cmd.ExecuteReader();
			if (rdr.HasRows)
			{
				list = new List<EOgrenci>();
				while (rdr.Read())
				{
					EOgrenci eOgrenci = new EOgrenci();
					eOgrenci.ogrenciID = Convert.ToInt32(rdr.GetValue(0));
					eOgrenci.ogrenciAdi = rdr.GetValue(1).ToString();
					eOgrenci.ogrenciSoyadi = rdr.GetValue(2).ToString();
					list.Add(eOgrenci);
				}
				rdr.Close();
			}
			Connection.disconnect();
			return list;
		}
	}
}
/*
 * Ogrenci Sil ve güncelle işlemleri tamamlanacak
 * Façade, DB-SP yazılmalı, BLL ve Presentation layer tamamlanmalı
 * Yapılan tüm işlemler öğretim üyesi için tekrarlanmalı
 */