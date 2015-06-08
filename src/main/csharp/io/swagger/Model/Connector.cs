using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class Connector {
    
    /* Connector ID number */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* Connector lowercase system name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Connector pretty display name */
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    public string DisplayName { get; set; }

    
    /* URL to the image of the connector logo */
    [DataMember(Name="image", EmitDefaultValue=false)]
    public string Image { get; set; }

    
    /* URL to a site where one can get this device or application */
    [DataMember(Name="getItUrl", EmitDefaultValue=false)]
    public string GetItUrl { get; set; }

    
    /* True if the authenticated user has this connector enabled */
    [DataMember(Name="connected", EmitDefaultValue=false)]
    public string Connected { get; set; }

    
    /* URL and parameters used when connecting to a service */
    [DataMember(Name="connectInstructions", EmitDefaultValue=false)]
    public string ConnectInstructions { get; set; }

    
    /* Epoch timestamp of last sync */
    [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
    public int? LastUpdate { get; set; }

    
    /* Number of measurements obtained during latest update */
    [DataMember(Name="latestData", EmitDefaultValue=false)]
    public int? LatestData { get; set; }

    
    /* True if user has no measurements for this connector */
    [DataMember(Name="noDataYet", EmitDefaultValue=false)]
    public bool? NoDataYet { get; set; }

    
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
  }
  
  
}
