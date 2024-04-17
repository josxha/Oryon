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
    /// UiNodeTextAttributes
    /// </summary>
    [DataContract(Name = "uiNodeTextAttributes")]
    public partial class UiNodeTextAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiNodeTextAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UiNodeTextAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UiNodeTextAttributes" /> class.
        /// </summary>
        /// <param name="id">A unique identifier (required).</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. (required).</param>
        /// <param name="text">text (required).</param>
        public UiNodeTextAttributes(string id = default(string), string nodeType = default(string), UiText text = default(UiText))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UiNodeTextAttributes and cannot be null");
            }
            this.Id = id;
            // to ensure "nodeType" is required (not null)
            if (nodeType == null)
            {
                throw new ArgumentNullException("nodeType is a required property for UiNodeTextAttributes and cannot be null");
            }
            this.NodeType = nodeType;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for UiNodeTextAttributes and cannot be null");
            }
            this.Text = text;
        }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;.
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;.</value>
        [DataMember(Name = "node_type", IsRequired = true, EmitDefaultValue = true)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public UiText Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UiNodeTextAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
