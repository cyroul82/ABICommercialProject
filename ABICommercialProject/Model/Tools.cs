using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Model
{
    class Tools
    {
        public static Boolean IsNameValid(String name) {
            return (name.Length > 2 && !String.IsNullOrWhiteSpace(name));
        }
    }
}
