using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	class SuppliersList
	{
		public List<Supplier> items { get; set; }

		public SuppliersList()
		{
			items = new List<Supplier>();
		}

		public void LoadSuppliers()
		{
			SQL connection = new SQL();

			SqlDataReader reader = connection.Execute("PositionsLinker..GetSuppliers");
			while (reader.Read())
			{
				Supplier newSupplier = new Supplier(reader["egais_code"].ToString(), reader["name"].ToString());
				newSupplier.LoadPositions();
				items.Add(newSupplier);

				MainForm.form.cbSuppliers.Items.Add("[" + reader["egais_code"].ToString() + "] " + reader["name"].ToString());
			}
		}

		public void AddSupplier(Supplier newSupplier)
		{
			this.items.Add(newSupplier);
		}
	}
}
