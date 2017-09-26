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
    [Serializable]
    [DataContract]
    public enum Statut
    {
        NonCadre,
        Cadre,
        Commercial,
        Technicien,
        TechnicoCommercial,
        Service
    }
}