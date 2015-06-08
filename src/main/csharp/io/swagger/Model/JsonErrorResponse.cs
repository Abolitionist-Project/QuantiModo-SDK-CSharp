using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class JsonErrorResponse {
    
    /* Status: \"ok\" or \"error\" */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /* Error message */
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JsonErrorResponse {\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
