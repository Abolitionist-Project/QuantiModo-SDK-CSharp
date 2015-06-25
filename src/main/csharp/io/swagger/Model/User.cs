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
  public class User {
    
    /* User id */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* Wordpress user id */
    [DataMember(Name="wpId", EmitDefaultValue=false)]
    public int? WpId { get; set; }

    
    /* User display name */
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    public string DisplayName { get; set; }

    
    /* User login name */
    [DataMember(Name="loginName", EmitDefaultValue=false)]
    public string LoginName { get; set; }

    
    /* User email */
    [DataMember(Name="email", EmitDefaultValue=false)]
    public string Email { get; set; }

    
    /* User token */
    [DataMember(Name="token", EmitDefaultValue=false)]
    public string Token { get; set; }

    
    /* Is user administrator */
    [DataMember(Name="administrator", EmitDefaultValue=false)]
    public bool? Administrator { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
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

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
