/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 31/10/2024
 * Time: 08:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GERMANSITO
{
	partial class ECOLOGIA1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECOLOGIA1));
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(150, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 35);
			this.label4.TabIndex = 15;
			this.label4.Text = "ECOLOGIA";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(301, 136);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "ECOSISTEMAS";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(183, 137);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "CADENAS";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(53, 137);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "DEFINICION";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(301, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 33);
			this.label3.TabIndex = 11;
			this.label3.Text = "Tipos de ecosistemas (terrestres, acuáticos)\n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(183, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 33);
			this.label2.TabIndex = 10;
			this.label2.Text = "Cadenas y redes tróficas\n";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(53, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 33);
			this.label1.TabIndex = 9;
			this.label1.Text = "Definición de ecología\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-65, -11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(592, 332);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// ECOLOGIA1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 311);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ECOLOGIA1";
			this.Text = "ECOLOGIA1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
	}
}
