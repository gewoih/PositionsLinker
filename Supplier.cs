using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Supplier
	{
		private string egaisCode;
		private string name;
		public List<Position> positions { get; set; }

		public Supplier(string egaisCode, string name)
		{
			this.egaisCode = egaisCode;
			this.name = name;
			this.positions = new List<Position>();
		}

		public void LoadPositions()
		{
			SQL connection = new SQL();
			List<SqlParameter> parameters = new List<SqlParameter> { new SqlParameter("@code", egaisCode) };

			SqlDataReader reader = connection.Execute("PositionsLinker..GetSupplierPositions", true, parameters);
			while (reader.Read())
				this.positions.Add(new Position(reader["article"].ToString(), reader["name"].ToString()));
		}
	}
}
