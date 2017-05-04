/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 8:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cSharpCodeGenerator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnGenerateDataTableClick(object sender, EventArgs e)
		{
			dataTableSetup dts=new dataTableSetup();
			dts.ShowDialog();
		}
		void BtnPaintMethodClick(object sender, EventArgs e)
		{
			PaintForm dts=new PaintForm();
			dts.ShowDialog();
		}
	}
}
