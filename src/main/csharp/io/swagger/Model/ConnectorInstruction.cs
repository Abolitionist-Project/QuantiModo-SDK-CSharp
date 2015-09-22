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
  public class ConnectorInstruction {
    
    /// <summary>
    /// url
    /// </summary>
    /// <value>url</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    public string Url { get; set; }

    
    /// <summary>
    /// parameters array
    /// </summary>
    /// <value>parameters array</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    public List<string> Parameters { get; set; }

    
    /// <summary>
    /// usePopup
    /// </summary>
    /// <value>usePopup</value>
    [DataMember(Name="usePopup", EmitDefaultValue=false)]
    public bool? UsePopup { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConnectorInstruction {\n");
      
      sb.Append("  Url: ").Append(Url).Append("\n");
      
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      
      sb.Append("  UsePopup: ").Append(UsePopup).Append("\n");
      
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
