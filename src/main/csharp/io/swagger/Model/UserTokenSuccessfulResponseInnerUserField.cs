using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class UserTokenSuccessfulResponseInnerUserField {
    

    /* WordPress user ID */
    
    public int? Id { get; set; }

    

    /* User token */
    
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