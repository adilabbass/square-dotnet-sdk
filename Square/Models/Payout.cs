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
    /// Payout.
    /// </summary>
    public class Payout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payout"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="amountMoney">amount_money.</param>
        /// <param name="destination">destination.</param>
        /// <param name="version">version.</param>
        /// <param name="type">type.</param>
        /// <param name="payoutFee">payout_fee.</param>
        /// <param name="arrivalDate">arrival_date.</param>
        public Payout(
            string id,
            string locationId,
            string status = null,
            string createdAt = null,
            string updatedAt = null,
            Models.Money amountMoney = null,
            Models.Destination destination = null,
            int? version = null,
            string type = null,
            IList<Models.PayoutFee> payoutFee = null,
            string arrivalDate = null)
        {
            this.Id = id;
            this.Status = status;
            this.LocationId = locationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AmountMoney = amountMoney;
            this.Destination = destination;
            this.Version = version;
            this.Type = type;
            this.PayoutFee = payoutFee;
            this.ArrivalDate = arrivalDate;
        }

        /// <summary>
        /// A unique ID for the payout.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// Payout status types
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        /// <summary>
        /// The ID of the location associated with the payout.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; }

        /// <summary>
        /// The timestamp of when the payout was created and submitted for deposit to the seller's banking destination, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The timestamp of when the payout was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; }

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
        /// Information about the destination against which the payout was made.
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Destination Destination { get; }

        /// <summary>
        /// The version number, which is incremented each time an update is made to this payout record.
        /// The version number helps developers receive event notifications or feeds out of order.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; }

        /// <summary>
        /// The type of payout: “BATCH” or “SIMPLE”.
        /// BATCH payouts include a list of payout entries that can be considered settled.
        /// SIMPLE payouts do not have any payout entries associated with them
        /// and will show up as one of the payout entries in a future BATCH payout.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; }

        /// <summary>
        /// A list of processing fees and any taxes on the fees assessed by Square for this payout.
        /// </summary>
        [JsonProperty("payout_fee", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.PayoutFee> PayoutFee { get; }

        /// <summary>
        /// The calendar date, in ISO 8601 format (YYYY-MM-DD), when the payout is due to arrive in the seller’s banking destination.
        /// </summary>
        [JsonProperty("arrival_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrivalDate { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Payout : ({string.Join(", ", toStringOutput)})";
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

            return obj is Payout other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.AmountMoney == null && other.AmountMoney == null) || (this.AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.PayoutFee == null && other.PayoutFee == null) || (this.PayoutFee?.Equals(other.PayoutFee) == true)) &&
                ((this.ArrivalDate == null && other.ArrivalDate == null) || (this.ArrivalDate?.Equals(other.ArrivalDate) == true));
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 198657879;
            hashCode = HashCode.Combine(this.Id, this.Status, this.LocationId, this.CreatedAt, this.UpdatedAt, this.AmountMoney, this.Destination);

            hashCode = HashCode.Combine(hashCode, this.Version, this.Type, this.PayoutFee, this.ArrivalDate);

            return hashCode;
        }
  
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId == string.Empty ? "" : this.LocationId)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt == string.Empty ? "" : this.UpdatedAt)}");
            toStringOutput.Add($"this.AmountMoney = {(this.AmountMoney == null ? "null" : this.AmountMoney.ToString())}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.PayoutFee = {(this.PayoutFee == null ? "null" : $"[{string.Join(", ", this.PayoutFee)} ]")}");
            toStringOutput.Add($"this.ArrivalDate = {(this.ArrivalDate == null ? "null" : this.ArrivalDate == string.Empty ? "" : this.ArrivalDate)}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder(
                this.Id,
                this.LocationId)
                .Status(this.Status)
                .CreatedAt(this.CreatedAt)
                .UpdatedAt(this.UpdatedAt)
                .AmountMoney(this.AmountMoney)
                .Destination(this.Destination)
                .Version(this.Version)
                .Type(this.Type)
                .PayoutFee(this.PayoutFee)
                .ArrivalDate(this.ArrivalDate);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string id;
            private string locationId;
            private string status;
            private string createdAt;
            private string updatedAt;
            private Models.Money amountMoney;
            private Models.Destination destination;
            private int? version;
            private string type;
            private IList<Models.PayoutFee> payoutFee;
            private string arrivalDate;

            public Builder(
                string id,
                string locationId)
            {
                this.id = id;
                this.locationId = locationId;
            }

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
             /// LocationId.
             /// </summary>
             /// <param name="locationId"> locationId. </param>
             /// <returns> Builder. </returns>
            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

             /// <summary>
             /// Status.
             /// </summary>
             /// <param name="status"> status. </param>
             /// <returns> Builder. </returns>
            public Builder Status(string status)
            {
                this.status = status;
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
             /// UpdatedAt.
             /// </summary>
             /// <param name="updatedAt"> updatedAt. </param>
             /// <returns> Builder. </returns>
            public Builder UpdatedAt(string updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

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
             /// Destination.
             /// </summary>
             /// <param name="destination"> destination. </param>
             /// <returns> Builder. </returns>
            public Builder Destination(Models.Destination destination)
            {
                this.destination = destination;
                return this;
            }

             /// <summary>
             /// Version.
             /// </summary>
             /// <param name="version"> version. </param>
             /// <returns> Builder. </returns>
            public Builder Version(int? version)
            {
                this.version = version;
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
             /// PayoutFee.
             /// </summary>
             /// <param name="payoutFee"> payoutFee. </param>
             /// <returns> Builder. </returns>
            public Builder PayoutFee(IList<Models.PayoutFee> payoutFee)
            {
                this.payoutFee = payoutFee;
                return this;
            }

             /// <summary>
             /// ArrivalDate.
             /// </summary>
             /// <param name="arrivalDate"> arrivalDate. </param>
             /// <returns> Builder. </returns>
            public Builder ArrivalDate(string arrivalDate)
            {
                this.arrivalDate = arrivalDate;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> Payout. </returns>
            public Payout Build()
            {
                return new Payout(
                    this.id,
                    this.locationId,
                    this.status,
                    this.createdAt,
                    this.updatedAt,
                    this.amountMoney,
                    this.destination,
                    this.version,
                    this.type,
                    this.payoutFee,
                    this.arrivalDate);
            }
        }
    }
}