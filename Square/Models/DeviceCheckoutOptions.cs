namespace Square.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Square;
    using Square.Utilities;

    /// <summary>
    /// DeviceCheckoutOptions.
    /// </summary>
    public class DeviceCheckoutOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCheckoutOptions"/> class.
        /// </summary>
        /// <param name="deviceId">device_id.</param>
        /// <param name="skipReceiptScreen">skip_receipt_screen.</param>
        /// <param name="collectSignature">collect_signature.</param>
        /// <param name="tipSettings">tip_settings.</param>
        /// <param name="showItemizedCart">show_itemized_cart.</param>
        public DeviceCheckoutOptions(
            string deviceId,
            bool? skipReceiptScreen = null,
            bool? collectSignature = null,
            Models.TipSettings tipSettings = null,
            bool? showItemizedCart = null)
        {
            this.DeviceId = deviceId;
            this.SkipReceiptScreen = skipReceiptScreen;
            this.CollectSignature = collectSignature;
            this.TipSettings = tipSettings;
            this.ShowItemizedCart = showItemizedCart;
        }

        /// <summary>
        /// The unique ID of the device intended for this `TerminalCheckout`.
        /// A list of `DeviceCode` objects can be retrieved from the /v2/devices/codes endpoint.
        /// Match a `DeviceCode.device_id` value with `device_id` to get the associated device code.
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; }

        /// <summary>
        /// Instructs the device to skip the receipt screen. Defaults to false.
        /// </summary>
        [JsonProperty("skip_receipt_screen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipReceiptScreen { get; }

        /// <summary>
        /// Indicates that signature collection is desired during checkout. Defaults to false.
        /// </summary>
        [JsonProperty("collect_signature", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CollectSignature { get; }

        /// <summary>
        /// Gets or sets TipSettings.
        /// </summary>
        [JsonProperty("tip_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TipSettings TipSettings { get; }

        /// <summary>
        /// Show the itemization screen prior to taking a payment. This field is only meaningful when the
        /// checkout includes an order ID. Defaults to true.
        /// </summary>
        [JsonProperty("show_itemized_cart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowItemizedCart { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceCheckoutOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is DeviceCheckoutOptions other &&
                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.SkipReceiptScreen == null && other.SkipReceiptScreen == null) || (this.SkipReceiptScreen?.Equals(other.SkipReceiptScreen) == true)) &&
                ((this.CollectSignature == null && other.CollectSignature == null) || (this.CollectSignature?.Equals(other.CollectSignature) == true)) &&
                ((this.TipSettings == null && other.TipSettings == null) || (this.TipSettings?.Equals(other.TipSettings) == true)) &&
                ((this.ShowItemizedCart == null && other.ShowItemizedCart == null) || (this.ShowItemizedCart?.Equals(other.ShowItemizedCart) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1038046407;
            hashCode = HashCode.Combine(this.DeviceId, this.SkipReceiptScreen, this.CollectSignature, this.TipSettings, this.ShowItemizedCart);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId == string.Empty ? "" : this.DeviceId)}");
            toStringOutput.Add($"this.SkipReceiptScreen = {(this.SkipReceiptScreen == null ? "null" : this.SkipReceiptScreen.ToString())}");
            toStringOutput.Add($"this.CollectSignature = {(this.CollectSignature == null ? "null" : this.CollectSignature.ToString())}");
            toStringOutput.Add($"this.TipSettings = {(this.TipSettings == null ? "null" : this.TipSettings.ToString())}");
            toStringOutput.Add($"this.ShowItemizedCart = {(this.ShowItemizedCart == null ? "null" : this.ShowItemizedCart.ToString())}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder(
                this.DeviceId)
                .SkipReceiptScreen(this.SkipReceiptScreen)
                .CollectSignature(this.CollectSignature)
                .TipSettings(this.TipSettings)
                .ShowItemizedCart(this.ShowItemizedCart);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string deviceId;
            private bool? skipReceiptScreen;
            private bool? collectSignature;
            private Models.TipSettings tipSettings;
            private bool? showItemizedCart;

            public Builder(
                string deviceId)
            {
                this.deviceId = deviceId;
            }

             /// <summary>
             /// DeviceId.
             /// </summary>
             /// <param name="deviceId"> deviceId. </param>
             /// <returns> Builder. </returns>
            public Builder DeviceId(string deviceId)
            {
                this.deviceId = deviceId;
                return this;
            }

             /// <summary>
             /// SkipReceiptScreen.
             /// </summary>
             /// <param name="skipReceiptScreen"> skipReceiptScreen. </param>
             /// <returns> Builder. </returns>
            public Builder SkipReceiptScreen(bool? skipReceiptScreen)
            {
                this.skipReceiptScreen = skipReceiptScreen;
                return this;
            }

             /// <summary>
             /// CollectSignature.
             /// </summary>
             /// <param name="collectSignature"> collectSignature. </param>
             /// <returns> Builder. </returns>
            public Builder CollectSignature(bool? collectSignature)
            {
                this.collectSignature = collectSignature;
                return this;
            }

             /// <summary>
             /// TipSettings.
             /// </summary>
             /// <param name="tipSettings"> tipSettings. </param>
             /// <returns> Builder. </returns>
            public Builder TipSettings(Models.TipSettings tipSettings)
            {
                this.tipSettings = tipSettings;
                return this;
            }

             /// <summary>
             /// ShowItemizedCart.
             /// </summary>
             /// <param name="showItemizedCart"> showItemizedCart. </param>
             /// <returns> Builder. </returns>
            public Builder ShowItemizedCart(bool? showItemizedCart)
            {
                this.showItemizedCart = showItemizedCart;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> DeviceCheckoutOptions. </returns>
            public DeviceCheckoutOptions Build()
            {
                return new DeviceCheckoutOptions(
                    this.deviceId,
                    this.skipReceiptScreen,
                    this.collectSignature,
                    this.tipSettings,
                    this.showItemizedCart);
            }
        }
    }
}