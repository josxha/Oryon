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
using OpenAPIDateConverter = Client.Client.OpenAPIDateConverter;

namespace Client.Model
{
    /// <summary>
    /// NeedsPrivilegedSessionError
    /// </summary>
    [DataContract(Name = "needsPrivilegedSessionError")]
    public partial class NeedsPrivilegedSessionError : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NeedsPrivilegedSessionError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NeedsPrivilegedSessionError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NeedsPrivilegedSessionError" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="redirectBrowserTo">Points to where to redirect the user to next. (required).</param>
        public NeedsPrivilegedSessionError(GenericError error = default(GenericError), string redirectBrowserTo = default(string))
        {
            // to ensure "redirectBrowserTo" is required (not null)
            if (redirectBrowserTo == null)
            {
                throw new ArgumentNullException("redirectBrowserTo is a required property for NeedsPrivilegedSessionError and cannot be null");
            }
            this.RedirectBrowserTo = redirectBrowserTo;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public GenericError Error { get; set; }

        /// <summary>
        /// Points to where to redirect the user to next.
        /// </summary>
        /// <value>Points to where to redirect the user to next.</value>
        [DataMember(Name = "redirect_browser_to", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectBrowserTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NeedsPrivilegedSessionError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RedirectBrowserTo: ").Append(RedirectBrowserTo).Append("\n");
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