/*
 * Created by SharpDevelop.
 * User: CC2_PC26
 * Date: 29/10/2024
 * Time: 08:07 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GERMANSITO
{
	partial class FISICA1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FISICA1));
			this.lblNewton = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblLEY = new System.Windows.Forms.Label();
			this.lblMass = new System.Windows.Forms.Label();
			this.lblAcceleration = new System.Windows.Forms.Label();
			this.lblForce = new System.Windows.Forms.Label();
			this.lblReactionForce = new System.Windows.Forms.Label();
			this.lblActionForce = new System.Windows.Forms.Label();
			this.txtMass = new System.Windows.Forms.TextBox();
			this.txtAcceleration = new System.Windows.Forms.TextBox();
			this.txtForce = new System.Windows.Forms.TextBox();
			this.txtActionForce = new System.Windows.Forms.TextBox();
			this.txtReactionForce = new System.Windows.Forms.TextBox();
			this.btnCalculateForce = new System.Windows.Forms.Button();
			this.btnCalculateReaction = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNewton
			// 
			this.lblNewton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewton.Location = new System.Drawing.Point(12, 9);
			this.lblNewton.Name = "lblNewton";
			this.lblNewton.Size = new System.Drawing.Size(139, 23);
			this.lblNewton.TabIndex = 0;
			this.lblNewton.Text = "LEYES DE NEWTON";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(30, 36);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// lblLEY
			// 
			this.lblLEY.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLEY.Location = new System.Drawing.Point(3, 32);
			this.lblLEY.Name = "lblLEY";
			this.lblLEY.Size = new System.Drawing.Size(484, 226);
			this.lblLEY.TabIndex = 1;
			this.lblLEY.Text = resources.GetString("lblLEY.Text");
			// 
			// lblMass
			// 
			this.lblMass.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMass.Location = new System.Drawing.Point(12, 258);
			this.lblMass.Name = "lblMass";
			this.lblMass.Size = new System.Drawing.Size(100, 23);
			this.lblMass.TabIndex = 2;
			this.lblMass.Text = "MASA";
			// 
			// lblAcceleration
			// 
			this.lblAcceleration.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcceleration.Location = new System.Drawing.Point(110, 258);
			this.lblAcceleration.Name = "lblAcceleration";
			this.lblAcceleration.Size = new System.Drawing.Size(100, 23);
			this.lblAcceleration.TabIndex = 3;
			this.lblAcceleration.Text = "ACELERACION";
			// 
			// lblForce
			// 
			this.lblForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForce.Location = new System.Drawing.Point(254, 258);
			this.lblForce.Name = "lblForce";
			this.lblForce.Size = new System.Drawing.Size(100, 23);
			this.lblForce.TabIndex = 4;
			this.lblForce.Text = "FUERZA";
			// 
			// lblReactionForce
			// 
			this.lblReactionForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReactionForce.Location = new System.Drawing.Point(360, 258);
			this.lblReactionForce.Name = "lblReactionForce";
			this.lblReactionForce.Size = new System.Drawing.Size(152, 23);
			this.lblReactionForce.TabIndex = 5;
			this.lblReactionForce.Text = "FUERZA DE REACCION";
			// 
			// lblActionForce
			// 
			this.lblActionForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActionForce.Location = new System.Drawing.Point(519, 258);
			this.lblActionForce.Name = "lblActionForce";
			this.lblActionForce.Size = new System.Drawing.Size(129, 23);
			this.lblActionForce.TabIndex = 6;
			this.lblActionForce.Text = "FUERZA DE ACCION";
			// 
			// txtMass
			// 
			this.txtMass.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMass.Location = new System.Drawing.Point(13, 295);
			this.txtMass.Name = "txtMass";
			this.txtMass.Size = new System.Drawing.Size(40, 24);
			this.txtMass.TabIndex = 7;
			// 
			// txtAcceleration
			// 
			this.txtAcceleration.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAcceleration.Location = new System.Drawing.Point(110, 295);
			this.txtAcceleration.Name = "txtAcceleration";
			this.txtAcceleration.Size = new System.Drawing.Size(80, 24);
			this.txtAcceleration.TabIndex = 8;
			// 
			// txtForce
			// 
			this.txtForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtForce.Location = new System.Drawing.Point(254, 295);
			this.txtForce.Name = "txtForce";
			this.txtForce.ReadOnly = true;
			this.txtForce.Size = new System.Drawing.Size(65, 24);
			this.txtForce.TabIndex = 9;
			// 
			// txtActionForce
			// 
			this.txtActionForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtActionForce.Location = new System.Drawing.Point(531, 295);
			this.txtActionForce.Name = "txtActionForce";
			this.txtActionForce.Size = new System.Drawing.Size(100, 24);
			this.txtActionForce.TabIndex = 10;
			// 
			// txtReactionForce
			// 
			this.txtReactionForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReactionForce.Location = new System.Drawing.Point(370, 295);
			this.txtReactionForce.Name = "txtReactionForce";
			this.txtReactionForce.ReadOnly = true;
			this.txtReactionForce.Size = new System.Drawing.Size(100, 24);
			this.txtReactionForce.TabIndex = 11;
			// 
			// btnCalculateForce
			// 
			this.btnCalculateForce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalculateForce.Location = new System.Drawing.Point(124, 335);
			this.btnCalculateForce.Name = "btnCalculateForce";
			this.btnCalculateForce.Size = new System.Drawing.Size(143, 23);
			this.btnCalculateForce.TabIndex = 12;
			this.btnCalculateForce.Text = "CALCULAR FUERZA";
			this.btnCalculateForce.UseVisualStyleBackColor = true;
			this.btnCalculateForce.Click += new System.EventHandler(this.btnCalculateForce_Click);
			// 
			// btnCalculateReaction
			// 
			this.btnCalculateReaction.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalculateReaction.Location = new System.Drawing.Point(306, 335);
			this.btnCalculateReaction.Name = "btnCalculateReaction";
			this.btnCalculateReaction.Size = new System.Drawing.Size(164, 23);
			this.btnCalculateReaction.TabIndex = 13;
			this.btnCalculateReaction.Text = "CALCULAR REACCION";
			this.btnCalculateReaction.UseVisualStyleBackColor = true;
			this.btnCalculateReaction.Click += new System.EventHandler(this.btnCalculateReaction_Click);
			// 
			// FISICA1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 362);
			this.Controls.Add(this.btnCalculateReaction);
			this.Controls.Add(this.btnCalculateForce);
			this.Controls.Add(this.txtReactionForce);
			this.Controls.Add(this.txtActionForce);
			this.Controls.Add(this.txtForce);
			this.Controls.Add(this.txtAcceleration);
			this.Controls.Add(this.txtMass);
			this.Controls.Add(this.lblActionForce);
			this.Controls.Add(this.lblReactionForce);
			this.Controls.Add(this.lblForce);
			this.Controls.Add(this.lblAcceleration);
			this.Controls.Add(this.lblMass);
			this.Controls.Add(this.lblLEY);
			this.Controls.Add(this.lblNewton);
			this.Name = "FISICA1";
			this.Text = "FISICA1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalculateReaction;
		private System.Windows.Forms.Button btnCalculateForce;
		private System.Windows.Forms.TextBox txtReactionForce;
		private System.Windows.Forms.TextBox txtActionForce;
		private System.Windows.Forms.TextBox txtForce;
		private System.Windows.Forms.TextBox txtAcceleration;
		private System.Windows.Forms.TextBox txtMass;
		private System.Windows.Forms.Label lblActionForce;
		private System.Windows.Forms.Label lblReactionForce;
		private System.Windows.Forms.Label lblForce;
		private System.Windows.Forms.Label lblAcceleration;
		private System.Windows.Forms.Label lblMass;
		private System.Windows.Forms.Label lblLEY;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblNewton;
	}
}
