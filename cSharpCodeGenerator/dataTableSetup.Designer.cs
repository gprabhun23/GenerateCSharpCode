/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 8:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cSharpCodeGenerator
{
	partial class dataTableSetup
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDataTableName;
		private System.Windows.Forms.TextBox tbNoOfColumns;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbNoOfRows;
		private System.Windows.Forms.DataGridView dgvDataTableColumns;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColDataType;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDataTableName = new System.Windows.Forms.TextBox();
			this.tbNoOfColumns = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbNoOfRows = new System.Windows.Forms.TextBox();
			this.dgvDataTableColumns = new System.Windows.Forms.DataGridView();
			this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvDataTableColumns)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DataTable Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbDataTableName
			// 
			this.tbDataTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDataTableName.Location = new System.Drawing.Point(141, 18);
			this.tbDataTableName.Name = "tbDataTableName";
			this.tbDataTableName.Size = new System.Drawing.Size(285, 24);
			this.tbDataTableName.TabIndex = 1;
			this.toolTip1.SetToolTip(this.tbDataTableName, "You Cannot Start MethodName With Numbers....");
			this.tbDataTableName.Enter += new System.EventHandler(this.TbDataTableNameEnter);
			this.tbDataTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbDataTableNameKeyDown);
			// 
			// tbNoOfColumns
			// 
			this.tbNoOfColumns.Location = new System.Drawing.Point(141, 61);
			this.tbNoOfColumns.Name = "tbNoOfColumns";
			this.tbNoOfColumns.Size = new System.Drawing.Size(71, 20);
			this.tbNoOfColumns.TabIndex = 2;
			this.tbNoOfColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNoOfColumnsKeyPress);
			this.tbNoOfColumns.Leave += new System.EventHandler(this.TbNoOfColumnsLeave);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "No. of Columns";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "No. of Rows";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbNoOfRows
			// 
			this.tbNoOfRows.Location = new System.Drawing.Point(141, 98);
			this.tbNoOfRows.Name = "tbNoOfRows";
			this.tbNoOfRows.Size = new System.Drawing.Size(71, 20);
			this.tbNoOfRows.TabIndex = 2;
			this.tbNoOfRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNoOfRowsKeyPress);
			// 
			// dgvDataTableColumns
			// 
			this.dgvDataTableColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDataTableColumns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvDataTableColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataTableColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ColName,
			this.ColDataType});
			this.dgvDataTableColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDataTableColumns.Location = new System.Drawing.Point(3, 16);
			this.dgvDataTableColumns.Name = "dgvDataTableColumns";
			this.dgvDataTableColumns.RowHeadersVisible = false;
			this.dgvDataTableColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDataTableColumns.Size = new System.Drawing.Size(255, 294);
			this.dgvDataTableColumns.TabIndex = 3;
			// 
			// ColName
			// 
			this.ColName.HeaderText = "Name";
			this.ColName.Name = "ColName";
			// 
			// ColDataType
			// 
			this.ColDataType.HeaderText = "Data Type";
			this.ColDataType.Items.AddRange(new object[] {
			"STRING",
			"CHAR",
			"INT",
			"FLOAT",
			"DOUBLE",
			"LONG",
			"BOOL"});
			this.ColDataType.MaxDropDownItems = 15;
			this.ColDataType.Name = "ColDataType";
			this.ColDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvDataTableColumns);
			this.groupBox1.Location = new System.Drawing.Point(443, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(261, 313);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// toolTip1
			// 
			this.toolTip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.toolTip1.IsBalloon = true;
			// 
			// dataTableSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 344);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbNoOfRows);
			this.Controls.Add(this.tbNoOfColumns);
			this.Controls.Add(this.tbDataTableName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "dataTableSetup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DATATABLE SETUP";
			((System.ComponentModel.ISupportInitialize)(this.dgvDataTableColumns)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
