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
  public class ConnectorInfo {
    
    /// <summary>
    /// Connector ID number
    /// </summary>
    /// <value>Connector ID number</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// True if the authenticated user has this connector enabled
    /// </summary>
    /// <value>True if the authenticated user has this connector enabled</value>
    [DataMember(Name="connected", EmitDefaultValue=false)]
    public bool? Connected { get; set; }

    
    /// <summary>
    /// Error message. Empty if connected.
    /// </summary>
    /// <value>Error message. Empty if connected.</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    
    /// <summary>
    /// Gets or Sets History
    /// </summary>
    [DataMember(Name="history", EmitDefaultValue=false)]
    public List<ConnectorInfoHistoryItem> History { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConnectorInfo {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Connected: ").Append(Connected).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  History: ").Append(History).Append("\n");
      
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
