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
    /// Checkout.
    /// </summary>
    public class Checkout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkout"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="checkoutPageUrl">checkout_page_url.</param>
        /// <param name="askForShippingAddress">ask_for_shipping_address.</param>
        /// <param name="merchantSupportEmail">merchant_support_email.</param>
        /// <param name="prePopulateBuyerEmail">pre_populate_buyer_email.</param>
        /// <param name="prePopulateShippingAddress">pre_populate_shipping_address.</param>
        /// <param name="redirectUrl">redirect_url.</param>
        /// <param name="order">order.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="additionalRecipients">additional_recipients.</param>
        public Checkout(
            string id = null,
            string checkoutPageUrl = null,
            bool? askForShippingAddress = null,
            string merchantSupportEmail = null,
            string prePopulateBuyerEmail = null,
            Models.Address prePopulateShippingAddress = null,
            string redirectUrl = null,
            Models.Order order = null,
            string createdAt = null,
            IList<Models.AdditionalRecipient> additionalRecipients = null)
        {
            this.Id = id;
            this.CheckoutPageUrl = checkoutPageUrl;
            this.AskForShippingAddress = askForShippingAddress;
            this.MerchantSupportEmail = merchantSupportEmail;
            this.PrePopulateBuyerEmail = prePopulateBuyerEmail;
            this.PrePopulateShippingAddress = prePopulateShippingAddress;
            this.RedirectUrl = redirectUrl;
            this.Order = order;
            this.CreatedAt = createdAt;
            this.AdditionalRecipients = additionalRecipients;
        }

        /// <summary>
        /// ID generated by Square Checkout when a new checkout is requested.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The URL that the buyer's browser should be redirected to after the
        /// checkout is completed.
        /// </summary>
        [JsonProperty("checkout_page_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutPageUrl { get; }

        /// <summary>
        /// If `true`, Square Checkout will collect shipping information on your
        /// behalf and store that information with the transaction information in your
        /// Square Dashboard.
        /// Default: `false`.
        /// </summary>
        [JsonProperty("ask_for_shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AskForShippingAddress { get; }

        /// <summary>
        /// The email address to display on the Square Checkout confirmation page
        /// and confirmation email that the buyer can use to contact the merchant.
        /// If this value is not set, the confirmation page and email will display the
        /// primary email address associated with the merchant's Square account.
        /// Default: none; only exists if explicitly set.
        /// </summary>
        [JsonProperty("merchant_support_email", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantSupportEmail { get; }

        /// <summary>
        /// If provided, the buyer's email is pre-populated on the checkout page
        /// as an editable text field.
        /// Default: none; only exists if explicitly set.
        /// </summary>
        [JsonProperty("pre_populate_buyer_email", NullValueHandling = NullValueHandling.Ignore)]
        public string PrePopulateBuyerEmail { get; }

        /// <summary>
        /// Represents a postal address in a country. The address format is based
        /// on an [open-source library from Google](https://github.com/google/libaddressinput). For more information,
        /// see [AddressValidationMetadata](https://github.com/google/libaddressinput/wiki/AddressValidationMetadata).
        /// This format has dedicated fields for four address components: postal code,
        /// locality (city), administrative district (state, prefecture, or province), and
        /// sublocality (town or village). These components have dedicated fields in the
        /// `Address` object because software sometimes behaves differently based on them.
        /// For example, sales tax software may charge different amounts of sales tax
        /// based on the postal code, and some software is only available in
        /// certain states due to compliance reasons.
        /// For the remaining address components, the `Address` type provides the
        /// `address_line_1` and `address_line_2` fields for free-form data entry.
        /// These fields are free-form because the remaining address components have
        /// too many variations around the world and typical software does not parse
        /// these components. These fields enable users to enter anything they want.
        /// Note that, in the current implementation, all other `Address` type fields are blank.
        /// These include `address_line_3`, `sublocality_2`, `sublocality_3`,
        /// `administrative_district_level_2`, `administrative_district_level_3`,
        /// `first_name`, `last_name`, and `organization`.
        /// When it comes to localization, the seller's language preferences
        /// (see [Language preferences](https://developer.squareup.com/docs/locations-api#location-specific-and-seller-level-language-preferences))
        /// are ignored for addresses. Even though Square products (such as Square Point of Sale
        /// and the Seller Dashboard) mostly use a seller's language preference in
        /// communication, when it comes to addresses, they will use English for a US address,
        /// Japanese for an address in Japan, and so on.
        /// </summary>
        [JsonProperty("pre_populate_shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address PrePopulateShippingAddress { get; }

        /// <summary>
        /// The URL to redirect to after checkout is completed with `checkoutId`,
        /// Square's `orderId`, `transactionId`, and `referenceId` appended as URL
        /// parameters. For example, if the provided redirect_url is
        /// `http://www.example.com/order-complete`, a successful transaction redirects
        /// the customer to:
        /// <pre><code>http://www.example.com/order-complete?checkoutId=xxxxxx&amp;orderId=xxxxxx&amp;referenceId=xxxxxx&amp;transactionId=xxxxxx</code></pre>
        /// If you do not provide a redirect URL, Square Checkout will display an order
        /// confirmation page on your behalf; however Square strongly recommends that
        /// you provide a redirect URL so you can verify the transaction results and
        /// finalize the order through your existing/normal confirmation workflow.
        /// </summary>
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; }

        /// <summary>
        /// Contains all information related to a single order to process with Square,
        /// including line items that specify the products to purchase. `Order` objects also
        /// include information about any associated tenders, refunds, and returns.
        /// All Connect V2 Transactions have all been converted to Orders including all associated
        /// itemization data.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Order Order { get; }

        /// <summary>
        /// The time when the checkout was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// Additional recipients (other than the merchant) receiving a portion of this checkout.
        /// For example, fees assessed on the purchase by a third party integration.
        /// </summary>
        [JsonProperty("additional_recipients", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.AdditionalRecipient> AdditionalRecipients { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Checkout : ({string.Join(", ", toStringOutput)})";
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

            return obj is Checkout other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CheckoutPageUrl == null && other.CheckoutPageUrl == null) || (this.CheckoutPageUrl?.Equals(other.CheckoutPageUrl) == true)) &&
                ((this.AskForShippingAddress == null && other.AskForShippingAddress == null) || (this.AskForShippingAddress?.Equals(other.AskForShippingAddress) == true)) &&
                ((this.MerchantSupportEmail == null && other.MerchantSupportEmail == null) || (this.MerchantSupportEmail?.Equals(other.MerchantSupportEmail) == true)) &&
                ((this.PrePopulateBuyerEmail == null && other.PrePopulateBuyerEmail == null) || (this.PrePopulateBuyerEmail?.Equals(other.PrePopulateBuyerEmail) == true)) &&
                ((this.PrePopulateShippingAddress == null && other.PrePopulateShippingAddress == null) || (this.PrePopulateShippingAddress?.Equals(other.PrePopulateShippingAddress) == true)) &&
                ((this.RedirectUrl == null && other.RedirectUrl == null) || (this.RedirectUrl?.Equals(other.RedirectUrl) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.AdditionalRecipients == null && other.AdditionalRecipients == null) || (this.AdditionalRecipients?.Equals(other.AdditionalRecipients) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1629433824;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.CheckoutPageUrl != null)
            {
               hashCode += this.CheckoutPageUrl.GetHashCode();
            }

            if (this.AskForShippingAddress != null)
            {
               hashCode += this.AskForShippingAddress.GetHashCode();
            }

            if (this.MerchantSupportEmail != null)
            {
               hashCode += this.MerchantSupportEmail.GetHashCode();
            }

            if (this.PrePopulateBuyerEmail != null)
            {
               hashCode += this.PrePopulateBuyerEmail.GetHashCode();
            }

            if (this.PrePopulateShippingAddress != null)
            {
               hashCode += this.PrePopulateShippingAddress.GetHashCode();
            }

            if (this.RedirectUrl != null)
            {
               hashCode += this.RedirectUrl.GetHashCode();
            }

            if (this.Order != null)
            {
               hashCode += this.Order.GetHashCode();
            }

            if (this.CreatedAt != null)
            {
               hashCode += this.CreatedAt.GetHashCode();
            }

            if (this.AdditionalRecipients != null)
            {
               hashCode += this.AdditionalRecipients.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.CheckoutPageUrl = {(this.CheckoutPageUrl == null ? "null" : this.CheckoutPageUrl == string.Empty ? "" : this.CheckoutPageUrl)}");
            toStringOutput.Add($"this.AskForShippingAddress = {(this.AskForShippingAddress == null ? "null" : this.AskForShippingAddress.ToString())}");
            toStringOutput.Add($"this.MerchantSupportEmail = {(this.MerchantSupportEmail == null ? "null" : this.MerchantSupportEmail == string.Empty ? "" : this.MerchantSupportEmail)}");
            toStringOutput.Add($"this.PrePopulateBuyerEmail = {(this.PrePopulateBuyerEmail == null ? "null" : this.PrePopulateBuyerEmail == string.Empty ? "" : this.PrePopulateBuyerEmail)}");
            toStringOutput.Add($"this.PrePopulateShippingAddress = {(this.PrePopulateShippingAddress == null ? "null" : this.PrePopulateShippingAddress.ToString())}");
            toStringOutput.Add($"this.RedirectUrl = {(this.RedirectUrl == null ? "null" : this.RedirectUrl == string.Empty ? "" : this.RedirectUrl)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.AdditionalRecipients = {(this.AdditionalRecipients == null ? "null" : $"[{string.Join(", ", this.AdditionalRecipients)} ]")}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(this.Id)
                .CheckoutPageUrl(this.CheckoutPageUrl)
                .AskForShippingAddress(this.AskForShippingAddress)
                .MerchantSupportEmail(this.MerchantSupportEmail)
                .PrePopulateBuyerEmail(this.PrePopulateBuyerEmail)
                .PrePopulateShippingAddress(this.PrePopulateShippingAddress)
                .RedirectUrl(this.RedirectUrl)
                .Order(this.Order)
                .CreatedAt(this.CreatedAt)
                .AdditionalRecipients(this.AdditionalRecipients);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string id;
            private string checkoutPageUrl;
            private bool? askForShippingAddress;
            private string merchantSupportEmail;
            private string prePopulateBuyerEmail;
            private Models.Address prePopulateShippingAddress;
            private string redirectUrl;
            private Models.Order order;
            private string createdAt;
            private IList<Models.AdditionalRecipient> additionalRecipients;

             /// <summary>
             /// Id.
             /// </summary>
             /// <param name="id"> id. </param>
             /// <returns> Builder. </returns>
            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

             /// <summary>
             /// CheckoutPageUrl.
             /// </summary>
             /// <param name="checkoutPageUrl"> checkoutPageUrl. </param>
             /// <returns> Builder. </returns>
            public Builder CheckoutPageUrl(string checkoutPageUrl)
            {
                this.checkoutPageUrl = checkoutPageUrl;
                return this;
            }

             /// <summary>
             /// AskForShippingAddress.
             /// </summary>
             /// <param name="askForShippingAddress"> askForShippingAddress. </param>
             /// <returns> Builder. </returns>
            public Builder AskForShippingAddress(bool? askForShippingAddress)
            {
                this.askForShippingAddress = askForShippingAddress;
                return this;
            }

             /// <summary>
             /// MerchantSupportEmail.
             /// </summary>
             /// <param name="merchantSupportEmail"> merchantSupportEmail. </param>
             /// <returns> Builder. </returns>
            public Builder MerchantSupportEmail(string merchantSupportEmail)
            {
                this.merchantSupportEmail = merchantSupportEmail;
                return this;
            }

             /// <summary>
             /// PrePopulateBuyerEmail.
             /// </summary>
             /// <param name="prePopulateBuyerEmail"> prePopulateBuyerEmail. </param>
             /// <returns> Builder. </returns>
            public Builder PrePopulateBuyerEmail(string prePopulateBuyerEmail)
            {
                this.prePopulateBuyerEmail = prePopulateBuyerEmail;
                return this;
            }

             /// <summary>
             /// PrePopulateShippingAddress.
             /// </summary>
             /// <param name="prePopulateShippingAddress"> prePopulateShippingAddress. </param>
             /// <returns> Builder. </returns>
            public Builder PrePopulateShippingAddress(Models.Address prePopulateShippingAddress)
            {
                this.prePopulateShippingAddress = prePopulateShippingAddress;
                return this;
            }

             /// <summary>
             /// RedirectUrl.
             /// </summary>
             /// <param name="redirectUrl"> redirectUrl. </param>
             /// <returns> Builder. </returns>
            public Builder RedirectUrl(string redirectUrl)
            {
                this.redirectUrl = redirectUrl;
                return this;
            }

             /// <summary>
             /// Order.
             /// </summary>
             /// <param name="order"> order. </param>
             /// <returns> Builder. </returns>
            public Builder Order(Models.Order order)
            {
                this.order = order;
                return this;
            }

             /// <summary>
             /// CreatedAt.
             /// </summary>
             /// <param name="createdAt"> createdAt. </param>
             /// <returns> Builder. </returns>
            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

             /// <summary>
             /// AdditionalRecipients.
             /// </summary>
             /// <param name="additionalRecipients"> additionalRecipients. </param>
             /// <returns> Builder. </returns>
            public Builder AdditionalRecipients(IList<Models.AdditionalRecipient> additionalRecipients)
            {
                this.additionalRecipients = additionalRecipients;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> Checkout. </returns>
            public Checkout Build()
            {
                return new Checkout(
                    this.id,
                    this.checkoutPageUrl,
                    this.askForShippingAddress,
                    this.merchantSupportEmail,
                    this.prePopulateBuyerEmail,
                    this.prePopulateShippingAddress,
                    this.redirectUrl,
                    this.order,
                    this.createdAt,
                    this.additionalRecipients);
            }
        }
    }
}