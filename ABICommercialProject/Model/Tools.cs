using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Model
{
    class Tools
    {
        /// <summary>
        /// Check if the name length > 1  and name isn't null or empty
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True or false</returns>
        public static Boolean IsNameValid(String name) {
            return (name.Length > 1 && !String.IsNullOrWhiteSpace(name));
        }

        /// <summary>
        /// Check if the name contains only letter
        /// Return true if all letter, false otherwise
        /// </summary>
        /// <param name="name"></param> 
        /// <returns></returns>
        public static Boolean isNameOnlyChar(String name)
        {
            return name.All(Char.IsLetter);
        }

        /// <summary>
        /// Convert the name in uppercase and trim it
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static String nameToUpperAndTrim(String name)
        {
            return name.ToUpper().Trim();
        }
    }
}
