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
            Fecha fecha1 = new Fecha(12, 2012, 4, false);
            Console.WriteLine("Fecha 1: " + fecha1.ToString());
            if (fecha1.EsBisiesto())
                Console.WriteLine("El año " + fecha1.MAnyo + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha1.MAnyo + " no es bisiesto");
            //Fecha correcta, año no bisiesto
            Fecha fecha2 = new Fecha(10, 2013, 4, false);
            Console.WriteLine("Fecha 2: " + fecha2.ToString());
            //###################### JMR2122 ###############################
            if (fecha2.EsBisiesto())
                Console.WriteLine("El año " + fecha2.MAnyo + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha2.MAnyo + " no es bisiesto");
            //Fecha con valores incorrectos
            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());
            //Fecha con asignación incorrecta de valores erroneos
            Fecha fecha4 = new Fecha(); fecha4.MDia = 67;
            fecha4.MMes = 80;
            fecha4.MAnyo = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
            //MAL!!
        }
    }
}
