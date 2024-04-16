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
    /// Container represents a HTML Form. The container can work with both HTTP Form and JSON requests
    /// </summary>
    [DataContract(Name = "uiContainer")]
    public partial class UiContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiContainer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UiContainer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UiContainer" /> class.
        /// </summary>
        /// <param name="action">Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;. (required).</param>
        /// <param name="messages">messages.</param>
        /// <param name="method">Method is the form method (e.g. POST) (required).</param>
        /// <param name="nodes">nodes (required).</param>
        public UiContainer(string action = default(string), List<UiText> messages = default(List<UiText>), string method = default(string), List<UiNode> nodes = default(List<UiNode>))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for UiContainer and cannot be null");
            }
            this.Action = action;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for UiContainer and cannot be null");
            }
            this.Method = method;
            // to ensure "nodes" is required (not null)
            if (nodes == null)
            {
                throw new ArgumentNullException("nodes is a required property for UiContainer and cannot be null");
            }
            this.Nodes = nodes;
            this.Messages = messages;
        }

        /// <summary>
        /// Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;.
        /// </summary>
        /// <value>Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;.</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<UiText> Messages { get; set; }

        /// <summary>
        /// Method is the form method (e.g. POST)
        /// </summary>
        /// <value>Method is the form method (e.g. POST)</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [DataMember(Name = "nodes", IsRequired = true, EmitDefaultValue = true)]
        public List<UiNode> Nodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UiContainer {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
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
