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
  public class Vote {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    public string ClientId { get; set; }

    
    /// <summary>
    /// ID of User
    /// </summary>
    /// <value>ID of User</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    public int? UserId { get; set; }

    
    /// <summary>
    /// ID of cause variable
    /// </summary>
    /// <value>ID of cause variable</value>
    [DataMember(Name="cause_id", EmitDefaultValue=false)]
    public int? CauseId { get; set; }

    
    /// <summary>
    /// ID of effect variable
    /// </summary>
    /// <value>ID of effect variable</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    public int? EffectId { get; set; }

    
    /// <summary>
    /// Value of Vote
    /// </summary>
    /// <value>Value of Vote</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public int? Value { get; set; }

    
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
      sb.Append("class Vote {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  CauseId: ").Append(CauseId).Append("\n");
      
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
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
