/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 31/10/2024
 * Time: 08:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GERMANSITO
{
	partial class ecosistemas
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "TIPOS DE ECOSISTEMAS";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(63, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 123);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ecosistema acuático\r\nEcosistema marino\r\nEcosistema de agua dulce\r\nEcosistema terr" +
			"estre\r\nBosques\r\nMatorrales\r\nHerbazales\r\nTundra\r\nDesierto";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(89, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "REGRESAR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ecosistemas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "ecosistemas";
			this.Text = "ecosistemas";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
