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
  public class Correlation {
    
    /// <summary>
    /// Pearson correlation coefficient between cause and effect measurements
    /// </summary>
    /// <value>Pearson correlation coefficient between cause and effect measurements</value>
    [DataMember(Name="correlationCoefficient", EmitDefaultValue=false)]
    public double? CorrelationCoefficient { get; set; }

    
    /// <summary>
    /// ORIGINAL variable name of the cause variable for which the user desires correlations.
    /// </summary>
    /// <value>ORIGINAL variable name of the cause variable for which the user desires correlations.</value>
    [DataMember(Name="cause", EmitDefaultValue=false)]
    public string Cause { get; set; }

    
    /// <summary>
    /// ORIGINAL variable name of the effect variable for which the user desires correlations.
    /// </summary>
    /// <value>ORIGINAL variable name of the effect variable for which the user desires correlations.</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    public string Effect { get; set; }

    
    /// <summary>
    /// User estimated or default time after cause measurement before a perceivable effect is observed
    /// </summary>
    /// <value>User estimated or default time after cause measurement before a perceivable effect is observed</value>
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    public double? OnsetDelay { get; set; }

    
    /// <summary>
    /// Time over which the cause is expected to produce a perceivable effect following the onset delay
    /// </summary>
    /// <value>Time over which the cause is expected to produce a perceivable effect following the onset delay</value>
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    public double? DurationOfAction { get; set; }

    
    /// <summary>
    /// Number of points that went into the correlation calculation
    /// </summary>
    /// <value>Number of points that went into the correlation calculation</value>
    [DataMember(Name="numberOfPairs", EmitDefaultValue=false)]
    public double? NumberOfPairs { get; set; }

    
    /// <summary>
    /// Magnitude of the effects of a cause indicating whether it's practically meaningful.
    /// </summary>
    /// <value>Magnitude of the effects of a cause indicating whether it's practically meaningful.</value>
    [DataMember(Name="effectSize", EmitDefaultValue=false)]
    public string EffectSize { get; set; }

    
    /// <summary>
    /// A function of the effect size and sample size
    /// </summary>
    /// <value>A function of the effect size and sample size</value>
    [DataMember(Name="statisticalSignificance", EmitDefaultValue=false)]
    public string StatisticalSignificance { get; set; }

    
    /// <summary>
    /// Time at which correlation was calculated
    /// </summary>
    /// <value>Time at which correlation was calculated</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    public double? Timestamp { get; set; }

    
    /// <summary>
    /// Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation.
    /// </summary>
    /// <value>Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation.</value>
    [DataMember(Name="reverseCorrelation", EmitDefaultValue=false)]
    public double? ReverseCorrelation { get; set; }

    
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="causalityFactor", EmitDefaultValue=false)]
    public double? CausalityFactor { get; set; }

    
    /// <summary>
    /// Variable category of the cause variable.
    /// </summary>
    /// <value>Variable category of the cause variable.</value>
    [DataMember(Name="causeCategory", EmitDefaultValue=false)]
    public string CauseCategory { get; set; }

    
    /// <summary>
    /// Variable category of the effect variable.
    /// </summary>
    /// <value>Variable category of the effect variable.</value>
    [DataMember(Name="effectCategory", EmitDefaultValue=false)]
    public string EffectCategory { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Correlation {\n");
      
      sb.Append("  CorrelationCoefficient: ").Append(CorrelationCoefficient).Append("\n");
      
      sb.Append("  Cause: ").Append(Cause).Append("\n");
      
      sb.Append("  Effect: ").Append(Effect).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  NumberOfPairs: ").Append(NumberOfPairs).Append("\n");
      
      sb.Append("  EffectSize: ").Append(EffectSize).Append("\n");
      
      sb.Append("  StatisticalSignificance: ").Append(StatisticalSignificance).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  ReverseCorrelation: ").Append(ReverseCorrelation).Append("\n");
      
      sb.Append("  CausalityFactor: ").Append(CausalityFactor).Append("\n");
      
      sb.Append("  CauseCategory: ").Append(CauseCategory).Append("\n");
      
      sb.Append("  EffectCategory: ").Append(EffectCategory).Append("\n");
      
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
