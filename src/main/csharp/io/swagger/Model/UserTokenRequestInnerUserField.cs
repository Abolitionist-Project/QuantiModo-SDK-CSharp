using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class UserTokenRequestInnerUserField {
    
    /* WordPress user ID */
    [DataMember(Name="_id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenRequestInnerUserField {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
