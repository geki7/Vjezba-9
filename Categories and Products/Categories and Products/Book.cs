//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Categories_and_Products
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumOfPages { get; set; }
        public string MainAuthor { get; set; }
        public int IdGenres { get; set; }
    
        public virtual Genre Genre { get; set; }
    }
}
