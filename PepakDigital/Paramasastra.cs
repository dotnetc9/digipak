//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PepakDigital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paramasastra
    {
        public int ParamasastraId { get; set; }
        public string Ngoko { get; set; }
        public string Madya { get; set; }
        public string Inggil { get; set; }
        public string Indonesia { get; set; }
        public Nullable<int> KategoriId { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        public Paramasastra(int paramId,string ngoko, string madya, string inggil, string indonesia)
        {
            ParamasastraId = paramId;
            Ngoko= ngoko;
            Madya = madya;
            Inggil= inggil;
            Indonesia= indonesia;
        
        }
    }
}
