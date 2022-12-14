//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Campeonato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campeonato()
        {
            this.Inscricao = new HashSet<Inscricao>();
            this.Partida = new HashSet<Partida>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public System.DateTime Inicio { get; set; }
        public decimal Premiacao { get; set; }
        public byte[] Logo { get; set; }
        public Nullable<int> Campeao { get; set; }
    
        public virtual Clube Clube { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricao> Inscricao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partida> Partida { get; set; }
    }
}
