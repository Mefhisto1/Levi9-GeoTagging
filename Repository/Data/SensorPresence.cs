//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SensorPresence
    {
        public int roomId { get; set; }
        public int sensorId { get; set; }
        public System.DateTime timeSample { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual Sensor Sensor { get; set; }
    }
}