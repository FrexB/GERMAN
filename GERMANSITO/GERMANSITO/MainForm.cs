/*
 * Created by SharpDevelop.
 * User: CC2_PC26
 * Date: 29/10/2024
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GERMANSITO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			FISICA1 f=new FISICA1();
			f.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			ECOLOGIA s=new ECOLOGIA();
			s.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			HUMANIDADES x=new HUMANIDADES();
			x.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			INGLES g=new INGLES();
			g.Show();
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			MATEMATICAS z=new MATEMATICAS();
			z.Show();
		}
	}
}
