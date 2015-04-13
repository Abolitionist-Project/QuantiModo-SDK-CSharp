using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class User {
    

    /* User id */
    
    public int? Id { get; set; }

    

    /* Wordpress user id */
    
    public int? WpId { get; set; }

    

    /* User display name */
    
    public string DisplayName { get; set; }

    

    /* User login name */
    
    public string LoginName { get; set; }

    

    /* User email */
    
    public string Email { get; set; }

    

    /* User token */
    
    public string Token { get; set; }

    

    /* Is user administrator */
    
    public bool? Administrator { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  WpId: ").Append(WpId).Append("\n");
      
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      
      sb.Append("  LoginName: ").Append(LoginName).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  Token: ").Append(Token).Append("\n");
      
      sb.Append("  Administrator: ").Append(Administrator).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}