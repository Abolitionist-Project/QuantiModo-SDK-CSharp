using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class UserTokenSuccessfulResponseInnerUserField {
    
    /* WordPress user ID */
    [DataMember(Name="_id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* User token */
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    public string AccessToken { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenSuccessfulResponseInnerUserField {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
