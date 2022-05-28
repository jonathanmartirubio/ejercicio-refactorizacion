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
        private int mDia;
        private int mMes;
        private int mAnyo;

        public int MDia
        {
            get
            {
                return mDia;
            }
        }
        // ########################### JMR2122 #############################################
        public int MMes
        {
            get
            {
                return mMes;
            }
        }
        // ####################### JMR2122 ###################################
        public int MAnyo
        {
            get
            {
                return mAnyo;
            }
        }

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        // ######################### JMR2122 ##########################
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
        /// 
        // ########################################### JMR2122 ##############################
        public Fecha(int mes, int anyo, int dia)
        {
            SetFecha(mes, anyo, dia);
        }

        public void SetFecha(int mes, int anyo, int dia)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                mAnyo = anyo;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Año");
            }
            // ################## JMR2122 ####################
            if (mes >= 1 && mes <= 12)
                mMes = mes;
            else
            {
                throw new ArgumentOutOfRangeException("Mes");
            }

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
                    if (EsBisiesto())
                        diasMes = 29;
                    else diasMes = 28;
                    break;
            }
            if (dia >= 1 && dia <= diasMes)
                mDia = dia;
            else
            {
                throw new ArgumentOutOfRangeException("Día");
            }
        }

        //################################ JMR2122 ##########################################
        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((MAnyo % 400 == 0) || ((MAnyo % 4 == 0) && (MAnyo % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }
        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> 
        // ################### JMR2122 #################################
        public override string ToString()
        {
            return MDia + "/" + MMes + "/" + MAnyo;
        }
    }
}
