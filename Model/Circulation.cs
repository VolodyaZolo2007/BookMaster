//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMaster.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Circulation
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string CustomerId { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public System.DateTime DateOfReturn { get; set; }
        public int AdministratorId { get; set; }
        public bool IsBookReturned { get; set; }
    
        public virtual Administrator Administrator { get; set; }
        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
