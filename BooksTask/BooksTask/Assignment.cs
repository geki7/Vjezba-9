//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksTask
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        public int Id { get; set; }
        public string Student { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public int IdAssignmentStatuses { get; set; }
    
        public virtual AssignmentStatus AssignmentStatus { get; set; }
    }
}
