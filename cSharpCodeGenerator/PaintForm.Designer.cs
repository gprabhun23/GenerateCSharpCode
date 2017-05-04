/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 5/4/2017
 * Time: 10:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cSharpCodeGenerator
{
	partial class PaintForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button btnSelectColor1;
		private System.Windows.Forms.Button btnSelectColor2;
		private System.Windows.Forms.TextBox tbColor1;
		private System.Windows.Forms.TextBox tbColor2;
		private System.Windows.Forms.Button btnGenerateCode;
		private System.Windows.Forms.TextBox tbOutPut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbGradType;
		private System.Windows.Forms.Label label2;
		
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
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.btnSelectColor1 = new System.Windows.Forms.Button();
			this.btnSelectColor2 = new System.Windows.Forms.Button();
			this.tbColor1 = new System.Windows.Forms.TextBox();
			this.tbColor2 = new System.Windows.Forms.TextBox();
			this.btnGenerateCode = new System.Windows.Forms.Button();
			this.tbOutPut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbGradType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectColor1
			// 
			this.btnSelectColor1.Location = new System.Drawing.Point(34, 47);
			this.btnSelectColor1.Name = "btnSelectColor1";
			this.btnSelectColor1.Size = new System.Drawing.Size(108, 30);
			this.btnSelectColor1.TabIndex = 0;
			this.btnSelectColor1.Text = "Select Color1";
			this.btnSelectColor1.UseVisualStyleBackColor = true;
			this.btnSelectColor1.Click += new System.EventHandler(this.BtnSelectColor1Click);
			// 
			// btnSelectColor2
			// 
			this.btnSelectColor2.Location = new System.Drawing.Point(148, 47);
			this.btnSelectColor2.Name = "btnSelectColor2";
			this.btnSelectColor2.Size = new System.Drawing.Size(108, 30);
			this.btnSelectColor2.TabIndex = 0;
			this.btnSelectColor2.Text = "Select Color2";
			this.btnSelectColor2.UseVisualStyleBackColor = true;
			this.btnSelectColor2.Click += new System.EventHandler(this.BtnSelectColor2Click);
			// 
			// tbColor1
			// 
			this.tbColor1.Location = new System.Drawing.Point(15, 83);
			this.tbColor1.Multiline = true;
			this.tbColor1.Name = "tbColor1";
			this.tbColor1.ReadOnly = true;
			this.tbColor1.Size = new System.Drawing.Size(127, 42);
			this.tbColor1.TabIndex = 1;
			// 
			// tbColor2
			// 
			this.tbColor2.Location = new System.Drawing.Point(148, 83);
			this.tbColor2.Multiline = true;
			this.tbColor2.Name = "tbColor2";
			this.tbColor2.ReadOnly = true;
			this.tbColor2.Size = new System.Drawing.Size(127, 42);
			this.tbColor2.TabIndex = 1;
			// 
			// btnGenerateCode
			// 
			this.btnGenerateCode.Location = new System.Drawing.Point(67, 400);
			this.btnGenerateCode.Name = "btnGenerateCode";
			this.btnGenerateCode.Size = new System.Drawing.Size(165, 36);
			this.btnGenerateCode.TabIndex = 2;
			this.btnGenerateCode.Text = "Generate Code";
			this.btnGenerateCode.UseVisualStyleBackColor = true;
			// 
			// tbOutPut
			// 
			this.tbOutPut.Location = new System.Drawing.Point(15, 216);
			this.tbOutPut.Multiline = true;
			this.tbOutPut.Name = "tbOutPut";
			this.tbOutPut.Size = new System.Drawing.Size(259, 174);
			this.tbOutPut.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "RESULT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(12, 9);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "RGB Selector";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(132, 9);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(127, 24);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "SystemColor Selector";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(15, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 35);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// cbGradType
			// 
			this.cbGradType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGradType.FormattingEnabled = true;
			this.cbGradType.Location = new System.Drawing.Point(34, 159);
			this.cbGradType.Name = "cbGradType";
			this.cbGradType.Size = new System.Drawing.Size(222, 26);
			this.cbGradType.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "RESULT";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PaintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 446);
			this.Controls.Add(this.cbGradType);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenerateCode);
			this.Controls.Add(this.tbColor2);
			this.Controls.Add(this.tbOutPut);
			this.Controls.Add(this.tbColor1);
			this.Controls.Add(this.btnSelectColor2);
			this.Controls.Add(this.btnSelectColor1);
			this.MaximizeBox = false;
			this.Name = "PaintForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PAINT GRADIENT FORM";
			this.Load += new System.EventHandler(this.PaintFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
