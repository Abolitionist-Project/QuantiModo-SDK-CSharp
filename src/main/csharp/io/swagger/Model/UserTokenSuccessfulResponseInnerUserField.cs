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
  public class UserTokenSuccessfulResponseInnerUserField {
    
    /* WordPress user ID */
    [DataMember(Name="_id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* User token */
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    public string AccessToken { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenSuccessfulResponseInnerUserField {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
      
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
