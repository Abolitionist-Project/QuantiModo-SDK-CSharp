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
  public class CommonResponse {
    
    /// <summary>
    /// Status code
    /// </summary>
    /// <value>Status code</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public int? Status { get; set; }

    
    /// <summary>
    /// Message
    /// </summary>
    /// <value>Message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [DataMember(Name="success", EmitDefaultValue=false)]
    public bool? Success { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonResponse {\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Success: ").Append(Success).Append("\n");
      
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
