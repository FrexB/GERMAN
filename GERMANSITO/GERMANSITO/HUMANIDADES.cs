﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC26
 * Date: 29/10/2024
 * Time: 08:07 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GERMANSITO
{
	/// <summary>
	/// Description of HUMANIDADES.
	/// </summary>
	public partial class HUMANIDADES : Form
	{
		public HUMANIDADES()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		
		void Label2Click(object sender, EventArgs e)
		{
			Form1 g=new Form1();
			g.Show();
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			literatura x=new literatura();
			x.Show();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			historia n=new historia();
			n.Show();
		}
	}
}
