/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 8:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace cSharpCodeGenerator
{
	/// <summary>
	/// Description of dataTableSetup.
	/// </summary>
	public partial class dataTableSetup : Form
	{
		public dataTableSetup()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TbDataTableNameEnter(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(tbDataTableName,"You Cannot Give Method Name Starting with Number...");
		}
		void TbNoOfColumnsKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled=true;
			}
		}
		void TbNoOfRowsKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled=true;
			}
		}
		
		public DataTable CreateDataTableColumn(int columnCount)
		{
			DataTable dTable=new DataTable();
			dTable.Columns.Add("Name");
			dTable.Columns.Add("DataType");
			for (int i = 0; i < columnCount; i++) {
				dTable.Rows.Add();
			}
			return dTable;
		}
		void TbNoOfColumnsLeave(object sender, EventArgs e)
		{
			if(tbNoOfColumns.Text!="")
			{
				int colCount=Convert.ToInt32(tbNoOfColumns.Text);
				dgvDataTableColumns.DataSource = CreateDataTableColumn(colCount);
			}
		}
		void TbDataTableNameKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbDataTableName.Text!="")
				{
					tbNoOfColumns.Focus();
				}
				else
				{
					tbNoOfColumns.Focus();
				}
			}
		}
	}
}
