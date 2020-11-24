using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// Convierte el primer caracter de la instancia recibida por parámetro a mayúsucula.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ConvertFirstLetterToUpper(this string text)
        {
            string returnValue;

            if (!string.IsNullOrEmpty(text))
            {
                returnValue = char.ToUpper(text[0]) + text.Substring(1);
            }
            else
            {
                returnValue = string.Empty;
            }


            return returnValue;
        }
    }
}
