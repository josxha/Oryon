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
    /// OpenID Connect Userinfo
    /// </summary>
    [DataContract(Name = "oidcUserInfo")]
    public partial class OidcUserInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OidcUserInfo" /> class.
        /// </summary>
        /// <param name="birthdate">End-User&#39;s birthday, represented as an ISO 8601:2004 [ISO8601‑2004] YYYY-MM-DD format. The year MAY be 0000, indicating that it is omitted. To represent only the year, YYYY format is allowed. Note that depending on the underlying platform&#39;s date related function, providing just year can result in varying month and day, so the implementers need to take this factor into account to correctly process the dates..</param>
        /// <param name="email">End-User&#39;s preferred e-mail address. Its value MUST conform to the RFC 5322 [RFC5322] addr-spec syntax. The RP MUST NOT rely upon this value being unique, as discussed in Section 5.7..</param>
        /// <param name="emailVerified">True if the End-User&#39;s e-mail address has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this e-mail address was controlled by the End-User at the time the verification was performed. The means by which an e-mail address is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating..</param>
        /// <param name="familyName">Surname(s) or last name(s) of the End-User. Note that in some cultures, people can have multiple family names or no family name; all can be present, with the names being separated by space characters..</param>
        /// <param name="gender">End-User&#39;s gender. Values defined by this specification are female and male. Other values MAY be used when neither of the defined values are applicable..</param>
        /// <param name="givenName">Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple given names; all can be present, with the names being separated by space characters..</param>
        /// <param name="locale">End-User&#39;s locale, represented as a BCP47 [RFC5646] language tag. This is typically an ISO 639-1 Alpha-2 [ISO639‑1] language code in lowercase and an ISO 3166-1 Alpha-2 [ISO3166‑1] country code in uppercase, separated by a dash. For example, en-US or fr-CA. As a compatibility note, some implementations have used an underscore as the separator rather than a dash, for example, en_US; Relying Parties MAY choose to accept this locale syntax as well..</param>
        /// <param name="middleName">Middle name(s) of the End-User. Note that in some cultures, people can have multiple middle names; all can be present, with the names being separated by space characters. Also note that in some cultures, middle names are not used..</param>
        /// <param name="name">End-User&#39;s full name in displayable form including all name parts, possibly including titles and suffixes, ordered according to the End-User&#39;s locale and preferences..</param>
        /// <param name="nickname">Casual name of the End-User that may or may not be the same as the given_name. For instance, a nickname value of Mike might be returned alongside a given_name value of Michael..</param>
        /// <param name="phoneNumber">End-User&#39;s preferred telephone number. E.164 [E.164] is RECOMMENDED as the format of this Claim, for example, +1 (425) 555-1212 or +56 (2) 687 2400. If the phone number contains an extension, it is RECOMMENDED that the extension be represented using the RFC 3966 [RFC3966] extension syntax, for example, +1 (604) 555-1234;ext&#x3D;5678..</param>
        /// <param name="phoneNumberVerified">True if the End-User&#39;s phone number has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this phone number was controlled by the End-User at the time the verification was performed. The means by which a phone number is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating. When true, the phone_number Claim MUST be in E.164 format and any extensions MUST be represented in RFC 3966 format..</param>
        /// <param name="picture">URL of the End-User&#39;s profile picture. This URL MUST refer to an image file (for example, a PNG, JPEG, or GIF image file), rather than to a Web page containing an image. Note that this URL SHOULD specifically reference a profile photo of the End-User suitable for displaying when describing the End-User, rather than an arbitrary photo taken by the End-User..</param>
        /// <param name="preferredUsername">Non-unique shorthand name by which the End-User wishes to be referred to at the RP, such as janedoe or j.doe. This value MAY be any valid JSON string including special characters such as @, /, or whitespace..</param>
        /// <param name="profile">URL of the End-User&#39;s profile page. The contents of this Web page SHOULD be about the End-User..</param>
        /// <param name="sub">Subject - Identifier for the End-User at the IssuerURL..</param>
        /// <param name="updatedAt">Time the End-User&#39;s information was last updated. Its value is a JSON number representing the number of seconds from 1970-01-01T0:0:0Z as measured in UTC until the date/time..</param>
        /// <param name="website">URL of the End-User&#39;s Web page or blog. This Web page SHOULD contain information published by the End-User or an organization that the End-User is affiliated with..</param>
        /// <param name="zoneinfo">String from zoneinfo [zoneinfo] time zone database representing the End-User&#39;s time zone. For example, Europe/Paris or America/Los_Angeles..</param>
        public OidcUserInfo(string birthdate = default(string), string email = default(string), bool emailVerified = default(bool), string familyName = default(string), string gender = default(string), string givenName = default(string), string locale = default(string), string middleName = default(string), string name = default(string), string nickname = default(string), string phoneNumber = default(string), bool phoneNumberVerified = default(bool), string picture = default(string), string preferredUsername = default(string), string profile = default(string), string sub = default(string), long updatedAt = default(long), string website = default(string), string zoneinfo = default(string))
        {
            this.Birthdate = birthdate;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.FamilyName = familyName;
            this.Gender = gender;
            this.GivenName = givenName;
            this.Locale = locale;
            this.MiddleName = middleName;
            this.Name = name;
            this.Nickname = nickname;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberVerified = phoneNumberVerified;
            this.Picture = picture;
            this.PreferredUsername = preferredUsername;
            this.Profile = profile;
            this.Sub = sub;
            this.UpdatedAt = updatedAt;
            this.Website = website;
            this.Zoneinfo = zoneinfo;
        }

        /// <summary>
        /// End-User&#39;s birthday, represented as an ISO 8601:2004 [ISO8601‑2004] YYYY-MM-DD format. The year MAY be 0000, indicating that it is omitted. To represent only the year, YYYY format is allowed. Note that depending on the underlying platform&#39;s date related function, providing just year can result in varying month and day, so the implementers need to take this factor into account to correctly process the dates.
        /// </summary>
        /// <value>End-User&#39;s birthday, represented as an ISO 8601:2004 [ISO8601‑2004] YYYY-MM-DD format. The year MAY be 0000, indicating that it is omitted. To represent only the year, YYYY format is allowed. Note that depending on the underlying platform&#39;s date related function, providing just year can result in varying month and day, so the implementers need to take this factor into account to correctly process the dates.</value>
        [DataMember(Name = "birthdate", EmitDefaultValue = false)]
        public string Birthdate { get; set; }

        /// <summary>
        /// End-User&#39;s preferred e-mail address. Its value MUST conform to the RFC 5322 [RFC5322] addr-spec syntax. The RP MUST NOT rely upon this value being unique, as discussed in Section 5.7.
        /// </summary>
        /// <value>End-User&#39;s preferred e-mail address. Its value MUST conform to the RFC 5322 [RFC5322] addr-spec syntax. The RP MUST NOT rely upon this value being unique, as discussed in Section 5.7.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// True if the End-User&#39;s e-mail address has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this e-mail address was controlled by the End-User at the time the verification was performed. The means by which an e-mail address is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating.
        /// </summary>
        /// <value>True if the End-User&#39;s e-mail address has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this e-mail address was controlled by the End-User at the time the verification was performed. The means by which an e-mail address is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating.</value>
        [DataMember(Name = "email_verified", EmitDefaultValue = true)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// Surname(s) or last name(s) of the End-User. Note that in some cultures, people can have multiple family names or no family name; all can be present, with the names being separated by space characters.
        /// </summary>
        /// <value>Surname(s) or last name(s) of the End-User. Note that in some cultures, people can have multiple family names or no family name; all can be present, with the names being separated by space characters.</value>
        [DataMember(Name = "family_name", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// End-User&#39;s gender. Values defined by this specification are female and male. Other values MAY be used when neither of the defined values are applicable.
        /// </summary>
        /// <value>End-User&#39;s gender. Values defined by this specification are female and male. Other values MAY be used when neither of the defined values are applicable.</value>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple given names; all can be present, with the names being separated by space characters.
        /// </summary>
        /// <value>Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple given names; all can be present, with the names being separated by space characters.</value>
        [DataMember(Name = "given_name", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// End-User&#39;s locale, represented as a BCP47 [RFC5646] language tag. This is typically an ISO 639-1 Alpha-2 [ISO639‑1] language code in lowercase and an ISO 3166-1 Alpha-2 [ISO3166‑1] country code in uppercase, separated by a dash. For example, en-US or fr-CA. As a compatibility note, some implementations have used an underscore as the separator rather than a dash, for example, en_US; Relying Parties MAY choose to accept this locale syntax as well.
        /// </summary>
        /// <value>End-User&#39;s locale, represented as a BCP47 [RFC5646] language tag. This is typically an ISO 639-1 Alpha-2 [ISO639‑1] language code in lowercase and an ISO 3166-1 Alpha-2 [ISO3166‑1] country code in uppercase, separated by a dash. For example, en-US or fr-CA. As a compatibility note, some implementations have used an underscore as the separator rather than a dash, for example, en_US; Relying Parties MAY choose to accept this locale syntax as well.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Middle name(s) of the End-User. Note that in some cultures, people can have multiple middle names; all can be present, with the names being separated by space characters. Also note that in some cultures, middle names are not used.
        /// </summary>
        /// <value>Middle name(s) of the End-User. Note that in some cultures, people can have multiple middle names; all can be present, with the names being separated by space characters. Also note that in some cultures, middle names are not used.</value>
        [DataMember(Name = "middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// End-User&#39;s full name in displayable form including all name parts, possibly including titles and suffixes, ordered according to the End-User&#39;s locale and preferences.
        /// </summary>
        /// <value>End-User&#39;s full name in displayable form including all name parts, possibly including titles and suffixes, ordered according to the End-User&#39;s locale and preferences.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Casual name of the End-User that may or may not be the same as the given_name. For instance, a nickname value of Mike might be returned alongside a given_name value of Michael.
        /// </summary>
        /// <value>Casual name of the End-User that may or may not be the same as the given_name. For instance, a nickname value of Mike might be returned alongside a given_name value of Michael.</value>
        [DataMember(Name = "nickname", EmitDefaultValue = false)]
        public string Nickname { get; set; }

        /// <summary>
        /// End-User&#39;s preferred telephone number. E.164 [E.164] is RECOMMENDED as the format of this Claim, for example, +1 (425) 555-1212 or +56 (2) 687 2400. If the phone number contains an extension, it is RECOMMENDED that the extension be represented using the RFC 3966 [RFC3966] extension syntax, for example, +1 (604) 555-1234;ext&#x3D;5678.
        /// </summary>
        /// <value>End-User&#39;s preferred telephone number. E.164 [E.164] is RECOMMENDED as the format of this Claim, for example, +1 (425) 555-1212 or +56 (2) 687 2400. If the phone number contains an extension, it is RECOMMENDED that the extension be represented using the RFC 3966 [RFC3966] extension syntax, for example, +1 (604) 555-1234;ext&#x3D;5678.</value>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// True if the End-User&#39;s phone number has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this phone number was controlled by the End-User at the time the verification was performed. The means by which a phone number is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating. When true, the phone_number Claim MUST be in E.164 format and any extensions MUST be represented in RFC 3966 format.
        /// </summary>
        /// <value>True if the End-User&#39;s phone number has been verified; otherwise false. When this Claim Value is true, this means that the OP took affirmative steps to ensure that this phone number was controlled by the End-User at the time the verification was performed. The means by which a phone number is verified is context-specific, and dependent upon the trust framework or contractual agreements within which the parties are operating. When true, the phone_number Claim MUST be in E.164 format and any extensions MUST be represented in RFC 3966 format.</value>
        [DataMember(Name = "phone_number_verified", EmitDefaultValue = true)]
        public bool PhoneNumberVerified { get; set; }

        /// <summary>
        /// URL of the End-User&#39;s profile picture. This URL MUST refer to an image file (for example, a PNG, JPEG, or GIF image file), rather than to a Web page containing an image. Note that this URL SHOULD specifically reference a profile photo of the End-User suitable for displaying when describing the End-User, rather than an arbitrary photo taken by the End-User.
        /// </summary>
        /// <value>URL of the End-User&#39;s profile picture. This URL MUST refer to an image file (for example, a PNG, JPEG, or GIF image file), rather than to a Web page containing an image. Note that this URL SHOULD specifically reference a profile photo of the End-User suitable for displaying when describing the End-User, rather than an arbitrary photo taken by the End-User.</value>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Non-unique shorthand name by which the End-User wishes to be referred to at the RP, such as janedoe or j.doe. This value MAY be any valid JSON string including special characters such as @, /, or whitespace.
        /// </summary>
        /// <value>Non-unique shorthand name by which the End-User wishes to be referred to at the RP, such as janedoe or j.doe. This value MAY be any valid JSON string including special characters such as @, /, or whitespace.</value>
        [DataMember(Name = "preferred_username", EmitDefaultValue = false)]
        public string PreferredUsername { get; set; }

        /// <summary>
        /// URL of the End-User&#39;s profile page. The contents of this Web page SHOULD be about the End-User.
        /// </summary>
        /// <value>URL of the End-User&#39;s profile page. The contents of this Web page SHOULD be about the End-User.</value>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public string Profile { get; set; }

        /// <summary>
        /// Subject - Identifier for the End-User at the IssuerURL.
        /// </summary>
        /// <value>Subject - Identifier for the End-User at the IssuerURL.</value>
        [DataMember(Name = "sub", EmitDefaultValue = false)]
        public string Sub { get; set; }

        /// <summary>
        /// Time the End-User&#39;s information was last updated. Its value is a JSON number representing the number of seconds from 1970-01-01T0:0:0Z as measured in UTC until the date/time.
        /// </summary>
        /// <value>Time the End-User&#39;s information was last updated. Its value is a JSON number representing the number of seconds from 1970-01-01T0:0:0Z as measured in UTC until the date/time.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// URL of the End-User&#39;s Web page or blog. This Web page SHOULD contain information published by the End-User or an organization that the End-User is affiliated with.
        /// </summary>
        /// <value>URL of the End-User&#39;s Web page or blog. This Web page SHOULD contain information published by the End-User or an organization that the End-User is affiliated with.</value>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// String from zoneinfo [zoneinfo] time zone database representing the End-User&#39;s time zone. For example, Europe/Paris or America/Los_Angeles.
        /// </summary>
        /// <value>String from zoneinfo [zoneinfo] time zone database representing the End-User&#39;s time zone. For example, Europe/Paris or America/Los_Angeles.</value>
        [DataMember(Name = "zoneinfo", EmitDefaultValue = false)]
        public string Zoneinfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcUserInfo {\n");
            sb.Append("  Birthdate: ").Append(Birthdate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberVerified: ").Append(PhoneNumberVerified).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  PreferredUsername: ").Append(PreferredUsername).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Zoneinfo: ").Append(Zoneinfo).Append("\n");
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
