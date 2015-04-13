using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class UserTokenFailedResponse {
    

    /* Status code */
    
    public int? Code { get; set; }

    

    /* Message */
    
    public string Message { get; set; }

    

    
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