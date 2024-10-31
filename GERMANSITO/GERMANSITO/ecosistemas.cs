/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 31/10/2024
 * Time: 08:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GERMANSITO
{
	/// <summary>
	/// Description of ecosistemas.
	/// </summary>
	public partial class ecosistemas : Form
	{
		public ecosistemas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm MainForm = new MainForm();
			MainForm.Show();
			this.Hide();
		}
	}
}
