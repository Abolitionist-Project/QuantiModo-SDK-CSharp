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
    [DataMember(Name="displayName", EmitDefaultValue=false)]
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
    [DataMember(Name="getItUrl", EmitDefaultValue=false)]
    public string GetItUrl { get; set; }

    
    /// <summary>
    /// True if the authenticated user has this connector enabled
    /// </summary>
    /// <value>True if the authenticated user has this connector enabled</value>
    [DataMember(Name="connected", EmitDefaultValue=false)]
    public string Connected { get; set; }

    
    /// <summary>
    /// URL and parameters used when connecting to a service
    /// </summary>
    /// <value>URL and parameters used when connecting to a service</value>
    [DataMember(Name="connectInstructions", EmitDefaultValue=false)]
    public string ConnectInstructions { get; set; }

    
    /// <summary>
    /// Epoch timestamp of last sync
    /// </summary>
    /// <value>Epoch timestamp of last sync</value>
    [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
    public int? LastUpdate { get; set; }

    
    /// <summary>
    /// Number of measurements obtained during latest update
    /// </summary>
    /// <value>Number of measurements obtained during latest update</value>
    [DataMember(Name="latestData", EmitDefaultValue=false)]
    public int? LatestData { get; set; }

    
    /// <summary>
    /// True if user has no measurements for this connector
    /// </summary>
    /// <value>True if user has no measurements for this connector</value>
    [DataMember(Name="noDataYet", EmitDefaultValue=false)]
    public bool? NoDataYet { get; set; }

    

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
      
      sb.Append("  Connected: ").Append(Connected).Append("\n");
      
      sb.Append("  ConnectInstructions: ").Append(ConnectInstructions).Append("\n");
      
      sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
      
      sb.Append("  LatestData: ").Append(LatestData).Append("\n");
      
      sb.Append("  NoDataYet: ").Append(NoDataYet).Append("\n");
      
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
