//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LattesExtractor.Entities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnidadeInstituicaoEmpresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadeInstituicaoEmpresa()
        {
            this.AtividadeProfissional = new HashSet<AtividadeProfissional>();
            this.Professor = new HashSet<Professor>();
            this.Projeto = new HashSet<Projeto>();
            this.BaseDeConsulta = new HashSet<BaseDeConsulta>();
        }
    
        public int InstituicaoEmpresaId { get; set; }
        public string NomeUnidadeInstituicaoEmpresa { get; set; }
        public string LogradouroCompletoUnidadeInstituicaoEmpresa { get; set; }
        public int UnidadeInstituicaoEmpresaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AtividadeProfissional> AtividadeProfissional { get; set; }
        public virtual InstituicaoEmpresa InstituicaoEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projeto> Projeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseDeConsulta> BaseDeConsulta { get; set; }
    }
}