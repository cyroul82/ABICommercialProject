/***********************************************************************
 * Module:  Statut.cs
 * Author:  CDI14
 * Purpose: Definition of the Enum Statut
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABIModel
{
    /// <summary>
    /// Status Enumeration
    /// </summary>
    [DataContract]
    public enum Statut
    {
        [EnumMember(Value = "NonCadre")]
        NonCadre=0,
        [EnumMember(Value = "Cadre")]
        Cadre=1,
        [EnumMember(Value = "Commercial")]
        Commercial=2,
        [EnumMember(Value = "Technicien")]
        Technicien=3,
        [EnumMember(Value = "TechnicoCommercial")]
        TechnicoCommercial=4,
        [EnumMember(Value = "Service")]
        Service=5
    }
}