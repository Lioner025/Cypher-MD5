/*
 * Created by SharpDevelop.
 * User: Lioner
 * Date: 11/08/2021
 * Time: 12:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CDM5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Cifrar;
		private System.Windows.Forms.Button GenerarC;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Cifrar = new System.Windows.Forms.Button();
			this.GenerarC = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Aqua;
			this.label1.Location = new System.Drawing.Point(122, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clave";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Aqua;
			this.label2.Location = new System.Drawing.Point(97, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "String a Trabajar";
			// 
			// Cifrar
			// 
			this.Cifrar.BackColor = System.Drawing.Color.Black;
			this.Cifrar.ForeColor = System.Drawing.Color.Aqua;
			this.Cifrar.Location = new System.Drawing.Point(34, 141);
			this.Cifrar.Name = "Cifrar";
			this.Cifrar.Size = new System.Drawing.Size(75, 23);
			this.Cifrar.TabIndex = 3;
			this.Cifrar.Text = "Cifrar";
			this.Cifrar.UseVisualStyleBackColor = false;
			this.Cifrar.Click += new System.EventHandler(this.CifrarClick);
			// 
			// GenerarC
			// 
			this.GenerarC.BackColor = System.Drawing.Color.Black;
			this.GenerarC.ForeColor = System.Drawing.Color.Aqua;
			this.GenerarC.Location = new System.Drawing.Point(34, 181);
			this.GenerarC.Name = "GenerarC";
			this.GenerarC.Size = new System.Drawing.Size(75, 23);
			this.GenerarC.TabIndex = 4;
			this.GenerarC.Text = "Generar_C";
			this.GenerarC.UseVisualStyleBackColor = false;
			this.GenerarC.Click += new System.EventHandler(this.GenerarCClick);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.ForeColor = System.Drawing.Color.Aqua;
			this.button3.Location = new System.Drawing.Point(150, 141);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Descifrar";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Black;
			this.button4.ForeColor = System.Drawing.Color.Aqua;
			this.button4.Location = new System.Drawing.Point(150, 181);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Generar_D";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Black;
			this.textBox2.ForeColor = System.Drawing.Color.Aqua;
			this.textBox2.Location = new System.Drawing.Point(89, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(81, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Creado por:                        @Lioner025  ";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Black;
			this.richTextBox1.ForeColor = System.Drawing.Color.Aqua;
			this.richTextBox1.Location = new System.Drawing.Point(89, 105);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(100, 20);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(274, 223);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.GenerarC);
			this.Controls.Add(this.Cifrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "CDM5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
