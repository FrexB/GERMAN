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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSpanish = new System.Windows.Forms.TextBox();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.txtEnglish = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-52, -33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(480, 403);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(5, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "INGRESE TEXTO EN ESPAÑOL:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "TRADUCCION A INGLES";
			// 
			// txtSpanish
			// 
			this.txtSpanish.Location = new System.Drawing.Point(5, 85);
			this.txtSpanish.Multiline = true;
			this.txtSpanish.Name = "txtSpanish";
			this.txtSpanish.Size = new System.Drawing.Size(347, 53);
			this.txtSpanish.TabIndex = 7;
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(5, 144);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(105, 23);
			this.btnTranslate.TabIndex = 8;
			this.btnTranslate.Text = "TRADUCIR\r\n";
			this.btnTranslate.UseVisualStyleBackColor = true;

			// 
			// txtEnglish
			// 
			this.txtEnglish.Location = new System.Drawing.Point(5, 233);
			this.txtEnglish.Multiline = true;
			this.txtEnglish.Name = "txtEnglish";
			this.txtEnglish.Size = new System.Drawing.Size(363, 79);
			this.txtEnglish.TabIndex = 9;
			// 
			// INGLES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 342);
			this.Controls.Add(this.txtEnglish);
			this.Controls.Add(this.btnTranslate);
			this.Controls.Add(this.txtSpanish);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "INGLES";
			this.Text = "INGLES";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtEnglish;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.TextBox txtSpanish;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
