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
    
    public partial class UTILISATEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UTILISATEUR()
        {
            this.MATERIEL = new HashSet<MATERIEL>();
            this.TICKETS = new HashSet<TICKETS>();
            this.UTILISATEUR1 = new HashSet<UTILISATEUR>();
        }
    
        public int idUtilisateur { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public string telephoneUtilisateur { get; set; }
        public string mailUtilisateur { get; set; }
        public string gradeUtilisateur { get; set; }
        public int idProfil { get; set; }
        public int idUtilisateur_Autoreinscription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIEL> MATERIEL { get; set; }
        public virtual PROFIL PROFIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKETS> TICKETS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UTILISATEUR> UTILISATEUR1 { get; set; }
        public virtual UTILISATEUR UTILISATEUR2 { get; set; }
    }
}
