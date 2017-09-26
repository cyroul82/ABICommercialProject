using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABIServiceLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ABIService" à la fois dans le code et le fichier de configuration.
    public class ABIService : IABIService
    {
        public string getFirstname()
        {
            return "prénom";
        }

        public string getName()
        {
            return "salut";
        }
    }
}
