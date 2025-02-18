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
    /// PayOrderRequest.
    /// </summary>
    public class PayOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequest"/> class.
        /// </summary>
        /// <param name="idempotencyKey">idempotency_key.</param>
        /// <param name="orderVersion">order_version.</param>
        /// <param name="paymentIds">payment_ids.</param>
        public PayOrderRequest(
            string idempotencyKey,
            int? orderVersion = null,
            IList<string> paymentIds = null)
        {
            this.IdempotencyKey = idempotencyKey;
            this.OrderVersion = orderVersion;
            this.PaymentIds = paymentIds;
        }

        /// <summary>
        /// A value you specify that uniquely identifies this request among requests you have sent. If
        /// you are unsure whether a particular payment request was completed successfully, you can reattempt
        /// it with the same idempotency key without worrying about duplicate payments.
        /// For more information, see [Idempotency](https://developer.squareup.com/docs/working-with-apis/idempotency).
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; }

        /// <summary>
        /// The version of the order being paid. If not supplied, the latest version will be paid.
        /// </summary>
        [JsonProperty("order_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderVersion { get; }

        /// <summary>
        /// The IDs of the [payments]($m/Payment) to collect.
        /// The payment total must match the order total.
        /// </summary>
        [JsonProperty("payment_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> PaymentIds { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayOrderRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is PayOrderRequest other &&
                ((this.IdempotencyKey == null && other.IdempotencyKey == null) || (this.IdempotencyKey?.Equals(other.IdempotencyKey) == true)) &&
                ((this.OrderVersion == null && other.OrderVersion == null) || (this.OrderVersion?.Equals(other.OrderVersion) == true)) &&
                ((this.PaymentIds == null && other.PaymentIds == null) || (this.PaymentIds?.Equals(other.PaymentIds) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -320446863;
            hashCode = HashCode.Combine(this.IdempotencyKey, this.OrderVersion, this.PaymentIds);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IdempotencyKey = {(this.IdempotencyKey == null ? "null" : this.IdempotencyKey == string.Empty ? "" : this.IdempotencyKey)}");
            toStringOutput.Add($"this.OrderVersion = {(this.OrderVersion == null ? "null" : this.OrderVersion.ToString())}");
            toStringOutput.Add($"this.PaymentIds = {(this.PaymentIds == null ? "null" : $"[{string.Join(", ", this.PaymentIds)} ]")}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder(
                this.IdempotencyKey)
                .OrderVersion(this.OrderVersion)
                .PaymentIds(this.PaymentIds);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string idempotencyKey;
            private int? orderVersion;
            private IList<string> paymentIds;

            public Builder(
                string idempotencyKey)
            {
                this.idempotencyKey = idempotencyKey;
            }

             /// <summary>
             /// IdempotencyKey.
             /// </summary>
             /// <param name="idempotencyKey"> idempotencyKey. </param>
             /// <returns> Builder. </returns>
            public Builder IdempotencyKey(string idempotencyKey)
            {
                this.idempotencyKey = idempotencyKey;
                return this;
            }

             /// <summary>
             /// OrderVersion.
             /// </summary>
             /// <param name="orderVersion"> orderVersion. </param>
             /// <returns> Builder. </returns>
            public Builder OrderVersion(int? orderVersion)
            {
                this.orderVersion = orderVersion;
                return this;
            }

             /// <summary>
             /// PaymentIds.
             /// </summary>
             /// <param name="paymentIds"> paymentIds. </param>
             /// <returns> Builder. </returns>
            public Builder PaymentIds(IList<string> paymentIds)
            {
                this.paymentIds = paymentIds;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> PayOrderRequest. </returns>
            public PayOrderRequest Build()
            {
                return new PayOrderRequest(
                    this.idempotencyKey,
                    this.orderVersion,
                    this.paymentIds);
            }
        }
    }
}