//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssignmentPart1Take2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Results
    {
        public int Id { get; set; }
        public string FinalResult { get; set; }
        public int StudentId { get; set; }
        public int ModuleId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Module Module { get; set; }
    }
}
