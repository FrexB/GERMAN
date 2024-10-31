/*
 * Created by SharpDevelop.
 * User: CC2_PC26
 * Date: 29/10/2024
 * Time: 08:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GERMANSITO
{
	partial class INGLES
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INGLES));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxEspañol = new System.Windows.Forms.TextBox();
			this.buttonTraducir = new System.Windows.Forms.Button();
			this.textBoxIngles = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-61, -34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(477, 355);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxEspañol
			// 
			this.textBoxEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEspañol.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.textBoxEspañol.Location = new System.Drawing.Point(12, 96);
			this.textBoxEspañol.Multiline = true;
			this.textBoxEspañol.Name = "textBoxEspañol";
			this.textBoxEspañol.Size = new System.Drawing.Size(103, 73);
			this.textBoxEspañol.TabIndex = 1;
			this.textBoxEspañol.Text = "Ingrese texto a traducir";
		
			// 
			// buttonTraducir
			// 
			this.buttonTraducir.Location = new System.Drawing.Point(130, 241);
			this.buttonTraducir.Name = "buttonTraducir";
			this.buttonTraducir.Size = new System.Drawing.Size(98, 33);
			this.buttonTraducir.TabIndex = 2;
			this.buttonTraducir.Text = "Traducir";
			this.buttonTraducir.UseVisualStyleBackColor = true;
			this.buttonTraducir.Click += new System.EventHandler(this.ButtonTraducirClick);
			// 
			// textBoxIngles
			// 
			this.textBoxIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIngles.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.textBoxIngles.Location = new System.Drawing.Point(242, 96);
			this.textBoxIngles.Multiline = true;
			this.textBoxIngles.Name = "textBoxIngles";
			this.textBoxIngles.Size = new System.Drawing.Size(100, 73);
			this.textBoxIngles.TabIndex = 3;
			this.textBoxIngles.Text = "Texto Traducido";
		
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(130, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 35);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ingles";
			// 
			// INGLES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 286);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxIngles);
			this.Controls.Add(this.buttonTraducir);
			this.Controls.Add(this.textBoxEspañol);
			this.Controls.Add(this.pictureBox1);
			this.Name = "INGLES";
			this.Text = "INGLES";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxIngles;
		private System.Windows.Forms.Button buttonTraducir;
		private System.Windows.Forms.TextBox textBoxEspañol;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
