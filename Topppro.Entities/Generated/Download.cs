//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Topppro.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Download
    {
        public int DownloadId { get; set; }
        public int CultureId { get; set; }
        public int ProductId { get; set; }
        public int PlatformId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool External { get; set; }
        public string Resource { get; set; }
        public Nullable<int> Priority { get; set; }
        public bool Enabled { get; set; }
    
        public virtual Culture Culture { get; set; }
        public virtual Platform Platform { get; set; }
        public virtual Product Product { get; set; }
    }
}
