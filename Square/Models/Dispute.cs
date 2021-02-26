
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class Dispute 
    {
        public Dispute(string disputeId = null,
            Models.Money amountMoney = null,
            string reason = null,
            string state = null,
            string dueAt = null,
            Models.DisputedPayment disputedPayment = null,
            IList<string> evidenceIds = null,
            string cardBrand = null,
            string createdAt = null,
            string updatedAt = null,
            string brandDisputeId = null,
            string reportedDate = null,
            int? version = null,
            string locationId = null)
        {
            DisputeId = disputeId;
            AmountMoney = amountMoney;
            Reason = reason;
            State = state;
            DueAt = dueAt;
            DisputedPayment = disputedPayment;
            EvidenceIds = evidenceIds;
            CardBrand = cardBrand;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            BrandDisputeId = brandDisputeId;
            ReportedDate = reportedDate;
            Version = version;
            LocationId = locationId;
        }

        /// <summary>
        /// The unique ID for this `Dispute`, generated by Square.
        /// </summary>
        [JsonProperty("dispute_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DisputeId { get; }

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
        /// The list of possible reasons why a cardholder might initiate a
        /// dispute with their bank.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; }

        /// <summary>
        /// The list of possible dispute states.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; }

        /// <summary>
        /// The time when the next action is due, in RFC 3339 format.
        /// </summary>
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAt { get; }

        /// <summary>
        /// The payment the cardholder disputed.
        /// </summary>
        [JsonProperty("disputed_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DisputedPayment DisputedPayment { get; }

        /// <summary>
        /// The IDs of the evidence associated with the dispute.
        /// </summary>
        [JsonProperty("evidence_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> EvidenceIds { get; }

        /// <summary>
        /// Indicates a card's brand, such as `VISA` or `MASTERCARD`.
        /// </summary>
        [JsonProperty("card_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBrand { get; }

        /// <summary>
        /// The timestamp when the dispute was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The timestamp when the dispute was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; }

        /// <summary>
        /// The ID of the dispute in the card brand system, generated by the card brand.
        /// </summary>
        [JsonProperty("brand_dispute_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandDisputeId { get; }

        /// <summary>
        /// The timestamp when the dispute was reported, in RFC 3339 format.
        /// </summary>
        [JsonProperty("reported_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportedDate { get; }

        /// <summary>
        /// The current version of the `Dispute`.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; }

        /// <summary>
        /// The ID of the location where the dispute originated.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Dispute : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DisputeId = {(DisputeId == null ? "null" : DisputeId == string.Empty ? "" : DisputeId)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"Reason = {(Reason == null ? "null" : Reason.ToString())}");
            toStringOutput.Add($"State = {(State == null ? "null" : State.ToString())}");
            toStringOutput.Add($"DueAt = {(DueAt == null ? "null" : DueAt == string.Empty ? "" : DueAt)}");
            toStringOutput.Add($"DisputedPayment = {(DisputedPayment == null ? "null" : DisputedPayment.ToString())}");
            toStringOutput.Add($"EvidenceIds = {(EvidenceIds == null ? "null" : $"[{ string.Join(", ", EvidenceIds)} ]")}");
            toStringOutput.Add($"CardBrand = {(CardBrand == null ? "null" : CardBrand.ToString())}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt == string.Empty ? "" : UpdatedAt)}");
            toStringOutput.Add($"BrandDisputeId = {(BrandDisputeId == null ? "null" : BrandDisputeId == string.Empty ? "" : BrandDisputeId)}");
            toStringOutput.Add($"ReportedDate = {(ReportedDate == null ? "null" : ReportedDate == string.Empty ? "" : ReportedDate)}");
            toStringOutput.Add($"Version = {(Version == null ? "null" : Version.ToString())}");
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
        }

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

            return obj is Dispute other &&
                ((DisputeId == null && other.DisputeId == null) || (DisputeId?.Equals(other.DisputeId) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((Reason == null && other.Reason == null) || (Reason?.Equals(other.Reason) == true)) &&
                ((State == null && other.State == null) || (State?.Equals(other.State) == true)) &&
                ((DueAt == null && other.DueAt == null) || (DueAt?.Equals(other.DueAt) == true)) &&
                ((DisputedPayment == null && other.DisputedPayment == null) || (DisputedPayment?.Equals(other.DisputedPayment) == true)) &&
                ((EvidenceIds == null && other.EvidenceIds == null) || (EvidenceIds?.Equals(other.EvidenceIds) == true)) &&
                ((CardBrand == null && other.CardBrand == null) || (CardBrand?.Equals(other.CardBrand) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((BrandDisputeId == null && other.BrandDisputeId == null) || (BrandDisputeId?.Equals(other.BrandDisputeId) == true)) &&
                ((ReportedDate == null && other.ReportedDate == null) || (ReportedDate?.Equals(other.ReportedDate) == true)) &&
                ((Version == null && other.Version == null) || (Version?.Equals(other.Version) == true)) &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1993475725;

            if (DisputeId != null)
            {
               hashCode += DisputeId.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (Reason != null)
            {
               hashCode += Reason.GetHashCode();
            }

            if (State != null)
            {
               hashCode += State.GetHashCode();
            }

            if (DueAt != null)
            {
               hashCode += DueAt.GetHashCode();
            }

            if (DisputedPayment != null)
            {
               hashCode += DisputedPayment.GetHashCode();
            }

            if (EvidenceIds != null)
            {
               hashCode += EvidenceIds.GetHashCode();
            }

            if (CardBrand != null)
            {
               hashCode += CardBrand.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (BrandDisputeId != null)
            {
               hashCode += BrandDisputeId.GetHashCode();
            }

            if (ReportedDate != null)
            {
               hashCode += ReportedDate.GetHashCode();
            }

            if (Version != null)
            {
               hashCode += Version.GetHashCode();
            }

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .DisputeId(DisputeId)
                .AmountMoney(AmountMoney)
                .Reason(Reason)
                .State(State)
                .DueAt(DueAt)
                .DisputedPayment(DisputedPayment)
                .EvidenceIds(EvidenceIds)
                .CardBrand(CardBrand)
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .BrandDisputeId(BrandDisputeId)
                .ReportedDate(ReportedDate)
                .Version(Version)
                .LocationId(LocationId);
            return builder;
        }

        public class Builder
        {
            private string disputeId;
            private Models.Money amountMoney;
            private string reason;
            private string state;
            private string dueAt;
            private Models.DisputedPayment disputedPayment;
            private IList<string> evidenceIds;
            private string cardBrand;
            private string createdAt;
            private string updatedAt;
            private string brandDisputeId;
            private string reportedDate;
            private int? version;
            private string locationId;



            public Builder DisputeId(string disputeId)
            {
                this.disputeId = disputeId;
                return this;
            }

            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

            public Builder Reason(string reason)
            {
                this.reason = reason;
                return this;
            }

            public Builder State(string state)
            {
                this.state = state;
                return this;
            }

            public Builder DueAt(string dueAt)
            {
                this.dueAt = dueAt;
                return this;
            }

            public Builder DisputedPayment(Models.DisputedPayment disputedPayment)
            {
                this.disputedPayment = disputedPayment;
                return this;
            }

            public Builder EvidenceIds(IList<string> evidenceIds)
            {
                this.evidenceIds = evidenceIds;
                return this;
            }

            public Builder CardBrand(string cardBrand)
            {
                this.cardBrand = cardBrand;
                return this;
            }

            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder UpdatedAt(string updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

            public Builder BrandDisputeId(string brandDisputeId)
            {
                this.brandDisputeId = brandDisputeId;
                return this;
            }

            public Builder ReportedDate(string reportedDate)
            {
                this.reportedDate = reportedDate;
                return this;
            }

            public Builder Version(int? version)
            {
                this.version = version;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Dispute Build()
            {
                return new Dispute(disputeId,
                    amountMoney,
                    reason,
                    state,
                    dueAt,
                    disputedPayment,
                    evidenceIds,
                    cardBrand,
                    createdAt,
                    updatedAt,
                    brandDisputeId,
                    reportedDate,
                    version,
                    locationId);
            }
        }
    }
}