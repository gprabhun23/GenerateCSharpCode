/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 8:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cSharpCodeGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnGenerateDataTable;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnPaintMethod;
		
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
			this.btnGenerateDataTable = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnPaintMethod = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGenerateDataTable
			// 
			this.btnGenerateDataTable.Location = new System.Drawing.Point(12, 12);
			this.btnGenerateDataTable.Name = "btnGenerateDataTable";
			this.btnGenerateDataTable.Size = new System.Drawing.Size(202, 31);
			this.btnGenerateDataTable.TabIndex = 0;
			this.btnGenerateDataTable.Text = "Generate DataTable";
			this.btnGenerateDataTable.UseVisualStyleBackColor = true;
			this.btnGenerateDataTable.Click += new System.EventHandler(this.BtnGenerateDataTableClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(220, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(397, 293);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// btnPaintMethod
			// 
			this.btnPaintMethod.Location = new System.Drawing.Point(12, 49);
			this.btnPaintMethod.Name = "btnPaintMethod";
			this.btnPaintMethod.Size = new System.Drawing.Size(202, 31);
			this.btnPaintMethod.TabIndex = 0;
			this.btnPaintMethod.Text = "Paint Method";
			this.btnPaintMethod.UseVisualStyleBackColor = true;
			this.btnPaintMethod.Click += new System.EventHandler(this.BtnPaintMethodClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 317);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnPaintMethod);
			this.Controls.Add(this.btnGenerateDataTable);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C# CODE GENERATOR";
			this.ResumeLayout(false);

		}
	}
}
