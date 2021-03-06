﻿using Newtonsoft.Json;

namespace TelegramBotApi.Types.Payment
{
    /// <summary>
    /// This object contains basic information about a successful payment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class SuccessfulPayment
    {
        /// <summary>
        /// Three-letter ISO 4217 currency code
        /// </summary>
        [JsonProperty(PropertyName = "currency", Required = Required.Always)]
        public string Currency;

        /// <summary>
        /// Total price in the smallest units of the currency (integer, not float/double). 
        /// For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in currencies.json, 
        /// it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
        /// </summary>
        [JsonProperty(PropertyName = "total_amount", Required = Required.Always)]
        public int TotalAmount;

        /// <summary>
        /// Bot specified invoice payload
        /// </summary>
        [JsonProperty(PropertyName = "invoice_payload", Required = Required.Always)]
        public string InvoicePayload;

        /// <summary>
        /// Optional. Identifier of the shipping option chosen by the user
        /// </summary>
        [JsonProperty(PropertyName = "shipping_option_id")]
        public string ShippingOptionId;

        /// <summary>
        /// Optional. Order info provided by the user
        /// </summary>
        [JsonProperty(PropertyName = "order_info", Required = Required.Always)]
        public OrderInfo OrderInfo;

        /// <summary>
        /// Telegram payment identifier
        /// </summary>
        [JsonProperty(PropertyName = "telegram_payment_charge_id", Required = Required.Always)]
        public string TelegramPaymentChargeId;

        /// <summary>
        /// Provider payment identifier
        /// </summary>
        [JsonProperty(PropertyName = "provider_payment_charge_id", Required = Required.Always)]
        public string ProviderPaymentChargeId;
    }
}
