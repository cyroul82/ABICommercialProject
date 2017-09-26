using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIModel
{
    /// <summary>
    /// Contract Type Enumeration
    /// </summary>
    [Serializable]
    [DataContract]
    public enum TypeContrat
    {
        CDI,
        CDD,
        Interim,
        Stage
    }
}
