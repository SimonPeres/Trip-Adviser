//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trip_Adviser
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEATHER
    {
        public int WeatherId { get; set; }
        public int PlacePlaceId { get; set; }
        public Nullable<int> Jan { get; set; }
        public Nullable<int> Feb { get; set; }
        public Nullable<int> Mar { get; set; }
        public Nullable<int> Apr { get; set; }
        public Nullable<int> May { get; set; }
        public Nullable<int> June { get; set; }
        public Nullable<int> July { get; set; }
        public Nullable<int> Aug { get; set; }
        public Nullable<int> Sep { get; set; }
        public Nullable<int> Oct { get; set; }
        public Nullable<int> Nov { get; set; }
        public Nullable<int> Dcm { get; set; }
        public string WeatherDesc { get; set; }
        public Nullable<int> WeatherAvg { get; set; }
    
        public virtual PLACE PLACE { get; set; }
    }
}
