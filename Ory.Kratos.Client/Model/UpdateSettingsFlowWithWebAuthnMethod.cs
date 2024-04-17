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
    /// Update Settings Flow with WebAuthn Method
    /// </summary>
    [DataContract(Name = "updateSettingsFlowWithWebAuthnMethod")]
    public partial class UpdateSettingsFlowWithWebAuthnMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsFlowWithWebAuthnMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSettingsFlowWithWebAuthnMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsFlowWithWebAuthnMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token.</param>
        /// <param name="method">Method  Should be set to \&quot;webauthn\&quot; when trying to add, update, or remove a webAuthn pairing. (required).</param>
        /// <param name="webauthnRegister">Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here..</param>
        /// <param name="webauthnRegisterDisplayname">Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added..</param>
        /// <param name="webauthnRemove">Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection..</param>
        public UpdateSettingsFlowWithWebAuthnMethod(string csrfToken = default(string), string method = default(string), string webauthnRegister = default(string), string webauthnRegisterDisplayname = default(string), string webauthnRemove = default(string))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for UpdateSettingsFlowWithWebAuthnMethod and cannot be null");
            }
            this.Method = method;
            this.CsrfToken = csrfToken;
            this.WebauthnRegister = webauthnRegister;
            this.WebauthnRegisterDisplayname = webauthnRegisterDisplayname;
            this.WebauthnRemove = webauthnRemove;
        }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method  Should be set to \&quot;webauthn\&quot; when trying to add, update, or remove a webAuthn pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;webauthn\&quot; when trying to add, update, or remove a webAuthn pairing.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
        /// </summary>
        /// <value>Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.</value>
        [DataMember(Name = "webauthn_register", EmitDefaultValue = false)]
        public string WebauthnRegister { get; set; }

        /// <summary>
        /// Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
        /// </summary>
        /// <value>Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.</value>
        [DataMember(Name = "webauthn_register_displayname", EmitDefaultValue = false)]
        public string WebauthnRegisterDisplayname { get; set; }

        /// <summary>
        /// Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.
        /// </summary>
        /// <value>Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.</value>
        [DataMember(Name = "webauthn_remove", EmitDefaultValue = false)]
        public string WebauthnRemove { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSettingsFlowWithWebAuthnMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  WebauthnRegister: ").Append(WebauthnRegister).Append("\n");
            sb.Append("  WebauthnRegisterDisplayname: ").Append(WebauthnRegisterDisplayname).Append("\n");
            sb.Append("  WebauthnRemove: ").Append(WebauthnRemove).Append("\n");
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
