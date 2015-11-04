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
  public class Connector {
    
    /// <summary>
    /// Connector ID number
    /// </summary>
    /// <value>Connector ID number</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Connector lowercase system name
    /// </summary>
    /// <value>Connector lowercase system name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Connector pretty display name
    /// </summary>
    /// <value>Connector pretty display name</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    public string DisplayName { get; set; }

    
    /// <summary>
    /// URL to the image of the connector logo
    /// </summary>
    /// <value>URL to the image of the connector logo</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    public string Image { get; set; }

    
    /// <summary>
    /// URL to a site where one can get this device or application
    /// </summary>
    /// <value>URL to a site where one can get this device or application</value>
    [DataMember(Name="get_it_url", EmitDefaultValue=false)]
    public string GetItUrl { get; set; }

    
    /// <summary>
    /// Short description
    /// </summary>
    /// <value>Short description</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    public string ShortDescription { get; set; }

    
    /// <summary>
    /// Long description
    /// </summary>
    /// <value>Long description</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    public string LongDescription { get; set; }

    
    /// <summary>
    /// enabled
    /// </summary>
    /// <value>enabled</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    public bool? Enabled { get; set; }

    
    /// <summary>
    /// oauth
    /// </summary>
    /// <value>oauth</value>
    [DataMember(Name="oauth", EmitDefaultValue=false)]
    public bool? Oauth { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Connector {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      
      sb.Append("  Image: ").Append(Image).Append("\n");
      
      sb.Append("  GetItUrl: ").Append(GetItUrl).Append("\n");
      
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      
      sb.Append("  Oauth: ").Append(Oauth).Append("\n");
      
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
