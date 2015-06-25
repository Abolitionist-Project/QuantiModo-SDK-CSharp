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
  public class UserTokenRequest {
    
    
    [DataMember(Name="user", EmitDefaultValue=false)]
    public UserTokenRequestInnerUserField User { get; set; }

    
    /* Organization Access token */
    [DataMember(Name="organization_access_token", EmitDefaultValue=false)]
    public string OrganizationAccessToken { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenRequest {\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  OrganizationAccessToken: ").Append(OrganizationAccessToken).Append("\n");
      
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
