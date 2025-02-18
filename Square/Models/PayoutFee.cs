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
    /// PayoutFee.
    /// </summary>
    public class PayoutFee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutFee"/> class.
        /// </summary>
        /// <param name="amountMoney">amount_money.</param>
        /// <param name="effectiveAt">effective_at.</param>
        /// <param name="type">type.</param>
        public PayoutFee(
            Models.Money amountMoney = null,
            string effectiveAt = null,
            string type = null)
        {
            this.AmountMoney = amountMoney;
            this.EffectiveAt = effectiveAt;
            this.Type = type;
        }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AmountMoney { get; }

        /// <summary>
        /// The timestamp of when the fee takes effect, in RFC 3339 format.
        /// </summary>
        [JsonProperty("effective_at", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveAt { get; }

        /// <summary>
        /// Represents the type of payout fee that can incur as part of a payout.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayoutFee : ({string.Join(", ", toStringOutput)})";
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

            return obj is PayoutFee other &&
                ((this.AmountMoney == null && other.AmountMoney == null) || (this.AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((this.EffectiveAt == null && other.EffectiveAt == null) || (this.EffectiveAt?.Equals(other.EffectiveAt) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1005601132;
            hashCode = HashCode.Combine(this.AmountMoney, this.EffectiveAt, this.Type);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmountMoney = {(this.AmountMoney == null ? "null" : this.AmountMoney.ToString())}");
            toStringOutput.Add($"this.EffectiveAt = {(this.EffectiveAt == null ? "null" : this.EffectiveAt == string.Empty ? "" : this.EffectiveAt)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .AmountMoney(this.AmountMoney)
                .EffectiveAt(this.EffectiveAt)
                .Type(this.Type);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Models.Money amountMoney;
            private string effectiveAt;
            private string type;

             /// <summary>
             /// AmountMoney.
             /// </summary>
             /// <param name="amountMoney"> amountMoney. </param>
             /// <returns> Builder. </returns>
            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

             /// <summary>
             /// EffectiveAt.
             /// </summary>
             /// <param name="effectiveAt"> effectiveAt. </param>
             /// <returns> Builder. </returns>
            public Builder EffectiveAt(string effectiveAt)
            {
                this.effectiveAt = effectiveAt;
                return this;
            }

             /// <summary>
             /// Type.
             /// </summary>
             /// <param name="type"> type. </param>
             /// <returns> Builder. </returns>
            public Builder Type(string type)
            {
                this.type = type;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> PayoutFee. </returns>
            public PayoutFee Build()
            {
                return new PayoutFee(
                    this.amountMoney,
                    this.effectiveAt,
                    this.type);
            }
        }
    }
}