﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Futjalma
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FutjalmaEntities : DbContext
    {
        public FutjalmaEntities()
            : base("name=FutjalmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Campeonato> Campeonato { get; set; }
        public virtual DbSet<Clube> Clube { get; set; }
        public virtual DbSet<Contratacao> Contratacao { get; set; }
        public virtual DbSet<Inscricao> Inscricao { get; set; }
        public virtual DbSet<Jogador> Jogador { get; set; }
        public virtual DbSet<Partida> Partida { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
