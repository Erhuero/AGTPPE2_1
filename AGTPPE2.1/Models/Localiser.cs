//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGTPPE2._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Localiser
    {
        public int idCelllule { get; set; }
        public int idTicket { get; set; }
        public string numeroSerieMateriel { get; set; }
    
        public virtual CELLULE CELLULE { get; set; }
        public virtual MATERIEL MATERIEL { get; set; }
        public virtual TICKETS TICKETS { get; set; }
    }
}
