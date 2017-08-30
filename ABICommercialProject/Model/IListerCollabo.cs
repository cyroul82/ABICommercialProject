using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Model
{
    public delegate void ActionAjouterCollabo();
    public interface IListerCollabo
    {
        Collaborateur collaboActif { get; }
        void AfficheCollabo(Collaborateur collabo);
        event ActionAjouterCollabo onAjoutCollabo;
    }
}
