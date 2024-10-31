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
	/// <summary>
	/// Description of MATEMATICAS.
	/// </summary>
	public partial class MATEMATICAS : Form
	{
		public MATEMATICAS()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			 Console.WriteLine("Nombre del alumno");
    string na; //nombre del alumno.
    na=Console.ReadLine();

    Console.WriteLine("Calificacion de Ecologia");
    int cal1=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Calificacion de Fisica");
    int cal2;
    cal2=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Calificacion de Humanidades");
    int cal3;
    cal3=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Calificacion de Ingles");
    int cal4;
    cal4=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Calificacion de Matematicas");
    int cal5;
    cal5=Convert.ToInt32(Console.ReadLine());

    int promedio=(cal1 + cal2 + cal3 + cal4+ cal5)/5;
    Console.WriteLine("Promedio="+promedio);

    if(promedio<6){
        Console.WriteLine("Reprobado");
    }
    else{
        if(promedio>=6){
            Console.WriteLine("Aprobado");
        }
    }

            //MAYOR Y MENOR.

    if(cal1>cal2 && cal1>cal3 && cal1>cal4 && cal1>cal5){
        Console.WriteLine("El numero mayor es"+cal1);
    }
    else if(cal2>cal1 && cal2>cal3 && cal2>cal4 && cal2>cal5){
        Console.WriteLine("El numero mayor es"+cal2);
    }
    else if(cal3>cal1 && cal3>cal2 && cal3>cal4 && cal2>cal5){
        Console.WriteLine("El numero mayor es"+cal2);
    }
    else if(cal4>cal1 && cal4>cal2 && cal4>cal3 && cal4>cal5){
        Console.WriteLine("El numero mayor es"+cal2);
    }
    else if(cal5>cal1 && cal5>cal2 && cal5>cal3 && cal2>cal4){
        Console.WriteLine("El numero mayor es"+cal2);
    }



    if(cal1<cal2 && cal1<cal3 && cal1<cal4 && cal1<cal5){
        Console.WriteLine("El numero menor es"+cal1);
    }
    else if(cal2<cal1 && cal2<cal3 && cal2<cal4 && cal2<cal5){
        Console.WriteLine("El numero menor es"+cal2);
    }
    else if(cal3<cal1 && cal3<cal2 && cal3<cal4 && cal2<cal5){
        Console.WriteLine("El numero menor es"+cal2);
    }
    else if(cal4<cal1 && cal4<cal2 && cal4<cal3 && cal4<cal5){
        Console.WriteLine("El numero menor es"+cal2);
    }
    else if(cal5<cal1 && cal5<cal2 && cal5<cal3 && cal2<cal4){
        Console.WriteLine("El numero menor es"+cal2);
    }

            //MEDIA.
    double media=(cal1+cal2+cal3+cal4+cal5)/5.0;
    Console.WriteLine("La media es"+media);

            //CANTIDAD DE REPROBADOS Y APROBADOS.
    int CantRepro = 0, CantApro = 0;
            Console.WriteLine("Nota obtenida:");
            double nota = Convert.ToDouble(Console.ReadLine());
            if (nota < 6) {
                CantRepro++;
            } else {
                CantApro++;
            }

            Console.WriteLine("Cantidad de aprobados es: " + CantApro);
            Console.WriteLine("Cantidad de reprobados es: " + CantRepro);
		}
	}
}
