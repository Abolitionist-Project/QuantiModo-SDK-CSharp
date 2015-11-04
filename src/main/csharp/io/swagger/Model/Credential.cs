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
  public class Credential {
    
    /// <summary>
    /// connector_id
    /// </summary>
    /// <value>connector_id</value>
    [DataMember(Name="connector_id", EmitDefaultValue=false)]
    public int? ConnectorId { get; set; }

    
    /// <summary>
    /// attr_key
    /// </summary>
    /// <value>attr_key</value>
    [DataMember(Name="attr_key", EmitDefaultValue=false)]
    public string AttrKey { get; set; }

    
    /// <summary>
    /// attr_value
    /// </summary>
    /// <value>attr_value</value>
    [DataMember(Name="attr_value", EmitDefaultValue=false)]
    public string AttrValue { get; set; }

    
    /// <summary>
    /// created_at
    /// </summary>
    /// <value>created_at</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// updated_at
    /// </summary>
    /// <value>updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    public DateTime? UpdatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Credential {\n");
      
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      
      sb.Append("  AttrKey: ").Append(AttrKey).Append("\n");
      
      sb.Append("  AttrValue: ").Append(AttrValue).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
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
