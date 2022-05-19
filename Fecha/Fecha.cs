using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    public class Fecha
    {
        // ################################### JMR2122 #####################################
        public int mDia;
        public int mMes;
        public int mAnyo;
        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            mDia = 1;
            mMes = 1;
            mAnyo = 1;
        }
        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        // ########################################### JMR2122 ##############################
        public Fecha(int mes, int anyo, int dia, bool bi)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                this.mAnyo = anyo;
            }
            else
            {
                this.mAnyo = 1;
            }
            bool bisiesto;
            if ((mAnyo % 400 == 0) || ((mAnyo % 4 == 0) && (mAnyo % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            if (mes >= 1 && mes <= 12)
                this.mMes = mes;
            else
                this.mMes = 1;
            int diasMes = 0;
            switch (mMes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                case 2: // verificación de año bisiesto
                    if (bisiesto)
                        diasMes = 29;
                    else diasMes = 28;
                    break;
            }
            if (dia >= 1 && dia <= diasMes)
                this.mDia = dia;
            else
                this.mDia = 1;
        }
        //################################ JMR2122 ##########################################
        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((mAnyo % 400 == 0) || ((mAnyo % 4 == 0) && (mAnyo % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }
        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> 
        public override string ToString()
        {
            return mDia + "/" + mMes + "/" + mAnyo;
        }
    }
}
