﻿using Newtonsoft.Json;

namespace TelegramBotApi.Types
{
    /// <summary>
    /// Represents a venue
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Venue
    {
        /// <summary>
        /// Venue location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location;

        /// <summary>
        /// Name of the venue
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title;

        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address;

        /// <summary>
        /// Optional. Foursquare identifier of the venue
        /// </summary>
        [JsonProperty(PropertyName = "foursquare_id")]
        public string FoursquareId;
    }
}
