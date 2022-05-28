using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            //####################### JMR2122 ##############################
            //Fecha correcta, año bisiesto
            Fecha fecha1 = new Fecha(12, 2012, 4);
            Console.WriteLine("Fecha 1: " + fecha1.ToString());
            if (fecha1.EsBisiesto())
                Console.WriteLine("El año " + fecha1.MAnyo + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha1.MAnyo + " no es bisiesto");
            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha(10, 2013, 4);
            Console.WriteLine("Fecha 2: " + fecha2.ToString());
            //###################### JMR2122 ###############################
            if (fecha2.EsBisiesto())
                Console.WriteLine("El año " + fecha2.MAnyo + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha2.MAnyo + " no es bisiesto");
            //Fecha con valores incorrectos
            try
            {
                Fecha fecha3 = new Fecha(13, -4, 4);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Fecha Incorrecta: " + e.Message.ToString());
            }
            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha();

            try
            {
                fecha4.SetFecha(80, 3678, 67);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Fecha Incorrecta: " + e.Message.ToString());
            }
        }
    }
}
