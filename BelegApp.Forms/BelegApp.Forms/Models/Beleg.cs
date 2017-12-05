/* 
 * Swagger documentation for belegerfassung-ui
 *
 * Backend for Xamarin Hackathon
 *
 * OpenAPI spec version: 1.0.0-SNAPSHOT
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BelegApp.Forms.Utils.SwaggerDateConverter;

using SQLite;

namespace BelegApp.Forms.Models
{
    /// <summary>
    /// Beleg
    /// </summary>
    [DataContract]
    public partial class Beleg :  IEquatable<Beleg>, IValidatableObject
    {
        /// <summary>
        /// Status des Beleges
        /// </summary>
        /// <value>Status des Beleges</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ERFASST for "ERFASST"
            /// </summary>
            [EnumMember(Value = "ERFASST")]
            ERFASST,
            
            /// <summary>
            /// Enum EXPORTIERT for "EXPORTIERT"
            /// </summary>
            [EnumMember(Value = "EXPORTIERT")]
            EXPORTIERT,
            
            /// <summary>
            /// Enum GEBUCHT for "GEBUCHT"
            /// </summary>
            [EnumMember(Value = "GEBUCHT")]
            GEBUCHT,
            
            /// <summary>
            /// Enum ABGELEHNT for "ABGELEHNT"
            /// </summary>
            [EnumMember(Value = "ABGELEHNT")]
            ABGELEHNT
        }

        /// <summary>
        /// Status des Beleges
        /// </summary>
        /// <value>Status des Beleges</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Beleg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Beleg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Beleg" /> class.
        /// </summary>
        /// <param name="Belegnummer">Id des Beleges (required).</param>
        /// <param name="Description">Beschreibung des Beleges (required).</param>
        /// <param name="Date">Belegdatum (required).</param>
        /// <param name="Type">Art des Beleges (required).</param>
        /// <param name="Status">Status des Beleges (required).</param>
        /// <param name="Thumbnail">Thumbnail-Darstellung des Beleges.</param>
        /// <param name="BelegSize">Gr��e des Beleges.</param>
        public Beleg(int? Belegnummer = default(int?), string Description = default(string), DateTime? Date = default(DateTime?), string Type = default(string), StatusEnum? Status = default(StatusEnum?), List<byte[]> Thumbnail = default(List<byte[]>), long? BelegSize = default(long?))
        {
            // to ensure "Belegnummer" is required (not null)
            if (Belegnummer == null)
            {
                throw new InvalidDataException("Belegnummer is a required property for Beleg and cannot be null");
            }
            else
            {
                this.Belegnummer = Belegnummer;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for Beleg and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for Beleg and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Beleg and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Beleg and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.Thumbnail = Thumbnail;
            this.BelegSize = BelegSize;
        }
        
        /// <summary>
        /// Id des Beleges
        /// </summary>
        /// <value>Id des Beleges</value>
        [PrimaryKey, DataMember(Name="belegnummer", EmitDefaultValue=false)]
        public int? Belegnummer { get; set; }

        /// <summary>
        /// Beschreibung des Beleges
        /// </summary>
        /// <value>Beschreibung des Beleges</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Belegdatum
        /// </summary>
        /// <value>Belegdatum</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Art des Beleges
        /// </summary>
        /// <value>Art des Beleges</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Thumbnail-Darstellung des Beleges
        /// </summary>
        /// <value>Thumbnail-Darstellung des Beleges</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public List<byte[]> Thumbnail { get; set; }

        /// <summary>
        /// Gr��e des Beleges
        /// </summary>
        /// <value>Gr��e des Beleges</value>
        [DataMember(Name="belegSize", EmitDefaultValue=false)]
        public long? BelegSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Beleg {\n");
            sb.Append("  Belegnummer: ").Append(Belegnummer).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  BelegSize: ").Append(BelegSize).Append("\n");
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
            return this.Equals(obj as Beleg);
        }

        /// <summary>
        /// Returns true if Beleg instances are equal
        /// </summary>
        /// <param name="other">Instance of Beleg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Beleg other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Belegnummer == other.Belegnummer ||
                    this.Belegnummer != null &&
                    this.Belegnummer.Equals(other.Belegnummer)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.SequenceEqual(other.Thumbnail)
                ) && 
                (
                    this.BelegSize == other.BelegSize ||
                    this.BelegSize != null &&
                    this.BelegSize.Equals(other.BelegSize)
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
                if (this.Belegnummer != null)
                    hash = hash * 59 + this.Belegnummer.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.BelegSize != null)
                    hash = hash * 59 + this.BelegSize.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
