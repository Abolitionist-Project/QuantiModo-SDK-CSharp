using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Connector {
    

    /* Connector ID number */
    
    public int? Id { get; set; }

    

    /* Connector lowercase system name */
    
    public string Name { get; set; }

    

    /* Connector pretty display name */
    
    public string DisplayName { get; set; }

    

    /* URL to the image of the connector logo */
    
    public string Image { get; set; }

    

    /* URL to a site where one can get this device or application */
    
    public string GetItUrl { get; set; }

    

    /* True if the authenticated user has this connector enabled */
    
    public string Connected { get; set; }

    

    /* URL and parameters used when connecting to a service */
    
    public string ConnectInstructions { get; set; }

    

    /* Epoch timestamp of last sync */
    
    public int? LastUpdate { get; set; }

    

    /* Number of measurements obtained during latest update */
    
    public int? LatestData { get; set; }

    

    /* True if user has no measurements for this connector */
    
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