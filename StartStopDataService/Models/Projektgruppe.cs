//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartStopDataService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projektgruppe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projektgruppe()
        {
            this.Ansaetze = new HashSet<ProjektgruppeLohnkategorieAnsatz>();
            this.Projekte = new HashSet<Projekt>();
        }
    
        public short Nummer { get; set; }
        public string Beschreibung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjektgruppeLohnkategorieAnsatz> Ansaetze { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projekt> Projekte { get; set; }
    }
}
