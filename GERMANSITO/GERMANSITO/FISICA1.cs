/*
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
    public partial class FISICA1 : Form
    {
        public FISICA1()
        {
            InitializeComponent();
        }

        private void btnCalculateForce_Click(object sender, EventArgs e)
{
    MessageBox.Show("Calcular Fuerza botón presionado"); // Mensaje de depuración
    try
    {
        double mass = double.Parse(txtMass.Text);
        double acceleration = double.Parse(txtAcceleration.Text);
        double force = mass * acceleration;
        txtForce.Text = force.ToString("F2") + " N";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, ingresa valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void btnCalculateReaction_Click(object sender, EventArgs e)
{
    MessageBox.Show("Calcular Reacción botón presionado"); // Mensaje de depuración
    try
    {
        double actionForce = double.Parse(txtActionForce.Text);
        double reactionForce = actionForce;
        txtReactionForce.Text = reactionForce.ToString("F2") + " N";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, ingresa valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
    }
    }