//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Extradition
    {
        public int id_extradition { get; set; }
        public System.DateTime extradition_date { get; set; }
        public Nullable<System.DateTime> refund_date { get; set; }
        public bool passed { get; set; }
        public Nullable<int> term { get; set; }
        public int id_readerTicket { get; set; }
        public int id_book { get; set; }
        public int id_staff { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
