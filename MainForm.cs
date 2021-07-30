using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		public static MainForm form = null;
		private SuppliersList suppliers = null;
		private SortedSet<string> sourcePositions = null;

		public MainForm()
		{
			InitializeComponent();

			form = this;
			suppliers = new SuppliersList();
			sourcePositions = new SortedSet<string>();

			suppliers.LoadSuppliers();
			LoadSourcePositions();
		}

		private void LoadSourcePositions()
		{
			SQL connection = new SQL();

			SqlDataReader reader = connection.Execute("PositionsLinker..GetUnlinkedPositions", true);
			while (reader.Read())
				this.sourcePositions.Add(reader["name"].ToString());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void btSkip_Click(object sender, EventArgs e)
		{

		}

		private void btLink_Click(object sender, EventArgs e)
		{

		}

		private void miUpdateIni_Click(object sender, EventArgs e)
		{

		}

		private async void miStartSearch_Click(object sender, EventArgs e)
		{
			if (cbSuppliers.SelectedIndex != -1)
			{
				cbFoundPositions.Items.Clear();
				tbCurrentPosition.Text = this.suppliers.items[cbSuppliers.SelectedIndex].positions[0].name;
				await this.suppliers.items[cbSuppliers.SelectedIndex].positions[0].FindMatches(this.sourcePositions);

				foreach(var item in this.suppliers.items[cbSuppliers.SelectedIndex].positions[0].foundMatches)
					cbFoundPositions.Items.Insert(0, "[" + item.Value.ToString("F" + 3) + "] " + item.Key);
			}
			else
				MessageBox.Show("Выберите подразделение!");
		}
	}
}
