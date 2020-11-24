using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Validations
    {
        #region Methods
        /// <summary>
        /// Valida que el string ingresado sea un entero válido.
        /// </summary>
        /// <param name="strInt"></param>
        /// <returns>Retorna el numero entero ó -1 en caso de no ser un entero.</returns>
        static public int ValidateInt(string strValue)
        {
            int returnValue;

            if (int.TryParse(strValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Valida que el string ingresado sea un double válido.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna el numero double ó -1 en caso de no ser un double.</returns>
        static public double ValidateDouble(string strValue)
        {
            double returnValue;

            if (double.TryParse(strValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Valida que el string ingresado posea 2 ó mas caracteres.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna true si el string posee 2 ó mas caracteres, caso contrario retorna false.</returns>
        static public bool ValidateString(string strValue)
        {
            bool returnValue = false;

            if (strValue.Length > 1)
            {
                returnValue = true;
            }

            return returnValue;
        }
        #endregion
    }
}
