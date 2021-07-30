
namespace WindowsFormsApp1
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSuppliers = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCurrentPosition = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btSkip = new System.Windows.Forms.Button();
			this.btLink = new System.Windows.Forms.Button();
			this.cbFoundPositions = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miStartSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbSuppliers, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbCurrentPosition, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.btSkip, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btLink, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.cbFoundPositions, 1, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 498);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(469, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поставщик:";
			// 
			// cbSuppliers
			// 
			this.cbSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSuppliers.FormattingEnabled = true;
			this.cbSuppliers.Location = new System.Drawing.Point(270, 112);
			this.cbSuppliers.Name = "cbSuppliers";
			this.cbSuppliers.Size = new System.Drawing.Size(483, 24);
			this.cbSuppliers.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(447, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Текущая позиция:";
			// 
			// tbCurrentPosition
			// 
			this.tbCurrentPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tbCurrentPosition.Enabled = false;
			this.tbCurrentPosition.Location = new System.Drawing.Point(268, 275);
			this.tbCurrentPosition.Name = "tbCurrentPosition";
			this.tbCurrentPosition.Size = new System.Drawing.Size(487, 23);
			this.tbCurrentPosition.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(438, 393);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Найденные позиции:";
			// 
			// btSkip
			// 
			this.btSkip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSkip.Location = new System.Drawing.Point(3, 413);
			this.btSkip.Name = "btSkip";
			this.btSkip.Size = new System.Drawing.Size(250, 82);
			this.btSkip.TabIndex = 6;
			this.btSkip.Text = "Пропустить";
			this.btSkip.UseVisualStyleBackColor = true;
			this.btSkip.Click += new System.EventHandler(this.btSkip_Click);
			// 
			// btLink
			// 
			this.btLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btLink.Location = new System.Drawing.Point(771, 413);
			this.btLink.Name = "btLink";
			this.btLink.Size = new System.Drawing.Size(251, 82);
			this.btLink.TabIndex = 7;
			this.btLink.Text = "Привязать";
			this.btLink.UseVisualStyleBackColor = true;
			this.btLink.Click += new System.EventHandler(this.btLink_Click);
			// 
			// cbFoundPositions
			// 
			this.cbFoundPositions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFoundPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFoundPositions.DropDownWidth = 800;
			this.cbFoundPositions.FormattingEnabled = true;
			this.cbFoundPositions.Location = new System.Drawing.Point(268, 442);
			this.cbFoundPositions.Name = "cbFoundPositions";
			this.cbFoundPositions.Size = new System.Drawing.Size(487, 24);
			this.cbFoundPositions.TabIndex = 5;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStartSearch});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(167, 26);
			// 
			// miStartSearch
			// 
			this.miStartSearch.Name = "miStartSearch";
			this.miStartSearch.Size = new System.Drawing.Size(166, 22);
			this.miStartSearch.Text = "Начать привязку";
			this.miStartSearch.Click += new System.EventHandler(this.miStartSearch_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 498);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PositionsLinker";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btSkip;
		private System.Windows.Forms.Button btLink;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		public System.Windows.Forms.ComboBox cbSuppliers;
		public System.Windows.Forms.TextBox tbCurrentPosition;
		public System.Windows.Forms.ComboBox cbFoundPositions;
		private System.Windows.Forms.ToolStripMenuItem miStartSearch;
	}
}

