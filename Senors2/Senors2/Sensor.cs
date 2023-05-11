//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Senors2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sensor()
        {
            this.SensorReadings = new HashSet<SensorReading>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdSensorTypes { get; set; }
        public Nullable<int> IdMeasurementUnits { get; set; }
    
        public virtual MeasurementUnit MeasurementUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SensorReading> SensorReadings { get; set; }
        public virtual SensorType SensorType { get; set; }
    }
}
