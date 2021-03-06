﻿using Newtonsoft.Json;
using TelegramBotApi.Types.Markup;
using TelegramBotApi.Enums;

namespace TelegramBotApi.Types.Inline
{
    /// <summary>
    /// Represents a link to a photo stored on the Telegram servers. By default, this photo will be sent by the user with an optional caption. 
    /// Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class InlineQueryResultCachedPhoto : InlineQueryResult
    {
        private string _type = "photo";

        /// <summary>
        /// Type of the result, must be photo
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get { return _type; } set { _type = "photo"; } }

        /// <summary>
        /// Unique identifier for this result, 1-64 Bytes
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public override string Id { get; set; }

        /// <summary>
        /// A valid file identifier of the photo
        /// </summary>
        [JsonProperty(PropertyName = "photo_file_id", Required = Required.Always)]
        public string PhotoFileId;

        /// <summary>
        /// Optional. Title for the result
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title;

        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description;

        /// <summary>
        /// Optional. Caption of the photo to be sent, 0-200 characters
        /// </summary>
        [JsonProperty(PropertyName = "caption")]
        public string Caption;


        /// <summary>
        /// Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.
        /// </summary>
        [JsonProperty(PropertyName = "parse_mode")]
        private string _parseMode = null;

        public ParseMode ParseMode
        {
            get
            {
                switch (_parseMode.ToLower())
                {
                    case "markdown":
                        return ParseMode.Markdown;
                    case "html":
                        return ParseMode.Html;
                    default:
                        return ParseMode.None;
                }
            }
            set
            {
                switch (value)
                {
                    case ParseMode.Markdown:
                        _parseMode = "Markdown";
                        break;
                    case ParseMode.Html:
                        _parseMode = "Html";
                        break;
                    default:
                        _parseMode = null;
                        break;
                }
            }
        }

        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty(PropertyName = "reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup;

        /// <summary>
        /// Content of the message to be sent
        /// </summary>
        [JsonProperty(PropertyName = "input_message_content", Required = Required.Always)]
        public InputMessageContent InputMessageContent;
    }
}
