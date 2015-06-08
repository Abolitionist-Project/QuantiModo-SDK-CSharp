using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class UserTokenRequest {
    
    
    [DataMember(Name="user", EmitDefaultValue=false)]
    public UserTokenRequestInnerUserField User { get; set; }

    
    /* Organization Access token */
    [DataMember(Name="organization_access_token", EmitDefaultValue=false)]
    public string OrganizationAccessToken { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenRequest {\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  OrganizationAccessToken: ").Append(OrganizationAccessToken).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
