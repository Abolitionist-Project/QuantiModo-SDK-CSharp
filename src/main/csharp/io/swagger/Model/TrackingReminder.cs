using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class TrackingReminder :  IEquatable<TrackingReminder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminder" /> class.
        /// </summary>
        public TrackingReminder()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// client_id
        /// </summary>
        /// <value>client_id</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
  
        
        /// <summary>
        /// ID of User
        /// </summary>
        /// <value>ID of User</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// Id for the variable to be tracked
        /// </summary>
        /// <value>Id for the variable to be tracked</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
  
        
        /// <summary>
        /// Default value to use for the measurement when tracking
        /// </summary>
        /// <value>Default value to use for the measurement when tracking</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public float? DefaultValue { get; set; }
  
        
        /// <summary>
        /// Earliest time of day at which reminders should appear
        /// </summary>
        /// <value>Earliest time of day at which reminders should appear</value>
        [DataMember(Name="reminder_start_time", EmitDefaultValue=false)]
        public string ReminderStartTime { get; set; }
  
        
        /// <summary>
        /// Latest time of day at which reminders should appear
        /// </summary>
        /// <value>Latest time of day at which reminders should appear</value>
        [DataMember(Name="reminder_end_time", EmitDefaultValue=false)]
        public string ReminderEndTime { get; set; }
  
        
        /// <summary>
        /// String identifier for the sound to accompany the reminder
        /// </summary>
        /// <value>String identifier for the sound to accompany the reminder</value>
        [DataMember(Name="reminder_sound", EmitDefaultValue=false)]
        public string ReminderSound { get; set; }
  
        
        /// <summary>
        /// Number of seconds between one reminder and the next
        /// </summary>
        /// <value>Number of seconds between one reminder and the next</value>
        [DataMember(Name="reminder_frequency", EmitDefaultValue=false)]
        public int? ReminderFrequency { get; set; }
  
        
        /// <summary>
        /// True if the reminders should appear as a popup notification
        /// </summary>
        /// <value>True if the reminders should appear as a popup notification</value>
        [DataMember(Name="pop_up", EmitDefaultValue=false)]
        public bool? PopUp { get; set; }
  
        
        /// <summary>
        /// True if the reminders should be delivered via SMS
        /// </summary>
        /// <value>True if the reminders should be delivered via SMS</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public bool? Sms { get; set; }
  
        
        /// <summary>
        /// True if the reminders should be delivered via email
        /// </summary>
        /// <value>True if the reminders should be delivered via email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public bool? Email { get; set; }
  
        
        /// <summary>
        /// True if the reminders should appear in the notification bar
        /// </summary>
        /// <value>True if the reminders should appear in the notification bar</value>
        [DataMember(Name="notification_bar", EmitDefaultValue=false)]
        public bool? NotificationBar { get; set; }
  
        
        /// <summary>
        /// ISO 8601 timestamp for the last time a reminder was sent
        /// </summary>
        /// <value>ISO 8601 timestamp for the last time a reminder was sent</value>
        [DataMember(Name="last_reminded", EmitDefaultValue=false)]
        public DateTime? LastReminded { get; set; }
  
        
        /// <summary>
        /// ISO 8601 timestamp for the last time a measurement was received for this user and variable
        /// </summary>
        /// <value>ISO 8601 timestamp for the last time a measurement was received for this user and variable</value>
        [DataMember(Name="last_tracked", EmitDefaultValue=false)]
        public DateTime? LastTracked { get; set; }
  
        
        /// <summary>
        /// When the record was first created. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record was first created. Use ISO 8601 datetime format</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// When the record in the database was last updated. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingReminder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  ReminderStartTime: ").Append(ReminderStartTime).Append("\n");
            sb.Append("  ReminderEndTime: ").Append(ReminderEndTime).Append("\n");
            sb.Append("  ReminderSound: ").Append(ReminderSound).Append("\n");
            sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
            sb.Append("  PopUp: ").Append(PopUp).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NotificationBar: ").Append(NotificationBar).Append("\n");
            sb.Append("  LastReminded: ").Append(LastReminded).Append("\n");
            sb.Append("  LastTracked: ").Append(LastTracked).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrackingReminder);
        }

        /// <summary>
        /// Returns true if TrackingReminder instances are equal
        /// </summary>
        /// <param name="obj">Instance of TrackingReminder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingReminder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.VariableId == other.VariableId ||
                    this.VariableId != null &&
                    this.VariableId.Equals(other.VariableId)
                ) && 
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
                ) && 
                (
                    this.ReminderStartTime == other.ReminderStartTime ||
                    this.ReminderStartTime != null &&
                    this.ReminderStartTime.Equals(other.ReminderStartTime)
                ) && 
                (
                    this.ReminderEndTime == other.ReminderEndTime ||
                    this.ReminderEndTime != null &&
                    this.ReminderEndTime.Equals(other.ReminderEndTime)
                ) && 
                (
                    this.ReminderSound == other.ReminderSound ||
                    this.ReminderSound != null &&
                    this.ReminderSound.Equals(other.ReminderSound)
                ) && 
                (
                    this.ReminderFrequency == other.ReminderFrequency ||
                    this.ReminderFrequency != null &&
                    this.ReminderFrequency.Equals(other.ReminderFrequency)
                ) && 
                (
                    this.PopUp == other.PopUp ||
                    this.PopUp != null &&
                    this.PopUp.Equals(other.PopUp)
                ) && 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NotificationBar == other.NotificationBar ||
                    this.NotificationBar != null &&
                    this.NotificationBar.Equals(other.NotificationBar)
                ) && 
                (
                    this.LastReminded == other.LastReminded ||
                    this.LastReminded != null &&
                    this.LastReminded.Equals(other.LastReminded)
                ) && 
                (
                    this.LastTracked == other.LastTracked ||
                    this.LastTracked != null &&
                    this.LastTracked.Equals(other.LastTracked)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 57 + this.ClientId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.VariableId != null)
                    hash = hash * 57 + this.VariableId.GetHashCode();
                
                if (this.DefaultValue != null)
                    hash = hash * 57 + this.DefaultValue.GetHashCode();
                
                if (this.ReminderStartTime != null)
                    hash = hash * 57 + this.ReminderStartTime.GetHashCode();
                
                if (this.ReminderEndTime != null)
                    hash = hash * 57 + this.ReminderEndTime.GetHashCode();
                
                if (this.ReminderSound != null)
                    hash = hash * 57 + this.ReminderSound.GetHashCode();
                
                if (this.ReminderFrequency != null)
                    hash = hash * 57 + this.ReminderFrequency.GetHashCode();
                
                if (this.PopUp != null)
                    hash = hash * 57 + this.PopUp.GetHashCode();
                
                if (this.Sms != null)
                    hash = hash * 57 + this.Sms.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.NotificationBar != null)
                    hash = hash * 57 + this.NotificationBar.GetHashCode();
                
                if (this.LastReminded != null)
                    hash = hash * 57 + this.LastReminded.GetHashCode();
                
                if (this.LastTracked != null)
                    hash = hash * 57 + this.LastTracked.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
