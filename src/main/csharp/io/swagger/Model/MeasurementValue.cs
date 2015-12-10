using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class MeasurementValue : IEquatable<MeasurementValue>
    {
        
        /// <summary>
        /// When the measurement event occurred . Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the measurement event occurred . Use ISO 8601 datetime format</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public string StartTime { get; set; }
  
        
        /// <summary>
        /// Value for the measurement
        /// </summary>
        /// <value>Value for the measurement</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }
  
        
        /// <summary>
        /// An optional note the user may include with their measurement
        /// </summary>
        /// <value>An optional note the user may include with their measurement</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementValue {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MeasurementValue);
        }

        /// <summary>
        /// Returns true if MeasurementValue instances are equal
        /// </summary>
        /// <param name="obj">Instance of MeasurementValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 57 + this.Note.GetHashCode();
                
                return hash;
            }
        }

    }
}
