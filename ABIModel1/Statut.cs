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
        [EnumMember]
        NonCadre,
        [EnumMember]
        Cadre,
        [EnumMember]
        Commercial,
        [EnumMember]
        Technicien,
        [EnumMember]
        TechnicoCommercial,
        [EnumMember]
        Service
    }
}