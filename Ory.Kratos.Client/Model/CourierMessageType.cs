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
    /// It can either be &#x60;email&#x60; or &#x60;phone&#x60;
    /// </summary>
    /// <value>It can either be &#x60;email&#x60; or &#x60;phone&#x60;</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CourierMessageType
    {
        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        [EnumMember(Value = "email")]
        Email = 1,

        /// <summary>
        /// Enum Phone for value: phone
        /// </summary>
        [EnumMember(Value = "phone")]
        Phone = 2
    }

}
