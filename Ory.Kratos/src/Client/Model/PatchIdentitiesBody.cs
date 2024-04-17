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
    /// Patch Identities Body
    /// </summary>
    [DataContract(Name = "patchIdentitiesBody")]
    public partial class PatchIdentitiesBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchIdentitiesBody" /> class.
        /// </summary>
        /// <param name="identities">Identities holds the list of patches to apply  required.</param>
        public PatchIdentitiesBody(List<IdentityPatch> identities = default(List<IdentityPatch>))
        {
            this.Identities = identities;
        }

        /// <summary>
        /// Identities holds the list of patches to apply  required
        /// </summary>
        /// <value>Identities holds the list of patches to apply  required</value>
        [DataMember(Name = "identities", EmitDefaultValue = false)]
        public List<IdentityPatch> Identities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchIdentitiesBody {\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
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