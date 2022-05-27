/*
 * Created by SharpDevelop.
 * User: Muhammet Sarioglu
 * Date: 5-11-2013
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CheatTool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.MoveForm = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(609, 348);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// MoveForm
			// 
			this.MoveForm.BackColor = System.Drawing.Color.Gainsboro;
			this.MoveForm.Location = new System.Drawing.Point(0, 0);
			this.MoveForm.Name = "MoveForm";
			this.MoveForm.Size = new System.Drawing.Size(10, 10);
			this.MoveForm.TabIndex = 1;
			this.MoveForm.Click += new System.EventHandler(this.MoveFormClick);
			this.MoveForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoveMouseClick);
			this.MoveForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDoubleClick);
			this.MoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveMouseDown);
			this.MoveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveMouseMove);
			this.MoveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveMouseUp);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10"});
			this.comboBox1.Location = new System.Drawing.Point(12, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(24, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox1KeyDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 361);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.MoveForm);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label MoveForm;
		private System.Windows.Forms.RichTextBox richTextBox1;

	}
}
