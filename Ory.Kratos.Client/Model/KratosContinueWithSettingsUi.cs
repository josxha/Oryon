/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.1.0
 * Contact: office@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Indicates, that the UI flow could be continued by showing a settings ui
    /// </summary>
    [DataContract(Name = "continueWithSettingsUi")]
    public partial class KratosContinueWithSettingsUi : IEquatable<KratosContinueWithSettingsUi>, IValidatableObject
    {
        /// <summary>
        /// Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString
        /// </summary>
        /// <value>Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum ShowSettingsUi for value: show_settings_ui
            /// </summary>
            [EnumMember(Value = "show_settings_ui")]
            ShowSettingsUi = 1

        }


        /// <summary>
        /// Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString
        /// </summary>
        /// <value>Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithSettingsUi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosContinueWithSettingsUi()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithSettingsUi" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString (required).</param>
        /// <param name="flow">flow (required).</param>
        public KratosContinueWithSettingsUi(ActionEnum action = default(ActionEnum), KratosContinueWithSettingsUiFlow flow = default(KratosContinueWithSettingsUiFlow))
        {
            this.Action = action;
            // to ensure "flow" is required (not null)
            if (flow == null) {
                throw new ArgumentNullException("flow is a required property for KratosContinueWithSettingsUi and cannot be null");
            }
            this.Flow = flow;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name = "flow", IsRequired = true, EmitDefaultValue = false)]
        public KratosContinueWithSettingsUiFlow Flow { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosContinueWithSettingsUi {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosContinueWithSettingsUi);
        }

        /// <summary>
        /// Returns true if KratosContinueWithSettingsUi instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosContinueWithSettingsUi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosContinueWithSettingsUi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.Flow != null)
                {
                    hashCode = (hashCode * 59) + this.Flow.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
