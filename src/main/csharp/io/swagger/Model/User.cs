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
    
    /// <summary>
    /// User id
    /// </summary>
    /// <value>User id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Wordpress user id
    /// </summary>
    /// <value>Wordpress user id</value>
    [DataMember(Name="wpId", EmitDefaultValue=false)]
    public int? WpId { get; set; }

    
    /// <summary>
    /// User display name
    /// </summary>
    /// <value>User display name</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    public string DisplayName { get; set; }

    
    /// <summary>
    /// User login name
    /// </summary>
    /// <value>User login name</value>
    [DataMember(Name="loginName", EmitDefaultValue=false)]
    public string LoginName { get; set; }

    
    /// <summary>
    /// User email
    /// </summary>
    /// <value>User email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    public string Email { get; set; }

    
    /// <summary>
    /// User token
    /// </summary>
    /// <value>User token</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    public string Token { get; set; }

    
    /// <summary>
    /// Is user administrator
    /// </summary>
    /// <value>Is user administrator</value>
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
