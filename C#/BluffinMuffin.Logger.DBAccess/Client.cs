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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.CommandsOfClient = new HashSet<Command>();
        }
    
        public int Id { get; set; }
        public string ClientIdentification { get; set; }
        public string ImplementedProtocol { get; set; }
        public System.DateTime ClientStartedAt { get; set; }
        public string Hostname { get; set; }
        public string DisplayName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Command> CommandsOfClient { get; set; }
    }
}
