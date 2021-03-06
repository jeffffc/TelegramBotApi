﻿using Newtonsoft.Json;

namespace TelegramBotApi.Types.Inline
{
    /// <summary>
    /// Represents the content of a contact message to be sent as the result of an inline query.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class InputContactMessageContent : InputMessageContent
    {
        /// <summary>
        /// Contact's phone number
        /// </summary>
        [JsonProperty(PropertyName = "phone_number", Required = Required.Always)]
        public string PhoneNumber;

        /// <summary>
        /// Contact's first name
        /// </summary>
        [JsonProperty(PropertyName = "first_name", Required = Required.Always)]
        public string FirstName;

        /// <summary>
        /// Optional. Contact's last name
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName;
    }
}
