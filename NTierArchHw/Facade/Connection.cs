using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NTierArchHw.Facade
{
	internal class Connection
	{
		public static SqlConnection con = new SqlConnection();

		public static void connect()
		{
			string cs = ConfigurationManager.ConnectionStrings["MyCStr"].ConnectionString;
			con.ConnectionString = cs;
			if (con.State == ConnectionState.Open) { return; }
			con.Open();
		}

		public static void disconnect()
		{
			if (con.State == ConnectionState.Closed) { return; }
			con.Close();
		}
	}
}
