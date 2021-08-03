using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PositionsLinker
{
	class SQL
	{
		private string connectionString;
		private SqlConnection connection;
		private SqlCommand command;

		public SQL()
		{
			this.connectionString = "Data Source=sqlserver;User ID=sa;Password=icq99802122;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";
			//this.connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RequestsGenerator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			
			connection = new SqlConnection(this.connectionString); 
			connection.Open();
		}

		public SqlDataReader Execute(string command, bool isStoredProcedure = false, List<SqlParameter> parameters = null)
		{
			this.command = new SqlCommand(command, connection);
			if (isStoredProcedure == true)
			{
				this.command.CommandType = System.Data.CommandType.StoredProcedure;
				if (parameters != null)
				{
					foreach (var item in parameters)
						SetParameters(item.ParameterName, item.Value);
				}
			}
			return this.command.ExecuteReader();
		}

		private void SetParameters(string parameter, object value)
		{
			this.command.Parameters.Add(new SqlParameter(parameter, value));
		}
	}
}
