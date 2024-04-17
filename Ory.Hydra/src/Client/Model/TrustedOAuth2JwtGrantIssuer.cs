/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * Contact: hi@ory.sh
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
    /// OAuth2 JWT Bearer Grant Type Issuer Trust Relationship
    /// </summary>
    [DataContract(Name = "trustedOAuth2JwtGrantIssuer")]
    public partial class TrustedOAuth2JwtGrantIssuer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedOAuth2JwtGrantIssuer" /> class.
        /// </summary>
        /// <param name="allowAnySubject">The \&quot;allow_any_subject\&quot; indicates that the issuer is allowed to have any principal as the subject of the JWT..</param>
        /// <param name="createdAt">The \&quot;created_at\&quot; indicates, when grant was created..</param>
        /// <param name="expiresAt">The \&quot;expires_at\&quot; indicates, when grant will expire, so we will reject assertion from \&quot;issuer\&quot; targeting \&quot;subject\&quot;..</param>
        /// <param name="id">id.</param>
        /// <param name="issuer">The \&quot;issuer\&quot; identifies the principal that issued the JWT assertion (same as \&quot;iss\&quot; claim in JWT)..</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="scope">The \&quot;scope\&quot; contains list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749]).</param>
        /// <param name="subject">The \&quot;subject\&quot; identifies the principal that is the subject of the JWT..</param>
        public TrustedOAuth2JwtGrantIssuer(bool allowAnySubject = default(bool), DateTime createdAt = default(DateTime), DateTime expiresAt = default(DateTime), string id = default(string), string issuer = default(string), TrustedOAuth2JwtGrantJsonWebKey publicKey = default(TrustedOAuth2JwtGrantJsonWebKey), List<string> scope = default(List<string>), string subject = default(string))
        {
            this.AllowAnySubject = allowAnySubject;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.Issuer = issuer;
            this.PublicKey = publicKey;
            this.Scope = scope;
            this.Subject = subject;
        }

        /// <summary>
        /// The \&quot;allow_any_subject\&quot; indicates that the issuer is allowed to have any principal as the subject of the JWT.
        /// </summary>
        /// <value>The \&quot;allow_any_subject\&quot; indicates that the issuer is allowed to have any principal as the subject of the JWT.</value>
        [DataMember(Name = "allow_any_subject", EmitDefaultValue = true)]
        public bool AllowAnySubject { get; set; }

        /// <summary>
        /// The \&quot;created_at\&quot; indicates, when grant was created.
        /// </summary>
        /// <value>The \&quot;created_at\&quot; indicates, when grant was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The \&quot;expires_at\&quot; indicates, when grant will expire, so we will reject assertion from \&quot;issuer\&quot; targeting \&quot;subject\&quot;.
        /// </summary>
        /// <value>The \&quot;expires_at\&quot; indicates, when grant will expire, so we will reject assertion from \&quot;issuer\&quot; targeting \&quot;subject\&quot;.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>9edc811f-4e28-453c-9b46-4de65f00217f</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The \&quot;issuer\&quot; identifies the principal that issued the JWT assertion (same as \&quot;iss\&quot; claim in JWT).
        /// </summary>
        /// <value>The \&quot;issuer\&quot; identifies the principal that issued the JWT assertion (same as \&quot;iss\&quot; claim in JWT).</value>
        /// <example>https://jwt-idp.example.com</example>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]
        public TrustedOAuth2JwtGrantJsonWebKey PublicKey { get; set; }

        /// <summary>
        /// The \&quot;scope\&quot; contains list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749])
        /// </summary>
        /// <value>The \&quot;scope\&quot; contains list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749])</value>
        /// <example>[&quot;openid&quot;,&quot;offline&quot;]</example>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// The \&quot;subject\&quot; identifies the principal that is the subject of the JWT.
        /// </summary>
        /// <value>The \&quot;subject\&quot; identifies the principal that is the subject of the JWT.</value>
        /// <example>mike@example.com</example>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrustedOAuth2JwtGrantIssuer {\n");
            sb.Append("  AllowAnySubject: ").Append(AllowAnySubject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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