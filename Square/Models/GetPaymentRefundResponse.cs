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
    using Square.Http.Client;
    using Square.Utilities;

    /// <summary>
    /// GetPaymentRefundResponse.
    /// </summary>
    public class GetPaymentRefundResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentRefundResponse"/> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="refund">refund.</param>
        public GetPaymentRefundResponse(
            IList<Models.Error> errors = null,
            Models.PaymentRefund refund = null)
        {
            this.Errors = errors;
            this.Refund = refund;
        }

        /// <summary>
        /// Gets http context.
        /// </summary>
        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Information about errors encountered during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        /// <summary>
        /// Represents a refund of a payment made using Square. Contains information about
        /// the original payment and the amount of money refunded.
        /// </summary>
        [JsonProperty("refund", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentRefund Refund { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPaymentRefundResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPaymentRefundResponse other &&
                ((this.Context == null && other.Context == null) || (this.Context?.Equals(other.Context) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true)) &&
                ((this.Refund == null && other.Refund == null) || (this.Refund?.Equals(other.Refund) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -228452893;

            if (this.Context != null)
            {
                hashCode += this.Context.GetHashCode();
            }
            hashCode = HashCode.Combine(this.Errors, this.Refund);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
            toStringOutput.Add($"this.Refund = {(this.Refund == null ? "null" : this.Refund.ToString())}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Errors(this.Errors)
                .Refund(this.Refund);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private IList<Models.Error> errors;
            private Models.PaymentRefund refund;

             /// <summary>
             /// Errors.
             /// </summary>
             /// <param name="errors"> errors. </param>
             /// <returns> Builder. </returns>
            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

             /// <summary>
             /// Refund.
             /// </summary>
             /// <param name="refund"> refund. </param>
             /// <returns> Builder. </returns>
            public Builder Refund(Models.PaymentRefund refund)
            {
                this.refund = refund;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> GetPaymentRefundResponse. </returns>
            public GetPaymentRefundResponse Build()
            {
                return new GetPaymentRefundResponse(
                    this.errors,
                    this.refund);
            }
        }
    }
}