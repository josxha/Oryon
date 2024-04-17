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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// UpdateLoginFlowBody
    /// </summary>
    [JsonConverter(typeof(UpdateLoginFlowBodyJsonConverter))]
    [DataContract(Name = "updateLoginFlowBody")]
    public partial class UpdateLoginFlowBody : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithPasswordMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithOidcMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithOidcMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithOidcMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithTotpMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithTotpMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithTotpMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithWebAuthnMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithWebAuthnMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithWebAuthnMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithLookupSecretMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithLookupSecretMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithLookupSecretMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoginFlowBody" /> class
        /// with the <see cref="UpdateLoginFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UpdateLoginFlowWithCodeMethod.</param>
        public UpdateLoginFlowBody(UpdateLoginFlowWithCodeMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(UpdateLoginFlowWithCodeMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UpdateLoginFlowWithLookupSecretMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UpdateLoginFlowWithOidcMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UpdateLoginFlowWithPasswordMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UpdateLoginFlowWithTotpMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UpdateLoginFlowWithWebAuthnMethod))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UpdateLoginFlowWithCodeMethod, UpdateLoginFlowWithLookupSecretMethod, UpdateLoginFlowWithOidcMethod, UpdateLoginFlowWithPasswordMethod, UpdateLoginFlowWithTotpMethod, UpdateLoginFlowWithWebAuthnMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithPasswordMethod`. If the actual instance is not `UpdateLoginFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithPasswordMethod</returns>
        public UpdateLoginFlowWithPasswordMethod GetUpdateLoginFlowWithPasswordMethod()
        {
            return (UpdateLoginFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithOidcMethod`. If the actual instance is not `UpdateLoginFlowWithOidcMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithOidcMethod</returns>
        public UpdateLoginFlowWithOidcMethod GetUpdateLoginFlowWithOidcMethod()
        {
            return (UpdateLoginFlowWithOidcMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithTotpMethod`. If the actual instance is not `UpdateLoginFlowWithTotpMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithTotpMethod</returns>
        public UpdateLoginFlowWithTotpMethod GetUpdateLoginFlowWithTotpMethod()
        {
            return (UpdateLoginFlowWithTotpMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithWebAuthnMethod`. If the actual instance is not `UpdateLoginFlowWithWebAuthnMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithWebAuthnMethod</returns>
        public UpdateLoginFlowWithWebAuthnMethod GetUpdateLoginFlowWithWebAuthnMethod()
        {
            return (UpdateLoginFlowWithWebAuthnMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithLookupSecretMethod`. If the actual instance is not `UpdateLoginFlowWithLookupSecretMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithLookupSecretMethod</returns>
        public UpdateLoginFlowWithLookupSecretMethod GetUpdateLoginFlowWithLookupSecretMethod()
        {
            return (UpdateLoginFlowWithLookupSecretMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UpdateLoginFlowWithCodeMethod`. If the actual instance is not `UpdateLoginFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UpdateLoginFlowWithCodeMethod</returns>
        public UpdateLoginFlowWithCodeMethod GetUpdateLoginFlowWithCodeMethod()
        {
            return (UpdateLoginFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, UpdateLoginFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UpdateLoginFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UpdateLoginFlowBody</returns>
        public static UpdateLoginFlowBody FromJson(string jsonString)
        {
            UpdateLoginFlowBody newUpdateLoginFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdateLoginFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithCodeMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithCodeMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithLookupSecretMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithLookupSecretMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithLookupSecretMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithLookupSecretMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithLookupSecretMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithOidcMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithOidcMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithOidcMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithOidcMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithOidcMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithPasswordMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithPasswordMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithTotpMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithTotpMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithTotpMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithTotpMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithTotpMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UpdateLoginFlowWithWebAuthnMethod).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithWebAuthnMethod>(jsonString, UpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newUpdateLoginFlowBody = new UpdateLoginFlowBody(JsonConvert.DeserializeObject<UpdateLoginFlowWithWebAuthnMethod>(jsonString, UpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UpdateLoginFlowWithWebAuthnMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpdateLoginFlowWithWebAuthnMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newUpdateLoginFlowBody;
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

    /// <summary>
    /// Custom JSON converter for UpdateLoginFlowBody
    /// </summary>
    public class UpdateLoginFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UpdateLoginFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return UpdateLoginFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return UpdateLoginFlowBody.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
