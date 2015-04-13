using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class UserTokenSuccessfulResponse {
    

    /* Status code */
    
    public int? Code { get; set; }

    

    /* Message */
    
    public string Message { get; set; }

    

    
    public UserTokenSuccessfulResponseInnerUserField User { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenSuccessfulResponse {\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}