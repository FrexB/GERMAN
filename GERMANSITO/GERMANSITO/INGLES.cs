/*
 * Created by SharpDevelop.
 * User: CC2_PC26
 * Date: 29/10/2024
 * Time: 08:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;


using System.Threading.Tasks;
using System.Windows.Forms;


namespace GERMANSITO
{
	/// <summary>
	/// Description of INGLES.
	/// </summary>
	public partial class INGLES : Form
	{
		private static readonly string subscriptionKey = "TU_CLAVE_DE_API"; // Reemplaza con tu clave
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/";
        
		public INGLES()
		{
				//
				// The InitializeComponent() call is required for Windows Forms designer support.
				//
				InitializeComponent(); 
				
				//
				// TODO: Add constructor code after the InitializeComponent() call.
				//
			
		}
			void ButtonTraducirClick(object sender, EventArgs e)
			{
				string textoEspañol = textBoxEspañol.Text;
	            string traduccion = ButtonTraducirClick(textoEspañol);
	            textBoxIngles.Text = traduccion;
			}
		}
	}
