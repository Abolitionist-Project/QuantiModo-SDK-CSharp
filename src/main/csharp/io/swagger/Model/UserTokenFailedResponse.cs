using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class UserTokenFailedResponse {
    
    /* Status code */
    [DataMember(Name="code", EmitDefaultValue=false)]
    public int? Code { get; set; }

    
    /* Message */
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    
    [DataMember(Name="success", EmitDefaultValue=false)]
    public bool? Success { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenFailedResponse {\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Success: ").Append(Success).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
