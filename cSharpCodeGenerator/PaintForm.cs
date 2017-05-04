/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 10:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace cSharpCodeGenerator
{
	/// <summary>
	/// Description of PaintForm.
	/// </summary>
	public partial class PaintForm : Form
	{
		public PaintForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void BtnSelectColor1Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			tbColor1.BackColor=colorDialog1.Color;
			tbOutPut.Paint+=new PaintEventHandler(OnThis_Paint);
		}
		void BtnSelectColor2Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			tbColor2.BackColor=colorDialog1.Color;
			tbOutPut.Paint+=new PaintEventHandler(OnThis_Paint);
		}
		void PaintFormLoad(object sender, EventArgs e)
		{
			//this.Paint+=new PaintEventHandler(OnThis_Paint);
		}
		void OnThis_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
			Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromName(tbColor1.BackColor.Name), Color.FromName(tbColor2.BackColor.Name),LinearGradientMode.Vertical);
			graphics.FillRectangle(b, gradient_rectangle);
		}

		
	}
}
