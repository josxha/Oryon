/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
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
    public partial class ContinueWithSettingsUi : IValidatableObject
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
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueWithSettingsUi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContinueWithSettingsUi() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueWithSettingsUi" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;show_settings_ui&#x60; show_settings_ui ContinueWithActionShowSettingsUIString (required).</param>
        /// <param name="flow">flow (required).</param>
        public ContinueWithSettingsUi(ActionEnum action = default(ActionEnum), ContinueWithSettingsUiFlow flow = default(ContinueWithSettingsUiFlow))
        {
            this.Action = action;
            // to ensure "flow" is required (not null)
            if (flow == null)
            {
                throw new ArgumentNullException("flow is a required property for ContinueWithSettingsUi and cannot be null");
            }
            this.Flow = flow;
        }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name = "flow", IsRequired = true, EmitDefaultValue = true)]
        public ContinueWithSettingsUiFlow Flow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContinueWithSettingsUi {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
