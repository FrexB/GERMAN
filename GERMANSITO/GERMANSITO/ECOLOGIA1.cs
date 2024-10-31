/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 31/10/2024
 * Time: 08:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GERMANSITO
{
	/// <summary>
	/// Description of ECOLOGIA1.
	/// </summary>
	public partial class ECOLOGIA1 : Form
	{
		public ECOLOGIA1()
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
			definicion x=new definicion();
			x.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			cadenas n=new cadenas();
			n.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ecosistemas p=new ecosistemas();
				p.Show();
		}
	}
}