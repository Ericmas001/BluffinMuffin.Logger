//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluffinMuffin.Logger.DBAccess
{
    using System;
    using System.Collections.Generic;
    
    internal partial class GameEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GameEntity()
        {
            this.CommandsOfGame = new HashSet<CommandEntity>();
        }
    
        public int Id { get; set; }
        public int TableParamId { get; set; }
        public System.DateTime GameStartedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<CommandEntity> CommandsOfGame { get; set; }
        internal virtual TableParamEntity TableParam { get; set; }
    }
}