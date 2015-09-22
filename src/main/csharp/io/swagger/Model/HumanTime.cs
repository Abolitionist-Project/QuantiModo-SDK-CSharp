using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class HumanTime {
    
    /// <summary>
    /// date time
    /// </summary>
    /// <value>date time</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    public string Date { get; set; }

    
    /// <summary>
    /// Gets or Sets TimezoneType
    /// </summary>
    [DataMember(Name="timezone_type", EmitDefaultValue=false)]
    public int? TimezoneType { get; set; }

    
    /// <summary>
    /// timezone of date time
    /// </summary>
    /// <value>timezone of date time</value>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    public string Timezone { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HumanTime {\n");
      
      sb.Append("  Date: ").Append(Date).Append("\n");
      
      sb.Append("  TimezoneType: ").Append(TimezoneType).Append("\n");
      
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
