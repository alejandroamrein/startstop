﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dialogTimeEntities : DbContext
    {
        public dialogTimeEntities()
            : base("name=dialogTimeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProjektgruppeLohnkategorieAnsatz> ProjektgruppeLohnkategorieAnsaetze { get; set; }
        public virtual DbSet<Lohnkategorie> Lohnkategorien { get; set; }
        public virtual DbSet<MandantProjektZuordnung> MandantProjektZuordnungen { get; set; }
        public virtual DbSet<Mitarbeiter> Personal { get; set; }
        public virtual DbSet<Projekt> Projekte { get; set; }
        public virtual DbSet<ProjektLohnkategorieZuordnung> ProjektLohnkategorieZuordnungen { get; set; }
        public virtual DbSet<RapportEintrag> RapportEintraege { get; set; }
        public virtual DbSet<StartStop> StartStops { get; set; }
        public virtual DbSet<Tarifkategorie> Tarifkategorien { get; set; }
        public virtual DbSet<Projektgruppe> Projektgruppen { get; set; }
    }
}
