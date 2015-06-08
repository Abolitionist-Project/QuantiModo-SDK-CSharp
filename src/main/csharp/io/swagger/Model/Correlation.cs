using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class Correlation {
    
    /* Pearson correlation coefficient between cause and effect measurements */
    [DataMember(Name="correlationCoefficient", EmitDefaultValue=false)]
    public double? CorrelationCoefficient { get; set; }

    
    /* ORIGINAL variable name of the cause variable for which the user desires correlations. */
    [DataMember(Name="cause", EmitDefaultValue=false)]
    public string Cause { get; set; }

    
    /* ORIGINAL variable name of the effect variable for which the user desires correlations. */
    [DataMember(Name="effect", EmitDefaultValue=false)]
    public string Effect { get; set; }

    
    /* User estimated or default time after cause measurement before a perceivable effect is observed */
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    public double? OnsetDelay { get; set; }

    
    /* Time over which the cause is expected to produce a perceivable effect following the onset delay */
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    public double? DurationOfAction { get; set; }

    
    /* Number of points that went into the correlation calculation */
    [DataMember(Name="numberOfPairs", EmitDefaultValue=false)]
    public double? NumberOfPairs { get; set; }

    
    /* Magnitude of the effects of a cause indicating whether it's practically meaningful. */
    [DataMember(Name="effectSize", EmitDefaultValue=false)]
    public string EffectSize { get; set; }

    
    /* A function of the effect size and sample size */
    [DataMember(Name="statisticalSignificance", EmitDefaultValue=false)]
    public string StatisticalSignificance { get; set; }

    
    /* Time at which correlation was calculated */
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    public double? Timestamp { get; set; }

    
    /* Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation. */
    [DataMember(Name="reverseCorrelation", EmitDefaultValue=false)]
    public double? ReverseCorrelation { get; set; }

    
    /*  */
    [DataMember(Name="causalityFactor", EmitDefaultValue=false)]
    public double? CausalityFactor { get; set; }

    
    /* Variable category of the cause variable. */
    [DataMember(Name="causeCategory", EmitDefaultValue=false)]
    public string CauseCategory { get; set; }

    
    /* Variable category of the effect variable. */
    [DataMember(Name="effectCategory", EmitDefaultValue=false)]
    public string EffectCategory { get; set; }

    
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
  }
  
  
}
