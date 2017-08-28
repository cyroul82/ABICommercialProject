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
        /// Check if the name length > 1  and that the name isn't null or empty
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

        /// <summary>
        /// Convert the first letter in Uppercase
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String firstLetterUppercase(String s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        /// <summary>
        /// Convert a string into a Enum Statut
        /// </summary>
        /// <param name="statut"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Cannot Convert the string into a Statut Enum</exception>
        public static Statut getStatut(String statut)
        {
            Statut theStatut;
            if(Enum.TryParse(statut, out theStatut))
            {
                return theStatut;
            }
            else
            {
                throw new Exception("Error statut, can't convert the string into a known statut");
            }
        }
        /// <summary>
        /// Convert the string into a Decimal
        /// </summary>
        /// <param name="salaire"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Cannot convert into Decimal</exception>
        public static Decimal getSalaireBrut(String salaire)
        {
            Decimal theSalaire;
            if(Decimal.TryParse(salaire, out theSalaire))
            {
                return theSalaire;
            }
            else
            {
                throw new Exception("Error salaire, can't convert into a decimal");
            }
        }

        /// <summary>
        /// Convert the string into a Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Cannot convert the date into a DateTime</exception>
        public static DateTime getDate(string date)
        {
            DateTime theDate;
            if (DateTime.TryParse(date, out theDate))
            {
                return theDate;
            }
            else throw new Exception("the date can't be converted to a proper DateTime");
        }

        public static Boolean isDateGreaterThanTodayDate(DateTime date)
        {
            return date >= DateTime.Now;
        }
    }
}
