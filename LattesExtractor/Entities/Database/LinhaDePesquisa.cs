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
    
    public partial class LinhaDePesquisa
    {
        public int ProfessorId { get; set; }
        public int SequenciaLinhaDePesquisa { get; set; }
        public int PalavraChaveId { get; set; }
        public string TituloLinhaDePesquisa { get; set; }
        public string ObjetivosLinhaDePesquisa { get; set; }
        public bool AtivaLinhaDePesquisa { get; set; }
    
        public virtual PalavraChave PalavraChave { get; set; }
        public virtual Professor Professor { get; set; }
    }
}