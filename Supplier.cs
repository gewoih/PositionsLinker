using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionsLinker
{
	class Supplier
	{
		private SortedSet<string> sourcePositions;
		private string egaisCode;
		private string name;
		public List<Position> positions { get; set; }

		public Supplier(string egaisCode, string name, SortedSet<string> sourcePositions)
		{
			this.egaisCode = egaisCode;
			this.name = name;
			this.positions = new List<Position>();
			this.sourcePositions = sourcePositions;
		}

		public void LoadPositions()
		{
			SQL connection = new SQL();
			List<SqlParameter> parameters = new List<SqlParameter> { new SqlParameter("@code", egaisCode) };

			SqlDataReader reader = connection.Execute("PositionsLinker..GetSupplierPositions", true, parameters);
			while (reader.Read())
				this.positions.Add(new Position(reader["article"].ToString(), reader["name"].ToString()));

			this.positions[0].FindMatches(this.sourcePositions);
		}

		public Position GetPosition()
		{
			return positions[0];
		}

		public async void LoadNextPosition()
		{
			positions.RemoveAt(0);
			await Task.Run(() =>
			{
				positions[0].FindMatches(this.sourcePositions);
			});
		}
	}
}
