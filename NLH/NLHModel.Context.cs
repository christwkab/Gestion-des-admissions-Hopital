﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NLHEntities1 : DbContext
    {
        public NLHEntities1()
            : base("name=NLHEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chambre> Chambres { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<FichierAdmission> FichierAdmissions { get; set; }
        public virtual DbSet<Lit> Lits { get; set; }
        public virtual DbSet<Medecien> Medeciens { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeChambre> TypeChambres { get; set; }
    }
}
