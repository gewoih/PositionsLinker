using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositionsLinker
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

			LoadSourcePositions();
			suppliers.LoadSuppliers(this.sourcePositions);
		}

		private void LoadSourcePositions()
		{
			SQL connection = new SQL();

			SqlDataReader reader = connection.Execute("PositionsLinker..GetUnlinkedPositions", true);
			while (reader.Read())
				this.sourcePositions.Add(reader["name"].ToString());
		}

		private void btSkip_Click(object sender, EventArgs e)
		{
			LoadNextPosition();
		}

		private void btLink_Click(object sender, EventArgs e)
		{

		}

		private void LoadNextPosition()
		{
			if (cbSuppliers.SelectedIndex != -1)
			{
				cbFoundPositions.Items.Clear();
				Position currentPosition = this.suppliers.items[cbSuppliers.SelectedIndex].GetPosition();

				tbCurrentPosition.Text = currentPosition.name;

				foreach (var item in currentPosition.foundMatches)
					cbFoundPositions.Items.Insert(0, "[" + item.Value.ToString("F" + 3) + "] " + item.Key);

				if (cbFoundPositions.Items.Count > 0)
					cbFoundPositions.SelectedIndex = 0;
				this.suppliers.items[cbSuppliers.SelectedIndex].LoadNextPosition();
			}
			else
				MessageBox.Show("Выберите подразделение!");
		}

		private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.suppliers.items[cbSuppliers.SelectedIndex].LoadPositions();
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.NumPad0)
				LoadNextPosition();
			if (e.KeyData == Keys.NumPad1)
				MessageBox.Show("Позиция успешно привязана!");
		}
	}
}
